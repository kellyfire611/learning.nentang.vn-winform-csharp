using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_1
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện click nút "Đăng nhập"
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Validate thông tin "Tên đăng nhập"
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTenDangNhap.Text.Length < 3)
            {
                MessageBox.Show("Tên đăng nhập cần có ít nhất 3 ký tự trở lên.\nVui lòng kiểm tra lại!", 
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate thông tin "Mật khẩu"
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác minh thông tin Tài khoản
            if (txtTenDangNhap.Text == "admin" && txtMatKhau.Text == "123456")
            {
                MessageBox.Show("Đăng nhập Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng nhập Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện click nút "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Thoát chương trình
        }
    }
}
