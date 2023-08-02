using Lab2_2.Forms;
using Lab2_2.Forms.DanhMuc;
using Lab2_2.Forms.HeThong;
using Lab2_2.Forms.MuaBan;
using Lab2_2.Forms.BaoCao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void cauHinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCauHinh frm = new FrmCauHinh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachHang frm = new FrmKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSanPham frm = new FrmSanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void datHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatHang frm = new FrmDatHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoDoanhThu frm = new FrmBaoCaoDoanhThu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sanPhamBanChayNhatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoSanPhamBanChayNhat frm = new FrmBaoCaoSanPhamBanChayNhat();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sanPhamHetHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoSanPhamHetHang frm = new FrmBaoCaoSanPhamHetHang();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
