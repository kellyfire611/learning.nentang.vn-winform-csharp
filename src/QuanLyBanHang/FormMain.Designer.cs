namespace QuanLyBanHang
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnusMain = new System.Windows.Forms.MenuStrip();
            this.ttmiHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiCauHinh = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiMuaBan = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiDatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiSanPhamBanChayNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiSanPhamHetHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnusMain
            // 
            this.mnusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiHeThong,
            this.ttmiDanhMuc,
            this.ttmiMuaBan,
            this.ttmiBaoCao});
            this.mnusMain.Location = new System.Drawing.Point(0, 0);
            this.mnusMain.Name = "mnusMain";
            this.mnusMain.Size = new System.Drawing.Size(784, 24);
            this.mnusMain.TabIndex = 0;
            this.mnusMain.Text = "mnusMain";
            // 
            // ttmiHeThong
            // 
            this.ttmiHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiCauHinh,
            this.ttmiThoat});
            this.ttmiHeThong.Name = "ttmiHeThong";
            this.ttmiHeThong.Size = new System.Drawing.Size(69, 20);
            this.ttmiHeThong.Text = "Hệ thống";
            // 
            // ttmiCauHinh
            // 
            this.ttmiCauHinh.Name = "ttmiCauHinh";
            this.ttmiCauHinh.Size = new System.Drawing.Size(122, 22);
            this.ttmiCauHinh.Text = "Cấu hình";
            this.ttmiCauHinh.Click += new System.EventHandler(this.ttmiCauHinh_Click);
            // 
            // ttmiThoat
            // 
            this.ttmiThoat.Name = "ttmiThoat";
            this.ttmiThoat.Size = new System.Drawing.Size(122, 22);
            this.ttmiThoat.Text = "Thoát";
            this.ttmiThoat.Click += new System.EventHandler(this.ttmiThoat_Click);
            // 
            // ttmiDanhMuc
            // 
            this.ttmiDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiKhachHang,
            this.ttmiNhanVien,
            this.ttmiSanPham});
            this.ttmiDanhMuc.Name = "ttmiDanhMuc";
            this.ttmiDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.ttmiDanhMuc.Text = "Danh mục";
            // 
            // ttmiKhachHang
            // 
            this.ttmiKhachHang.Name = "ttmiKhachHang";
            this.ttmiKhachHang.Size = new System.Drawing.Size(137, 22);
            this.ttmiKhachHang.Text = "Khách hàng";
            this.ttmiKhachHang.Click += new System.EventHandler(this.ttmiKhachHang_Click);
            // 
            // ttmiNhanVien
            // 
            this.ttmiNhanVien.Name = "ttmiNhanVien";
            this.ttmiNhanVien.Size = new System.Drawing.Size(137, 22);
            this.ttmiNhanVien.Text = "Nhân viên";
            this.ttmiNhanVien.Click += new System.EventHandler(this.ttmiNhanVien_Click);
            // 
            // ttmiSanPham
            // 
            this.ttmiSanPham.Name = "ttmiSanPham";
            this.ttmiSanPham.Size = new System.Drawing.Size(137, 22);
            this.ttmiSanPham.Text = "Sản phẩm";
            this.ttmiSanPham.Click += new System.EventHandler(this.ttmiSanPham_Click);
            // 
            // ttmiMuaBan
            // 
            this.ttmiMuaBan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiDatHang});
            this.ttmiMuaBan.Name = "ttmiMuaBan";
            this.ttmiMuaBan.Size = new System.Drawing.Size(66, 20);
            this.ttmiMuaBan.Text = "Mua bán";
            // 
            // ttmiDatHang
            // 
            this.ttmiDatHang.Name = "ttmiDatHang";
            this.ttmiDatHang.Size = new System.Drawing.Size(122, 22);
            this.ttmiDatHang.Text = "Đặt hàng";
            this.ttmiDatHang.Click += new System.EventHandler(this.ttmiDatHang_Click);
            // 
            // ttmiBaoCao
            // 
            this.ttmiBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiDoanhThu,
            this.ttmiSanPhamBanChayNhat,
            this.ttmiSanPhamHetHang});
            this.ttmiBaoCao.Name = "ttmiBaoCao";
            this.ttmiBaoCao.Size = new System.Drawing.Size(61, 20);
            this.ttmiBaoCao.Text = "Báo cáo";
            // 
            // ttmiDoanhThu
            // 
            this.ttmiDoanhThu.Name = "ttmiDoanhThu";
            this.ttmiDoanhThu.Size = new System.Drawing.Size(205, 22);
            this.ttmiDoanhThu.Text = "Doanh thu";
            this.ttmiDoanhThu.Click += new System.EventHandler(this.ttmiDoanhThu_Click);
            // 
            // ttmiSanPhamBanChayNhat
            // 
            this.ttmiSanPhamBanChayNhat.Name = "ttmiSanPhamBanChayNhat";
            this.ttmiSanPhamBanChayNhat.Size = new System.Drawing.Size(205, 22);
            this.ttmiSanPhamBanChayNhat.Text = "Sản phẩm bán chạy nhất";
            // 
            // ttmiSanPhamHetHang
            // 
            this.ttmiSanPhamHetHang.Name = "ttmiSanPhamHetHang";
            this.ttmiSanPhamHetHang.Size = new System.Drawing.Size(205, 22);
            this.ttmiSanPhamHetHang.Text = "Sản phẩm hết hàng";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mnusMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnusMain;
            this.Name = "FormMain";
            this.Text = "Quản lý Bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.mnusMain.ResumeLayout(false);
            this.mnusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnusMain;
        private System.Windows.Forms.ToolStripMenuItem ttmiHeThong;
        private System.Windows.Forms.ToolStripMenuItem ttmiCauHinh;
        private System.Windows.Forms.ToolStripMenuItem ttmiThoat;
        private System.Windows.Forms.ToolStripMenuItem ttmiDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem ttmiKhachHang;
        private System.Windows.Forms.ToolStripMenuItem ttmiNhanVien;
        private System.Windows.Forms.ToolStripMenuItem ttmiSanPham;
        private System.Windows.Forms.ToolStripMenuItem ttmiMuaBan;
        private System.Windows.Forms.ToolStripMenuItem ttmiDatHang;
        private System.Windows.Forms.ToolStripMenuItem ttmiBaoCao;
        private System.Windows.Forms.ToolStripMenuItem ttmiDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem ttmiSanPhamBanChayNhat;
        private System.Windows.Forms.ToolStripMenuItem ttmiSanPhamHetHang;

    }
}