using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace QuanLyBanHang.Functions
{
    public partial class FormDatHang : Form
    {
        /// <summary>
        /// Chuỗi kết nối
        /// Lấy từ cấu hình (settings) của Project
        /// </summary>
        string connectionString = QuanLyBanHang.Properties.Settings.Default.QuanLyBanHangDatabaseConnectionString;

        SortedDictionary<int, string> listEmployees = new SortedDictionary<int, string>();
        SortedDictionary<int, string> listCustomers = new SortedDictionary<int, string>();
        SortedDictionary<int, string> listProducts = new SortedDictionary<int, string>();

        /* Biến lưu trữ Trạng thái của Form. 
         * Các trạng thái của Form: 
         * - View   : chỉ xem, không được hiệu chỉnh gì
         * - Create : clear dữ liệu, cho phép nhập dữ liệu
         * - Edit   : lấy dữ liệu cũ, cho phép hiệu chỉnh dữ liệu đang có
         * => Mặc định khi mở Form sẽ là trạng thái VIEW
         */
        string _formStatus = "View";

        public string FormStatus
        {
            get
            {
                return _formStatus;
            }
            set
            {
                _formStatus = value;
                // Thay đổi trạng thái của các Controls tương ứng với Trạng thái của Form
                switch (_formStatus)
                {
                    case "View":
                        // Danh sách Đơn hàng
                        dtpTuNgay.Enabled = true;
                        dtpDenNgay.Enabled = true;
                        btnLayDanhSachDonHang.Enabled = true;

                        // Thông tin Đơn hàng
                        grpThongTinDonHang.Enabled = false;

                        // Thông tin Chi tiết Đơn hàng
                        grpThongTinChiTietDonHang.Enabled = false;

                        // Set trạng thái các nút button
                        btnInHoaDon.Enabled = true;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                        btnLuu.Enabled = false;
                        btnThoat.Enabled = true;
                        btnThoat.Text = "Thoát";
                        break;
                    case "Create":
                        // Danh sách Đơn hàng
                        dtpTuNgay.Enabled = false;
                        dtpDenNgay.Enabled = false;
                        btnLayDanhSachDonHang.Enabled = false;

                        // Thông tin Đơn hàng
                        grpThongTinDonHang.Enabled = true;

                        // Thông tin Chi tiết Đơn hàng
                        grpThongTinChiTietDonHang.Enabled = true;

                        // Set trạng thái các nút button
                        btnInHoaDon.Enabled = false;
                        btnThem.Enabled = false;
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnLuu.Enabled = true;
                        btnThoat.Enabled = true;
                        btnThoat.Text = "Hủy bỏ";
                        break;
                    case "Edit":
                        // Danh sách Đơn hàng
                        dtpTuNgay.Enabled = false;
                        dtpDenNgay.Enabled = false;
                        btnLayDanhSachDonHang.Enabled = false;

                        // Thông tin Đơn hàng
                        grpThongTinDonHang.Enabled = true;

                        // Thông tin Chi tiết Đơn hàng
                        grpThongTinChiTietDonHang.Enabled = true;

                        // Set trạng thái các nút button
                        btnInHoaDon.Enabled = false;
                        btnThem.Enabled = false;
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnLuu.Enabled = true;
                        btnThoat.Enabled = true;
                        btnThoat.Text = "Hủy bỏ";
                        break;
                }
            }
        }

        public FormDatHang()
        {
            InitializeComponent();
        }

        private void btnLayDanhSachDonHang_Click(object sender, EventArgs e)
        {
            // Load danh sách đơn hàng
            LoadDanhSachDonHang();
        }

        /// <summary>
        /// Hàm dùng để load danh sách cấu hình
        /// </summary>
        public void LoadDanhSachDonHang()
        {
            string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd HH:mm:ss"); // 2019-10-21 20:35:33
            string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd HH:mm:ss"); // 2019-10-21 20:35:33

            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM orders WHERE order_date BETWEEN '{0}' AND '{1}'", tuNgay, denNgay);

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        quanLyBanHangDatabaseDataSet.orders.Clear();
                        adapter.Fill(quanLyBanHangDatabaseDataSet.orders);

                        // Hiển thị dữ liệu
                        ordersBindingSource.DataSource = null;
                        ordersBindingSource.DataSource = quanLyBanHangDatabaseDataSet.orders;
                        dgvDonHang.Refresh();

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Hàm dùng để load danh sách nhân viên
        /// </summary>
        public void LoadDanhSachNhanVien()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM employees");

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(quanLyBanHangDatabaseDataSet.employees);

                        // Hiển thị dữ liệu
                        foreach (DataRow row in quanLyBanHangDatabaseDataSet.employees.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["first_name"].ToString();
                            listEmployees.Add(key, value);
                        }
                        cbbEmployee.DataSource = new BindingSource(listEmployees, null);
                        cbbEmployee.DisplayMember = "Value";
                        cbbEmployee.ValueMember = "Key";

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Hàm dùng để load danh sách khách hàng
        /// </summary>
        public void LoadDanhSachKhachHang()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM customers");

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(quanLyBanHangDatabaseDataSet.employees);

                        // Hiển thị dữ liệu
                        foreach (DataRow row in quanLyBanHangDatabaseDataSet.employees.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["first_name"].ToString();
                            listCustomers.Add(key, value);
                        }
                        cbbCustomer.DataSource = new BindingSource(listCustomers, null);
                        cbbCustomer.DisplayMember = "Value";
                        cbbCustomer.ValueMember = "Key";

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Hàm dùng để load danh sách sản phẩm
        /// </summary>
        public void LoadDanhSachSanPham()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM products");

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(quanLyBanHangDatabaseDataSet.products);

                        // Hiển thị dữ liệu
                        foreach (DataRow row in quanLyBanHangDatabaseDataSet.products.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["product_name"].ToString();
                            listProducts.Add(key, value);
                        }
                        cbbProduct.DataSource = new BindingSource(listProducts, null);
                        cbbProduct.DisplayMember = "Value";
                        cbbProduct.ValueMember = "Key";

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Hàm dùng để load chi tiết đơn hàng bởi ID đơn hàng
        /// </summary>
        public void LoadChiTietDonHang(int idDonHang)
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM order_details WHERE order_id = {0}", idDonHang);

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        quanLyBanHangDatabaseDataSet.order_details.Clear();
                        adapter.Fill(quanLyBanHangDatabaseDataSet.order_details);

                        // Hiển thị dữ liệu
                        orderdetailsBindingSource.DataSource = quanLyBanHangDatabaseDataSet.order_details;
                        dgvChiTietDonHang.Refresh();

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chỉ xử lý Binding khi Form đang ở trạng thái "View"
            if (this.FormStatus != "View")
            {
                return;
            }

            // Nếu đang chọn dòng dữ liệu (RowIndex > 0)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng dữ liệu đang chọn
                DataGridViewRow row = this.dgvDonHang.Rows[e.RowIndex];

                // Binding vào các ComboBox tương ứng
                // - ComboBox Nhân viên (Employee)
                if (row.Cells["employeeidDataGridViewTextBoxColumn"].Value != null && row.Cells["employeeidDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    var idEmployee = Convert.ToInt32(row.Cells["employeeidDataGridViewTextBoxColumn"].Value);
                    cbbEmployee.SelectedItem = cbbEmployee.Items.Cast<KeyValuePair<int, string>>().First(item => item.Key == idEmployee);
                }

                // - ComboBox Khách hàng (Customer)
                if (row.Cells["customeridDataGridViewTextBoxColumn"].Value != null && row.Cells["customeridDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    var idCustomer = Convert.ToInt32(row.Cells["customeridDataGridViewTextBoxColumn"].Value);
                    cbbCustomer.SelectedItem = cbbCustomer.Items.Cast<KeyValuePair<int, string>>().First(item => item.Key == idCustomer);
                }

                // Binding vào các textbox thông tin Order tương ứng
                // TODO: bổ sung đầy đủ Binding cho các trường cần thiết
                if (row.Cells["orderdateDataGridViewTextBoxColumn"].Value != null && row.Cells["orderdateDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    order_dateDateTimePicker.Value = Convert.ToDateTime(row.Cells["orderdateDataGridViewTextBoxColumn"].Value);
                }
                if (row.Cells["shippedDateDataGridViewTextBoxColumn"].Value != null && row.Cells["shippedDateDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    shipped_dateDateTimePicker.Value = Convert.ToDateTime(row.Cells["shippedDateDataGridViewTextBoxColumn"].Value);
                }
                if (row.Cells["shipnameDataGridViewTextBoxColumn"].Value != null && row.Cells["shipnameDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    ship_nameTextBox.Text = row.Cells["shipnameDataGridViewTextBoxColumn"].Value.ToString();
                }
                if (row.Cells["shipaddress1DataGridViewTextBoxColumn"].Value != null && row.Cells["shipaddress1DataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    ship_address1TextBox.Text = row.Cells["shipaddress1DataGridViewTextBoxColumn"].Value.ToString();
                }
                if (row.Cells["shipaddress2DataGridViewTextBoxColumn"].Value != null && row.Cells["shipaddress2DataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    ship_address2TextBox.Text = row.Cells["shipaddress2DataGridViewTextBoxColumn"].Value.ToString();
                }
                if (row.Cells["shipcityDataGridViewTextBoxColumn"].Value != null && row.Cells["shipcityDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    ship_cityTextBox.Text = row.Cells["shipcityDataGridViewTextBoxColumn"].Value.ToString();
                }
                if (row.Cells["shipstateDataGridViewTextBoxColumn"].Value != null && row.Cells["shipstateDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    ship_stateTextBox.Text = row.Cells["shipstateDataGridViewTextBoxColumn"].Value.ToString();
                }
                if (row.Cells["shippostalcodeDataGridViewTextBoxColumn"].Value != null && row.Cells["shippostalcodeDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    ship_postal_codeTextBox.Text = row.Cells["shippostalcodeDataGridViewTextBoxColumn"].Value.ToString();
                }
                if (row.Cells["shipcountryDataGridViewTextBoxColumn"].Value != null && row.Cells["shipcountryDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    ship_countryTextBox.Text = row.Cells["shipcountryDataGridViewTextBoxColumn"].Value.ToString();
                }
                if (row.Cells["shippingfeeDataGridViewTextBoxColumn"].Value != null && row.Cells["shippingfeeDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    nudShipping_fee.Text = row.Cells["shippingfeeDataGridViewTextBoxColumn"].Value.ToString();
                }
                if (row.Cells["paymenttypeDataGridViewTextBoxColumn"].Value != null && row.Cells["paymenttypeDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    payment_typeTextBox.Text = row.Cells["paymenttypeDataGridViewTextBoxColumn"].Value.ToString();
                }
                if (row.Cells["paiddateDataGridViewTextBoxColumn"].Value != null && row.Cells["paiddateDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    paid_dateDateTimePicker.Value = Convert.ToDateTime(row.Cells["paiddateDataGridViewTextBoxColumn"].Value);
                }
                if (row.Cells["orderstatusDataGridViewTextBoxColumn"].Value != null && row.Cells["orderstatusDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    order_statusTextBox.Text = row.Cells["orderstatusDataGridViewTextBoxColumn"].Value.ToString();
                }

                // Load chi tiết đơn hàng bởi ID đơn hàng
                if (row.Cells["idDataGridViewTextBoxColumn"].Value != null && row.Cells["idDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    var idDonHang = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                    LoadChiTietDonHang(idDonHang);
                }
            }
        }

        private void FormDatHang_Load(object sender, EventArgs e)
        {
            // Load danh mục
            LoadDanhSachNhanVien();
            LoadDanhSachKhachHang();
            LoadDanhSachSanPham();

            // Chuyển đổi trạng thái của Form
            this.FormStatus = "View";
        }

        // Clear dữ liệu
        public void ClearData()
        {
            // Clear thông tin Combobox
            cbbEmployee.Text = "";
            cbbCustomer.Text = "";

            // Clear thông tin Đơn hàng
            // TODO: clear tất cả thông tin đã Binding của Đơn hàng
            order_dateDateTimePicker.Value = DateTime.Now;
            ship_nameTextBox.Text = "";

            // Clear dữ liệu chi tiết đơn hàng
            cbbProduct.Text = "";
            nudSoLuong.Value = 0;
            nudDonGia.Value = 0;
            nudGiamGia.Value = 0;
            quanLyBanHangDatabaseDataSet.order_details.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Clear dữ liệu
            ClearData();

            // Chuyển đổi trạng thái của Form
            this.FormStatus = "Create";
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            // Chuẩn bị dữ liệu thêm dòng mới
            int orderId = quanLyBanHangDatabaseDataSet.order_details.Rows.Count + 1; // Tạo OrderID giả làm STT
            int productId = ((KeyValuePair<int, string>)cbbProduct.SelectedItem).Key;
            decimal soLuong = nudSoLuong.Value;
            decimal donGia = nudDonGia.Value;
            decimal giamGia = nudGiamGia.Value;
            string status = "On Order";
            string dateAllocated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Thêm vào grid order_details
            quanLyBanHangDatabaseDataSet.order_details.Rows.Add(orderId, productId, soLuong, donGia, giamGia, status, dateAllocated);

            // Clear dữ liệu
            cbbProduct.Text = "";
            nudSoLuong.Value = 0;
            nudDonGia.Value = 0;
            nudGiamGia.Value = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Xử lý theo từng trường hợp
            switch (this.FormStatus)
            {
                // Xử lý Lưu cho trường hợp Thêm mới dữ liệu
                case "Create":
                    // Tạo câu lệnh để thực thi đến database
                    string queryString = @"INSERT INTO orders(employee_id, customer_id, order_date, shipped_date, ship_name, ship_address1, ship_address2, ship_city, ship_state, ship_postal_code, ship_country, shipping_fee, payment_type, paid_date, order_status)"
                                       + " VALUES(@employee_id, @customer_id, @order_date, @shipped_date, @ship_name, @ship_address1, @ship_address2, @ship_city, @ship_state, @ship_postal_code, @ship_country, @shipping_fee, @payment_type, @paid_date, @order_status);"
                                       + " SELECT CAST(scope_identity() AS int)";

                    // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                        using (SqlCommand command = new SqlCommand(queryString, connection))
                        {
                            try
                            {
                                // Mở kết nối đến Database Server
                                connection.Open();

                                // Truyền dữ liệu vào đúng tham số
                                command.CommandType = CommandType.Text;
                                command.Parameters.AddWithValue("@employee_id", ((KeyValuePair<int, string>)cbbEmployee.SelectedItem).Key);
                                command.Parameters.AddWithValue("@customer_id", ((KeyValuePair<int, string>)cbbCustomer.SelectedItem).Key);
                                command.Parameters.AddWithValue("@order_date", order_dateDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                                command.Parameters.AddWithValue("@shipped_date", shipped_dateDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                                command.Parameters.AddWithValue("@ship_name", ship_nameTextBox.Text);
                                command.Parameters.AddWithValue("@ship_address1", ship_address1TextBox.Text);
                                command.Parameters.AddWithValue("@ship_address2", ship_address2TextBox.Text);
                                command.Parameters.AddWithValue("@ship_city", ship_cityTextBox.Text);
                                command.Parameters.AddWithValue("@ship_state", ship_stateTextBox.Text);
                                command.Parameters.AddWithValue("@ship_postal_code", ship_postal_codeTextBox.Text);
                                command.Parameters.AddWithValue("@ship_country", ship_countryTextBox.Text);
                                command.Parameters.AddWithValue("@shipping_fee", nudShipping_fee.Value);
                                command.Parameters.AddWithValue("@payment_type", payment_typeTextBox.Text);
                                command.Parameters.AddWithValue("@paid_date", paid_dateDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                                command.Parameters.AddWithValue("@order_status", order_statusTextBox.Text);

                                // Thực thi câu lệnh INSERT order và lấy ORDER_ID
                                int orderIdInserted = (int)command.ExecuteScalar();

                                // Insert table Order_details
                                foreach (DataRow row in quanLyBanHangDatabaseDataSet.order_details.Rows)
                                {
                                    int orderId = orderIdInserted;
                                    int productId = Convert.ToInt32(row["product_id"]);
                                    decimal soLuong = Convert.ToInt32(row["quantity"]);
                                    decimal donGia = Convert.ToInt32(row["unit_price"]);
                                    decimal giamGia = Convert.ToInt32(row["discount"]);
                                    string status = row["order_detail_status"].ToString();
                                    string dateAllocated = row["date_allocated"].ToString();

                                    string subQueryString = @"INSERT INTO order_details(order_id, product_id, quantity, unit_price, discount, order_detail_status, date_allocated)"
                                       + " VALUES(@order_id, @product_id, @quantity, @unit_price, @discount, @order_detail_status, @date_allocated)";

                                    // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                                    using (SqlCommand subCommand = new SqlCommand(subQueryString, connection))
                                    {
                                        // Truyền dữ liệu vào đúng tham số
                                        subCommand.CommandType = CommandType.Text;
                                        subCommand.Parameters.AddWithValue("@order_id", orderId);
                                        subCommand.Parameters.AddWithValue("@product_id", productId);
                                        subCommand.Parameters.AddWithValue("@quantity", soLuong);
                                        subCommand.Parameters.AddWithValue("@unit_price", donGia);
                                        subCommand.Parameters.AddWithValue("@discount", giamGia);
                                        subCommand.Parameters.AddWithValue("@order_detail_status", status);
                                        subCommand.Parameters.AddWithValue("@date_allocated", dateAllocated);

                                        subCommand.ExecuteNonQuery();
                                    }
                                }

                                // Ngắt kết nối đến Database Server
                                connection.Close();

                                // Sau khi Lưu thành công, chuyển trạng thái Form về VIEW
                                this.FormStatus = "View";
                            }
                            catch (Exception ex)
                            {
                                // Hiển thị thông báo nếu có lỗi
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    break;
                // Xử lý Lưu cho trường hợp Sửa dữ liệu
                case "Edit":
                    // TODO: xử lý lưu
                    break;
            }


        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Chuẩn bị dữ liệu
            quanLyBanHangDatabaseDataSet.ReportHoaDonBanHang.Rows.Clear();
            foreach (QuanLyBanHangDatabaseDataSet.order_detailsRow orderDetailRow in quanLyBanHangDatabaseDataSet.order_details.Rows)
            {
                var row = quanLyBanHangDatabaseDataSet.ReportHoaDonBanHang.NewReportHoaDonBanHangRow();

                // Nạp thông tin Chung về Công ty lấy từ Cấu hình (config)


                // Nạp thông tin về Khách hàng (customer)

                // Nạp thông tin về Đơn hàng (order)
                row.report_ordered_date_day = order_dateDateTimePicker.Value.Day.ToString();
                row.report_ordered_date_month = order_dateDateTimePicker.Value.Month.ToString();
                row.report_ordered_date_year = order_dateDateTimePicker.Value.Year.ToString();

                // Nạp thông tin về Đơn hàng Chi tiết (order_detail)
                row.report_order_detail_product_name = orderDetailRow.product_id.ToString();

                // Add dòng dữ liệu vào DataTable
                quanLyBanHangDatabaseDataSet.ReportHoaDonBanHang.AddReportHoaDonBanHangRow(row);
            }

            // Hiển thị FormReport
            FormReport frm = new FormReport();
            frm.reportViewerCommon.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.Reports.ReportHoaDonDatHang.rdlc";
            frm.ReportDataSourceName = "DataSetReportOrder";
            frm.Data = quanLyBanHangDatabaseDataSet.ReportHoaDonBanHang;
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnThoat.Text == "Hủy bỏ")
            {
                // Chuyển trạng thái Form về "View"
                this.FormStatus = "View";
            }
            else
            {
                // Đóng Form
                this.Close();
            }
        }
    }
}
