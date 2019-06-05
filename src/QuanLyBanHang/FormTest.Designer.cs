namespace QuanLyBanHang
{
    partial class FormTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("File 1", "icontexto-user-web20-blinklist.ico");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("File 2", "icontexto-user-web20-blogger.ico");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("File 3", "icontexto-user-web20-digg.ico");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("File 4", "icontexto-user-web20-technorati.ico");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("File 5", "icontexto-user-web20-reddit.ico");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("LT");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("TH");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Bai giang", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("C:\\", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("16x16");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("32x32");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Icons", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("D:\\", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("My computer", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode17});
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.chkBuoiSang = new System.Windows.Forms.CheckBox();
            this.chkBuoiChieu = new System.Windows.Forms.CheckBox();
            this.chkBuoiToi = new System.Windows.Forms.CheckBox();
            this.btnChonCheck = new System.Windows.Forms.Button();
            this.clbCauLacBo = new System.Windows.Forms.CheckedListBox();
            this.btnClbCauLacBo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStopTime = new System.Windows.Forms.Button();
            this.btnStartTime = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList16x16 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList32x32 = new System.Windows.Forms.ImageList(this.components);
            this.treeViewComputer = new System.Windows.Forms.TreeView();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTinhDiem = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pgbTinhDiemTen = new QuanLyBanHang.CustomProgressBar();
            this.lblGioPhutGiay = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbNam
            // 
            this.rdbNam.AutoCheck = false;
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(6, 19);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            this.rdbNam.CheckedChanged += new System.EventHandler(this.rdbNam_CheckedChanged);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(6, 42);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 1;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nu";
            this.rdbNu.UseVisualStyleBackColor = true;
            this.rdbNu.CheckedChanged += new System.EventHandler(this.rdbNu_CheckedChanged);
            // 
            // chkBuoiSang
            // 
            this.chkBuoiSang.AutoSize = true;
            this.chkBuoiSang.Checked = true;
            this.chkBuoiSang.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkBuoiSang.Location = new System.Drawing.Point(103, 34);
            this.chkBuoiSang.Name = "chkBuoiSang";
            this.chkBuoiSang.Size = new System.Drawing.Size(73, 17);
            this.chkBuoiSang.TabIndex = 2;
            this.chkBuoiSang.Text = "Buoi sang";
            this.chkBuoiSang.UseVisualStyleBackColor = true;
            // 
            // chkBuoiChieu
            // 
            this.chkBuoiChieu.AutoSize = true;
            this.chkBuoiChieu.Checked = true;
            this.chkBuoiChieu.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkBuoiChieu.Location = new System.Drawing.Point(103, 58);
            this.chkBuoiChieu.Name = "chkBuoiChieu";
            this.chkBuoiChieu.Size = new System.Drawing.Size(76, 17);
            this.chkBuoiChieu.TabIndex = 3;
            this.chkBuoiChieu.Text = "Buoi chieu";
            this.chkBuoiChieu.UseVisualStyleBackColor = true;
            // 
            // chkBuoiToi
            // 
            this.chkBuoiToi.AutoSize = true;
            this.chkBuoiToi.Checked = true;
            this.chkBuoiToi.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkBuoiToi.Location = new System.Drawing.Point(103, 82);
            this.chkBuoiToi.Name = "chkBuoiToi";
            this.chkBuoiToi.Size = new System.Drawing.Size(61, 17);
            this.chkBuoiToi.TabIndex = 4;
            this.chkBuoiToi.Text = "Buoi toi";
            this.chkBuoiToi.UseVisualStyleBackColor = true;
            // 
            // btnChonCheck
            // 
            this.btnChonCheck.Location = new System.Drawing.Point(101, 105);
            this.btnChonCheck.Name = "btnChonCheck";
            this.btnChonCheck.Size = new System.Drawing.Size(101, 23);
            this.btnChonCheck.TabIndex = 5;
            this.btnChonCheck.Text = "Ban da chon?";
            this.btnChonCheck.UseVisualStyleBackColor = true;
            this.btnChonCheck.Click += new System.EventHandler(this.btnChonCheck_Click);
            // 
            // clbCauLacBo
            // 
            this.clbCauLacBo.FormattingEnabled = true;
            this.clbCauLacBo.Items.AddRange(new object[] {
            "Bo dao nha",
            "Viet nam?",
            "Brazin",
            "Phap",
            "Duc",
            "Argentina"});
            this.clbCauLacBo.Location = new System.Drawing.Point(234, 13);
            this.clbCauLacBo.Name = "clbCauLacBo";
            this.clbCauLacBo.Size = new System.Drawing.Size(120, 109);
            this.clbCauLacBo.TabIndex = 6;
            // 
            // btnClbCauLacBo
            // 
            this.btnClbCauLacBo.Location = new System.Drawing.Point(223, 128);
            this.btnClbCauLacBo.Name = "btnClbCauLacBo";
            this.btnClbCauLacBo.Size = new System.Drawing.Size(131, 23);
            this.btnClbCauLacBo.TabIndex = 7;
            this.btnClbCauLacBo.Text = "Ban da chon cau lac bo";
            this.btnClbCauLacBo.UseVisualStyleBackColor = true;
            this.btnClbCauLacBo.Click += new System.EventHandler(this.btnClbCauLacBo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(83, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gioi tinh";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnStopTime);
            this.panel1.Controls.Add(this.btnStartTime);
            this.panel1.Location = new System.Drawing.Point(574, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 33);
            this.panel1.TabIndex = 9;
            // 
            // btnStopTime
            // 
            this.btnStopTime.Location = new System.Drawing.Point(84, 3);
            this.btnStopTime.Name = "btnStopTime";
            this.btnStopTime.Size = new System.Drawing.Size(75, 23);
            this.btnStopTime.TabIndex = 0;
            this.btnStopTime.Text = "Stop time";
            this.btnStopTime.UseVisualStyleBackColor = true;
            this.btnStopTime.Click += new System.EventHandler(this.btnStopTime_Click);
            // 
            // btnStartTime
            // 
            this.btnStartTime.Location = new System.Drawing.Point(3, 3);
            this.btnStartTime.Name = "btnStartTime";
            this.btnStartTime.Size = new System.Drawing.Size(75, 23);
            this.btnStartTime.TabIndex = 0;
            this.btnStartTime.Text = "Start time";
            this.btnStartTime.UseVisualStyleBackColor = true;
            this.btnStartTime.Click += new System.EventHandler(this.btnStartTime_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.logo_nentang;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // imageList16x16
            // 
            this.imageList16x16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16x16.ImageStream")));
            this.imageList16x16.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList16x16.Images.SetKeyName(0, "antenna.png");
            this.imageList16x16.Images.SetKeyName(1, "bluetooth.png");
            this.imageList16x16.Images.SetKeyName(2, "click-to-call.png");
            this.imageList16x16.Images.SetKeyName(3, "dial.png");
            this.imageList16x16.Images.SetKeyName(4, "feedback.png");
            this.imageList16x16.Images.SetKeyName(5, "guarantee.png");
            this.imageList16x16.Images.SetKeyName(6, "hang-up.png");
            this.imageList16x16.Images.SetKeyName(7, "headphones.png");
            this.imageList16x16.Images.SetKeyName(8, "help.png");
            this.imageList16x16.Images.SetKeyName(9, "keypad.png");
            this.imageList16x16.Images.SetKeyName(10, "mobile-phone.png");
            this.imageList16x16.Images.SetKeyName(11, "my-invoices.png");
            this.imageList16x16.Images.SetKeyName(12, "my-profile.png");
            this.imageList16x16.Images.SetKeyName(13, "my-reports.png");
            this.imageList16x16.Images.SetKeyName(14, "my-savings.png");
            this.imageList16x16.Images.SetKeyName(15, "receptionist.png");
            this.imageList16x16.Images.SetKeyName(16, "sms.png");
            this.imageList16x16.Images.SetKeyName(17, "sms-call.png");
            this.imageList16x16.Images.SetKeyName(18, "support-man.png");
            this.imageList16x16.Images.SetKeyName(19, "support-woman.png");
            this.imageList16x16.Images.SetKeyName(20, "telecom.png");
            this.imageList16x16.Images.SetKeyName(21, "telephone.png");
            this.imageList16x16.Images.SetKeyName(22, "telephone_receiver.png");
            this.imageList16x16.Images.SetKeyName(23, "tell-a-friend.png");
            this.imageList16x16.Images.SetKeyName(24, "usb.png");
            this.imageList16x16.Images.SetKeyName(25, "voip.png");
            this.imageList16x16.Images.SetKeyName(26, "vpn.png");
            this.imageList16x16.Images.SetKeyName(27, "wallet.png");
            this.imageList16x16.Images.SetKeyName(28, "web-call.png");
            this.imageList16x16.Images.SetKeyName(29, "wifi.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 90);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkRed;
            this.splitContainer1.Size = new System.Drawing.Size(81, 58);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(439, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(439, 39);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhap tuoi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Diem LT:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDown3.Location = new System.Drawing.Point(439, 65);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Diem TH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chon thang:";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("Thang mot");
            this.domainUpDown1.Items.Add("Thang hai");
            this.domainUpDown1.Items.Add("Thang ba");
            this.domainUpDown1.Items.Add("Thang tu");
            this.domainUpDown1.Items.Add("Thang nam");
            this.domainUpDown1.Items.Add("Thang sau");
            this.domainUpDown1.Items.Add("Thang bay");
            this.domainUpDown1.Items.Add("Thang tam");
            this.domainUpDown1.Items.Add("Thang chin");
            this.domainUpDown1.Items.Add("Thang muoi");
            this.domainUpDown1.Items.Add("Thang muoi mot");
            this.domainUpDown1.Items.Add("Thang muoi hai");
            this.domainUpDown1.Location = new System.Drawing.Point(443, 96);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 16;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView1.LargeImageList = this.imageList32x32;
            this.listView1.Location = new System.Drawing.Point(12, 155);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(220, 304);
            this.listView1.SmallImageList = this.imageList16x16;
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList32x32
            // 
            this.imageList32x32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32x32.ImageStream")));
            this.imageList32x32.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList32x32.Images.SetKeyName(0, "icontexto-user-web20-blinklist.ico");
            this.imageList32x32.Images.SetKeyName(1, "icontexto-user-web20-blogger.ico");
            this.imageList32x32.Images.SetKeyName(2, "icontexto-user-web20-delicious.ico");
            this.imageList32x32.Images.SetKeyName(3, "icontexto-user-web20-digg.ico");
            this.imageList32x32.Images.SetKeyName(4, "icontexto-user-web20-facebook.ico");
            this.imageList32x32.Images.SetKeyName(5, "icontexto-user-web20-favorites.ico");
            this.imageList32x32.Images.SetKeyName(6, "icontexto-user-web20-feedburner.ico");
            this.imageList32x32.Images.SetKeyName(7, "icontexto-user-web20-flickr.ico");
            this.imageList32x32.Images.SetKeyName(8, "icontexto-user-web20-furl.ico");
            this.imageList32x32.Images.SetKeyName(9, "icontexto-user-web20-google.ico");
            this.imageList32x32.Images.SetKeyName(10, "icontexto-user-web20-icontexto.ico");
            this.imageList32x32.Images.SetKeyName(11, "icontexto-user-web20-linkedin.ico");
            this.imageList32x32.Images.SetKeyName(12, "icontexto-user-web20-magnolia.ico");
            this.imageList32x32.Images.SetKeyName(13, "icontexto-user-web20-mogulus.ico");
            this.imageList32x32.Images.SetKeyName(14, "icontexto-user-web20-myspace.ico");
            this.imageList32x32.Images.SetKeyName(15, "icontexto-user-web20-netvibes.ico");
            this.imageList32x32.Images.SetKeyName(16, "icontexto-user-web20-newsvine.ico");
            this.imageList32x32.Images.SetKeyName(17, "icontexto-user-web20-orkut.ico");
            this.imageList32x32.Images.SetKeyName(18, "icontexto-user-web20-picasa.ico");
            this.imageList32x32.Images.SetKeyName(19, "icontexto-user-web20-reddit.ico");
            this.imageList32x32.Images.SetKeyName(20, "icontexto-user-web20-rss.ico");
            this.imageList32x32.Images.SetKeyName(21, "icontexto-user-web20-stumbleupon.ico");
            this.imageList32x32.Images.SetKeyName(22, "icontexto-user-web20-technorati.ico");
            this.imageList32x32.Images.SetKeyName(23, "icontexto-user-web20-twitter.ico");
            this.imageList32x32.Images.SetKeyName(24, "icontexto-user-web20-whosamungus.ico");
            this.imageList32x32.Images.SetKeyName(25, "icontexto-user-web20-wordpress.ico");
            this.imageList32x32.Images.SetKeyName(26, "icontexto-user-web20-yahoo.ico");
            this.imageList32x32.Images.SetKeyName(27, "icontexto-user-web20-youtube.ico");
            // 
            // treeViewComputer
            // 
            this.treeViewComputer.ImageIndex = 8;
            this.treeViewComputer.ImageList = this.imageList16x16;
            this.treeViewComputer.Location = new System.Drawing.Point(238, 157);
            this.treeViewComputer.Name = "treeViewComputer";
            treeNode10.ImageIndex = 14;
            treeNode10.Name = "Node13";
            treeNode10.Text = "LT";
            treeNode11.ImageIndex = 24;
            treeNode11.Name = "Node14";
            treeNode11.Text = "TH";
            treeNode12.ImageIndex = 10;
            treeNode12.Name = "Node12";
            treeNode12.Text = "Bai giang";
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "Node10";
            treeNode13.Text = "C:\\";
            treeNode14.Name = "Node16";
            treeNode14.Text = "16x16";
            treeNode15.Name = "Node17";
            treeNode15.Text = "32x32";
            treeNode16.Name = "Node15";
            treeNode16.Text = "Icons";
            treeNode17.ImageIndex = 23;
            treeNode17.Name = "Node11";
            treeNode17.Text = "D:\\";
            treeNode18.Name = "Node9";
            treeNode18.Text = "My computer";
            this.treeViewComputer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.treeViewComputer.SelectedImageIndex = 0;
            this.treeViewComputer.Size = new System.Drawing.Size(148, 302);
            this.treeViewComputer.TabIndex = 18;
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(360, 128);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(93, 23);
            this.btnChooseFolder.TabIndex = 19;
            this.btnChooseFolder.Text = "Chon thu muc";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(391, 157);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(169, 302);
            this.rtbComment.TabIndex = 20;
            this.rtbComment.Text = "Hello everybody!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // btnTinhDiem
            // 
            this.btnTinhDiem.Location = new System.Drawing.Point(562, 41);
            this.btnTinhDiem.Name = "btnTinhDiem";
            this.btnTinhDiem.Size = new System.Drawing.Size(171, 23);
            this.btnTinhDiem.TabIndex = 23;
            this.btnTinhDiem.Text = "Tinh diem con";
            this.btnTinhDiem.UseVisualStyleBackColor = true;
            this.btnTinhDiem.Click += new System.EventHandler(this.btnTinhDiem_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(625, 70);
            this.dtpNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(196, 20);
            this.dtpNgaySinh.TabIndex = 24;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ngay sinh:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2018, 6, 11, 0, 0, 0, 0)};
            this.monthCalendar1.BackColor = System.Drawing.Color.Green;
            this.monthCalendar1.BoldedDates = new System.DateTime[] {
        new System.DateTime(2018, 6, 15, 18, 23, 10, 0),
        new System.DateTime(2018, 6, 25, 0, 0, 0, 0)};
            this.monthCalendar1.Location = new System.Drawing.Point(565, 96);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 26;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Maroon;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.Yellow;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Lime;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Den gio da banh con:";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.Red;
            this.lblThoiGian.Location = new System.Drawing.Point(718, 267);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(74, 39);
            this.lblThoiGian.TabIndex = 28;
            this.lblThoiGian.Text = "... s";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pgbTinhDiemTen
            // 
            this.pgbTinhDiemTen.CustomText = null;
            this.pgbTinhDiemTen.DisplayStyle = QuanLyBanHang.ProgressBarDisplayText.Percentage;
            this.pgbTinhDiemTen.Location = new System.Drawing.Point(562, 10);
            this.pgbTinhDiemTen.Name = "pgbTinhDiemTen";
            this.pgbTinhDiemTen.Size = new System.Drawing.Size(259, 23);
            this.pgbTinhDiemTen.TabIndex = 22;
            // 
            // lblGioPhutGiay
            // 
            this.lblGioPhutGiay.AutoSize = true;
            this.lblGioPhutGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioPhutGiay.Location = new System.Drawing.Point(645, 336);
            this.lblGioPhutGiay.Name = "lblGioPhutGiay";
            this.lblGioPhutGiay.Size = new System.Drawing.Size(88, 24);
            this.lblGioPhutGiay.TabIndex = 29;
            this.lblGioPhutGiay.Text = "18:51:25";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyBanHang.Properties.Resources.logo_nentang;
            this.pictureBox2.Location = new System.Drawing.Point(827, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 471);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblGioPhutGiay);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.btnTinhDiem);
            this.Controls.Add(this.pgbTinhDiemTen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.treeViewComputer);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClbCauLacBo);
            this.Controls.Add(this.clbCauLacBo);
            this.Controls.Add(this.btnChonCheck);
            this.Controls.Add(this.chkBuoiToi);
            this.Controls.Add(this.chkBuoiChieu);
            this.Controls.Add(this.chkBuoiSang);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.CheckBox chkBuoiSang;
        private System.Windows.Forms.CheckBox chkBuoiChieu;
        private System.Windows.Forms.CheckBox chkBuoiToi;
        private System.Windows.Forms.Button btnChonCheck;
        private System.Windows.Forms.CheckedListBox clbCauLacBo;
        private System.Windows.Forms.Button btnClbCauLacBo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStopTime;
        private System.Windows.Forms.Button btnStartTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList16x16;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList32x32;
        private System.Windows.Forms.TreeView treeViewComputer;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.TextBox textBox1;
        private CustomProgressBar pgbTinhDiemTen;
        private System.Windows.Forms.Button btnTinhDiem;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblGioPhutGiay;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}