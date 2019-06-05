using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang.Functions
{
    public partial class FormBaoCaoDoanhThu : Form
    {
        string connectionString = @"Server=172.18.200.190\MSSQLSERVER2016,49166;Database=QuanLyBanHangDatabase;User Id=sa;Password=sa@123;";

        public FormBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm dùng để load bao cao doanh thu
        /// </summary>
        public void LoadBaoCaoDoanhThu()
        {
            string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format(
                    "select emp.first_name as EmployeeFirstName"
                    + "	, cus.first_name as CustomerFirstName"
                    + "	, prod.product_name"
                    + "	, ord_dt.quantity"
                    + "	, ord_dt.unit_price"
                    + "	, ord_dt.discount"
                    + " , (ord_dt.unit_price - (ord_dt.discount / 100 * ord_dt.unit_price)) * ord_dt.quantity as Amount"
                    + " from orders ord"
                    + "	join order_details ord_dt on ord_dt.order_id = ord.id"
                    + "	join employees emp on ord.employee_id = emp.id"
                    + "	join customers cus on ord.customer_id = cus.id"
                    + "	join products prod on ord_dt.product_id = prod.id"
                    + " where ord.order_date between '{0}' and '{1}'"    
                , tuNgay, denNgay);

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
                        adapter.Fill(quanLyBanHangDatabaseDataSet.BaoCaoDoanhThu);

                        // Hiển thị dữ liệu
                        baoCaoDoanhThuBindingSource.DataSource = null;
                        baoCaoDoanhThuBindingSource.DataSource = quanLyBanHangDatabaseDataSet.BaoCaoDoanhThu;
                        dgvBaoCao.Refresh();

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

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            LoadBaoCaoDoanhThu();
        }
    }
}
