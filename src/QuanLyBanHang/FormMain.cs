using QuanLyBanHang.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ttmiThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ttmiKhachHang_Click(object sender, EventArgs e)
        {
            FormDanhMucKhachHang frmDanhMucKhachHang = new FormDanhMucKhachHang();
            frmDanhMucKhachHang.MdiParent = this;
            frmDanhMucKhachHang.Show();
        }

        private void ttmiNhanVien_Click(object sender, EventArgs e)
        {
            FormDanhMucNhanVien frmDanhMucNhanVien = new FormDanhMucNhanVien();
            frmDanhMucNhanVien.MdiParent = this;
            frmDanhMucNhanVien.Show();
        }

        private void ttmiSanPham_Click(object sender, EventArgs e)
        {
            FormDanhMucSanPham frmDanhMucSanPham = new FormDanhMucSanPham();
            frmDanhMucSanPham.MdiParent = this;
            frmDanhMucSanPham.Show();
        }

        private void ttmiCauHinh_Click(object sender, EventArgs e)
        {
            FormConfig frmConfig = new FormConfig();
            frmConfig.MdiParent = this;
            frmConfig.Show();
        }

        private void ttmiDatHang_Click(object sender, EventArgs e)
        {
            FormDatHang frm = new FormDatHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ttmiDoanhThu_Click(object sender, EventArgs e)
        {
            FormBaoCaoDoanhThu frm = new FormBaoCaoDoanhThu();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
