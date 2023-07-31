namespace Lab2_CheckBox_Radio
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
            this.chkVietCode = new System.Windows.Forms.CheckBox();
            this.chkXemPhim = new System.Windows.Forms.CheckBox();
            this.chkNgheNhac = new System.Windows.Forms.CheckBox();
            this.chkDocSach = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdThemeNenRock = new System.Windows.Forms.RadioButton();
            this.rdThemeNenToi = new System.Windows.Forms.RadioButton();
            this.rdThemeNenSang = new System.Windows.Forms.RadioButton();
            this.btnSoThichCuaBan = new System.Windows.Forms.Button();
            this.btnThemeBanLuaChon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkVietCode);
            this.groupBox1.Controls.Add(this.chkXemPhim);
            this.groupBox1.Controls.Add(this.chkNgheNhac);
            this.groupBox1.Controls.Add(this.chkDocSach);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sở thích của bạn";
            // 
            // chkVietCode
            // 
            this.chkVietCode.AutoSize = true;
            this.chkVietCode.Location = new System.Drawing.Point(7, 89);
            this.chkVietCode.Name = "chkVietCode";
            this.chkVietCode.Size = new System.Drawing.Size(71, 17);
            this.chkVietCode.TabIndex = 0;
            this.chkVietCode.Text = "Viết code";
            this.chkVietCode.UseVisualStyleBackColor = true;
            // 
            // chkXemPhim
            // 
            this.chkXemPhim.AutoSize = true;
            this.chkXemPhim.Location = new System.Drawing.Point(7, 66);
            this.chkXemPhim.Name = "chkXemPhim";
            this.chkXemPhim.Size = new System.Drawing.Size(72, 17);
            this.chkXemPhim.TabIndex = 0;
            this.chkXemPhim.Text = "Xem phim";
            this.chkXemPhim.UseVisualStyleBackColor = true;
            // 
            // chkNgheNhac
            // 
            this.chkNgheNhac.AutoSize = true;
            this.chkNgheNhac.Location = new System.Drawing.Point(7, 43);
            this.chkNgheNhac.Name = "chkNgheNhac";
            this.chkNgheNhac.Size = new System.Drawing.Size(79, 17);
            this.chkNgheNhac.TabIndex = 0;
            this.chkNgheNhac.Text = "Nghe nhạc";
            this.chkNgheNhac.UseVisualStyleBackColor = true;
            // 
            // chkDocSach
            // 
            this.chkDocSach.AutoSize = true;
            this.chkDocSach.Location = new System.Drawing.Point(7, 20);
            this.chkDocSach.Name = "chkDocSach";
            this.chkDocSach.Size = new System.Drawing.Size(72, 17);
            this.chkDocSach.TabIndex = 0;
            this.chkDocSach.Text = "Đọc sách";
            this.chkDocSach.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdThemeNenRock);
            this.groupBox2.Controls.Add(this.rdThemeNenToi);
            this.groupBox2.Controls.Add(this.rdThemeNenSang);
            this.groupBox2.Location = new System.Drawing.Point(229, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 115);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn theme giao diện";
            // 
            // rdThemeNenRock
            // 
            this.rdThemeNenRock.AutoSize = true;
            this.rdThemeNenRock.Location = new System.Drawing.Point(7, 66);
            this.rdThemeNenRock.Name = "rdThemeNenRock";
            this.rdThemeNenRock.Size = new System.Drawing.Size(103, 17);
            this.rdThemeNenRock.TabIndex = 0;
            this.rdThemeNenRock.TabStop = true;
            this.rdThemeNenRock.Text = "Theme nền rock";
            this.rdThemeNenRock.UseVisualStyleBackColor = true;
            this.rdThemeNenRock.CheckedChanged += new System.EventHandler(this.rdTheme_CheckedChanged);
            // 
            // rdThemeNenToi
            // 
            this.rdThemeNenToi.AutoSize = true;
            this.rdThemeNenToi.Location = new System.Drawing.Point(7, 43);
            this.rdThemeNenToi.Name = "rdThemeNenToi";
            this.rdThemeNenToi.Size = new System.Drawing.Size(93, 17);
            this.rdThemeNenToi.TabIndex = 0;
            this.rdThemeNenToi.TabStop = true;
            this.rdThemeNenToi.Text = "Theme nền tối";
            this.rdThemeNenToi.UseVisualStyleBackColor = true;
            this.rdThemeNenToi.CheckedChanged += new System.EventHandler(this.rdTheme_CheckedChanged);
            // 
            // rdThemeNenSang
            // 
            this.rdThemeNenSang.AutoSize = true;
            this.rdThemeNenSang.Location = new System.Drawing.Point(7, 20);
            this.rdThemeNenSang.Name = "rdThemeNenSang";
            this.rdThemeNenSang.Size = new System.Drawing.Size(105, 17);
            this.rdThemeNenSang.TabIndex = 0;
            this.rdThemeNenSang.TabStop = true;
            this.rdThemeNenSang.Text = "Theme nền sáng";
            this.rdThemeNenSang.UseVisualStyleBackColor = true;
            this.rdThemeNenSang.CheckedChanged += new System.EventHandler(this.rdTheme_CheckedChanged);
            // 
            // btnSoThichCuaBan
            // 
            this.btnSoThichCuaBan.Location = new System.Drawing.Point(12, 134);
            this.btnSoThichCuaBan.Name = "btnSoThichCuaBan";
            this.btnSoThichCuaBan.Size = new System.Drawing.Size(211, 43);
            this.btnSoThichCuaBan.TabIndex = 1;
            this.btnSoThichCuaBan.Text = "Sở thích của bạn";
            this.btnSoThichCuaBan.UseVisualStyleBackColor = true;
            this.btnSoThichCuaBan.Click += new System.EventHandler(this.btnSoThichCuaBan_Click);
            // 
            // btnThemeBanLuaChon
            // 
            this.btnThemeBanLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemeBanLuaChon.Location = new System.Drawing.Point(229, 133);
            this.btnThemeBanLuaChon.Name = "btnThemeBanLuaChon";
            this.btnThemeBanLuaChon.Size = new System.Drawing.Size(211, 44);
            this.btnThemeBanLuaChon.TabIndex = 1;
            this.btnThemeBanLuaChon.Text = "Theme bạn lựa chọn";
            this.btnThemeBanLuaChon.UseVisualStyleBackColor = true;
            this.btnThemeBanLuaChon.Click += new System.EventHandler(this.btnThemeBanLuaChon_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 188);
            this.Controls.Add(this.btnThemeBanLuaChon);
            this.Controls.Add(this.btnSoThichCuaBan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 - CheckBox Radio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkVietCode;
        private System.Windows.Forms.CheckBox chkXemPhim;
        private System.Windows.Forms.CheckBox chkNgheNhac;
        private System.Windows.Forms.CheckBox chkDocSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdThemeNenRock;
        private System.Windows.Forms.RadioButton rdThemeNenToi;
        private System.Windows.Forms.RadioButton rdThemeNenSang;
        private System.Windows.Forms.Button btnSoThichCuaBan;
        private System.Windows.Forms.Button btnThemeBanLuaChon;
    }
}

