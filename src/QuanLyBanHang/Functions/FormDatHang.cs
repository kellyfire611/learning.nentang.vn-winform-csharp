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
            string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM orders WHERE order_date BETWEEN '{0}' AND '{1}'", tuNgay,  denNgay);

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
                        orderdetailsBindingSource.DataSource = null;
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
            // Nếu đang chọn dòng dữ liệu (RowIndex > 0)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng dữ liệu đang chọn
                DataGridViewRow row = this.dgvDonHang.Rows[e.RowIndex];

                // Binding vào các textbox tương ứng
                var idEmployee = Convert.ToInt32(row.Cells["employeeidDataGridViewTextBoxColumn"].Value);
                cbbEmployee.SelectedItem = cbbEmployee.Items.Cast<KeyValuePair<int, string>>().First(item => item.Key == idEmployee);

                var idCustomer = Convert.ToInt32(row.Cells["customeridDataGridViewTextBoxColumn"].Value);
                cbbCustomer.SelectedItem = cbbCustomer.Items.Cast<KeyValuePair<int, string>>().First(item => item.Key == idCustomer);

                order_dateDateTimePicker.Text = row.Cells["orderdateDataGridViewTextBoxColumn"].Value.ToString();

                // Load chi tiết đơn hàng bởi ID đơn hàng
                var idDonHang = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                LoadChiTietDonHang(idDonHang);
            }
        }

        private void FormDatHang_Load(object sender, EventArgs e)
        {
            // Load danh mục
            LoadDanhSachNhanVien();
            LoadDanhSachKhachHang();
            LoadDanhSachSanPham();
        }

        // Clear dữ liệu
        public void ClearData()
        {
            cbbEmployee.Text = "";
            cbbCustomer.Text = "";
            order_dateDateTimePicker.Value = DateTime.Now;

            // clear dữ liệu chi tiết đơn hàng
            cbbProduct.Text = "";
            quanLyBanHangDatabaseDataSet.order_details.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Clear dữ liệu
            ClearData();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            // Chuẩn bị dữ liệu thêm dòng mới
            int orderId = 0;
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

                        // Load lại danh sách cấu hình
                        //LoadDanhMucCauHinh();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            FormReport frm = new FormReport();
            foreach (DataRow row in quanLyBanHangDatabaseDataSet.order_details.Rows)
            {
                row["report_tenkhachhang"] = cbbCustomer.Text;
                row["report_tennhanvien"] = cbbEmployee.Text;
            }

            frm.Data = quanLyBanHangDatabaseDataSet;
            frm.ShowDialog();
        }
    }
}
