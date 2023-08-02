namespace Lab4_Tooltip_HelpProvider_ErrorProvider
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listboxDanhSachHocPhan = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertOne = new System.Windows.Forms.Button();
            this.btnInsertAll = new System.Windows.Forms.Button();
            this.btnRemoveOne = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listboxDanhSachHocPhanDaDangKy = new System.Windows.Forms.ListBox();
            this.btnTinhTongHocPhi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongTienHocPhi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listboxDanhSachHocPhan);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học phần";
            // 
            // listboxDanhSachHocPhan
            // 
            this.listboxDanhSachHocPhan.FormattingEnabled = true;
            this.listboxDanhSachHocPhan.Location = new System.Drawing.Point(7, 20);
            this.listboxDanhSachHocPhan.MultiColumn = true;
            this.listboxDanhSachHocPhan.Name = "listboxDanhSachHocPhan";
            this.listboxDanhSachHocPhan.Size = new System.Drawing.Size(198, 225);
            this.listboxDanhSachHocPhan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng ký Học phần";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInsertOne
            // 
            this.btnInsertOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertOne.Location = new System.Drawing.Point(229, 74);
            this.btnInsertOne.Name = "btnInsertOne";
            this.btnInsertOne.Size = new System.Drawing.Size(42, 38);
            this.btnInsertOne.TabIndex = 2;
            this.btnInsertOne.Text = ">";
            this.btnInsertOne.UseVisualStyleBackColor = true;
            // 
            // btnInsertAll
            // 
            this.btnInsertAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertAll.Location = new System.Drawing.Point(229, 118);
            this.btnInsertAll.Name = "btnInsertAll";
            this.btnInsertAll.Size = new System.Drawing.Size(42, 38);
            this.btnInsertAll.TabIndex = 2;
            this.btnInsertAll.Text = ">>";
            this.btnInsertAll.UseVisualStyleBackColor = true;
            this.btnInsertAll.Click += new System.EventHandler(this.btnInsertAll_Click);
            // 
            // btnRemoveOne
            // 
            this.btnRemoveOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOne.Location = new System.Drawing.Point(229, 162);
            this.btnRemoveOne.Name = "btnRemoveOne";
            this.btnRemoveOne.Size = new System.Drawing.Size(42, 38);
            this.btnRemoveOne.TabIndex = 2;
            this.btnRemoveOne.Text = "<";
            this.btnRemoveOne.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.Location = new System.Drawing.Point(229, 206);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(42, 38);
            this.btnRemoveAll.TabIndex = 2;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listboxDanhSachHocPhanDaDangKy);
            this.groupBox2.Location = new System.Drawing.Point(277, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 253);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học phần ĐÃ ĐĂNG KÝ";
            // 
            // listboxDanhSachHocPhanDaDangKy
            // 
            this.listboxDanhSachHocPhanDaDangKy.FormattingEnabled = true;
            this.listboxDanhSachHocPhanDaDangKy.Location = new System.Drawing.Point(7, 20);
            this.listboxDanhSachHocPhanDaDangKy.Name = "listboxDanhSachHocPhanDaDangKy";
            this.listboxDanhSachHocPhanDaDangKy.Size = new System.Drawing.Size(198, 225);
            this.listboxDanhSachHocPhanDaDangKy.TabIndex = 0;
            // 
            // btnTinhTongHocPhi
            // 
            this.btnTinhTongHocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTongHocPhi.Location = new System.Drawing.Point(12, 307);
            this.btnTinhTongHocPhi.Name = "btnTinhTongHocPhi";
            this.btnTinhTongHocPhi.Size = new System.Drawing.Size(211, 38);
            this.btnTinhTongHocPhi.TabIndex = 3;
            this.btnTinhTongHocPhi.Text = "Tính tổng học phí";
            this.btnTinhTongHocPhi.UseVisualStyleBackColor = true;
            this.btnTinhTongHocPhi.Click += new System.EventHandler(this.btnTinhTongHocPhi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng số tiền cần đóng (1 chỉ / 150.000đ):";
            // 
            // lblTongTienHocPhi
            // 
            this.lblTongTienHocPhi.AutoSize = true;
            this.lblTongTienHocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienHocPhi.ForeColor = System.Drawing.Color.Red;
            this.lblTongTienHocPhi.Location = new System.Drawing.Point(276, 325);
            this.lblTongTienHocPhi.Name = "lblTongTienHocPhi";
            this.lblTongTienHocPhi.Size = new System.Drawing.Size(21, 20);
            this.lblTongTienHocPhi.TabIndex = 4;
            this.lblTongTienHocPhi.Text = "...";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 358);
            this.Controls.Add(this.lblTongTienHocPhi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTinhTongHocPhi);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveOne);
            this.Controls.Add(this.btnInsertAll);
            this.Controls.Add(this.btnInsertOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 3 - ComboBox ListBox";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listboxDanhSachHocPhan;
        private System.Windows.Forms.Button btnInsertOne;
        private System.Windows.Forms.Button btnInsertAll;
        private System.Windows.Forms.Button btnRemoveOne;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listboxDanhSachHocPhanDaDangKy;
        private System.Windows.Forms.Button btnTinhTongHocPhi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongTienHocPhi;
    }
}

