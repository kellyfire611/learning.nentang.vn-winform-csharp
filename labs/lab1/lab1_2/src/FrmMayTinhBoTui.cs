using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2
{
    public partial class FrmMayTinhBoTui : Form
    {
        public FrmMayTinhBoTui()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra ràng buộc dữ liệu
        private bool ValidateDuLieu()
        {
            // Validate số A
            if (txtSoA.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá trị số A!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate số B
            if (txtSoB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá trị số B!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnPhepCong_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu
            bool isValid = ValidateDuLieu();
            if (!isValid)
            {
                return;
            }

            // Thu thập dữ liệu người dùng
            decimal numA = Convert.ToDecimal(txtSoA.Text);
            decimal numB = Convert.ToDecimal(txtSoB.Text);

            // Tính toán kết quả
            decimal tong = numA + numB;

            // Hiển thị kết quả
            lblKetQua.Text = String.Format("Tổng của {0} + {1} = {2}", numA, numB, tong);
        }

        private void btnPhepTru_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu
            bool isValid = ValidateDuLieu();
            if (!isValid)
            {
                return;
            }

            // Thu thập dữ liệu người dùng
            decimal numA = Convert.ToDecimal(txtSoA.Text);
            decimal numB = Convert.ToDecimal(txtSoB.Text);

            // Tính toán kết quả
            decimal hieu = numA - numB;

            // Hiển thị kết quả
            lblKetQua.Text = String.Format("Hiệu của {0} - {1} = {2}", numA, numB, hieu);
        }

        private void btnPhepNhan_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu
            bool isValid = ValidateDuLieu();
            if (!isValid)
            {
                return;
            }

            // Thu thập dữ liệu người dùng
            decimal numA = Convert.ToDecimal(txtSoA.Text);
            decimal numB = Convert.ToDecimal(txtSoB.Text);

            // Tính toán kết quả
            decimal tich = numA * numB;

            // Hiển thị kết quả
            lblKetQua.Text = String.Format("Phép nhân của {0} * {1} = {2}", numA, numB, tich);
        }

        private void btnPhepChia_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu
            bool isValid = ValidateDuLieu();
            if (!isValid)
            {
                return;
            }

            // Thu thập dữ liệu người dùng
            decimal numA = Convert.ToDecimal(txtSoA.Text);
            decimal numB = Convert.ToDecimal(txtSoB.Text);

            // Ràng buộc thêm, không được chia cho số 0
            if (numB == 0)
            {
                MessageBox.Show("Không có phép chia cho 0. Vui lòng nhập giá trị khác cho số B!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính toán kết quả
            decimal thuong = numA / numB;

            // Hiển thị kết quả
            lblKetQua.Text = String.Format("Phép chia của {0} / {1} = {2}", numA, numB, thuong);
        }

        private void btnClearKetQua_Click(object sender, EventArgs e)
        {
            // Clear dữ liệu
            txtSoA.Text = String.Empty;
            txtSoB.Text = String.Empty;
            lblKetQua.Text = String.Empty;

            // Focus vào ô txtA
            txtSoA.Focus();
        }
    }
}
