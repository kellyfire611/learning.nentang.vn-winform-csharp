using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_ComboBox_ListBox
{
    public partial class FrmGopY : Form
    {
        List<HocPhan> lstHocPhan;

        public FrmGopY()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện Load Form
        private void FrmGopY_Load(object sender, EventArgs e)
        {
            
        }

        // Xử lý sự kiện nút Gởi góp ý
        private void btnGoiGopY_Click(object sender, EventArgs e)
        {
            // 1. Thu thập thông tin Người dùng nhập
            string chudeGopY = Convert.ToString(cbbGopY.SelectedItem);
            string hoten = txtHoTen.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            string noidung = txtNoiDung.Text;

            // 2. Kiểm tra ràng buộc dữ liệu (Validation)
            string loi = "";

            // 2.1. Kiểm tra combobox Chủ đề góp ý
            if(String.IsNullOrEmpty(chudeGopY)) // Rule 1: Required (bắt buộc nhập)
            {
                loi += "Chủ đề góp ý bắt buộc nhập. Vui lòng chọn chủ đề góp ý.\n";
            }

            // 2.2. Kiểm tra Họ tên
            if (String.IsNullOrEmpty(hoten)) // Rule 1: Required (bắt buộc nhập)
            {
                loi += "Họ tên bắt buộc nhập.\n";
            }
            else if(hoten.Length < 3) // Rule 2: Min (nhập ít nhất 3 ký tự)
            {
                loi += "Vui lòng nhập họ tên từ 3 ký tự trở lên.\n";
            }
            else if(hoten.Length > 50) // Rule 3: Max (nhập tối đa 50 ký tự)
            {
                loi += "Vui lòng nhập họ tên không vượt quá 50 ký tự.\n";
            }

            // 2.3. Kiểm tra Số điện thoại
            if (String.IsNullOrEmpty(hoten)) // Rule 1: Required (bắt buộc nhập)
            {
                loi += "Số điện thoại bắt buộc nhập.\n";
            }

            // 2.4. Kiểm tra Email
            if (String.IsNullOrEmpty(email)) // Rule 1: Required (bắt buộc nhập)
            {
                loi += "Email bắt buộc nhập.\n";
            }

            // 2.5. Kiểm tra Nội dung
            if (String.IsNullOrEmpty(noidung)) // Rule 1: Required (bắt buộc nhập)
            {
                loi += "Nội dung bắt buộc nhập.\n";
            }

            // Kết quả
            if(!String.IsNullOrEmpty(loi)) // Người dùng có vi phạm quy luật bất kỳ nào đó...
            {
                MessageBox.Show(loi);
                return;
            }
            else // Dữ liệu hợp lệ
            {
                string data = "Góp ý của bạn:";
                data += "\nChủ đề góp ý: " + chudeGopY;
                data += "\nHọ tên: " + hoten;
                data += "\nSố điện thoại: " + sdt;
                data += "\nEmail: " + email;
                data += "\nNội dung: " + noidung;
                MessageBox.Show(data);

                lblThongBao.Text = "Góp ý của bạn đã được Hệ thống ghi nhận. Xin chân thành cám ơn bạn đã đóng góp.";
            }
        }
    }
}
