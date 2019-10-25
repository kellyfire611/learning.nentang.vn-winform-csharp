namespace QuanLyBanHang.Functions
{
    partial class FormDatHang
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
            System.Windows.Forms.Label employee_idLabel;
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label order_dateLabel;
            System.Windows.Forms.Label shipped_dateLabel;
            System.Windows.Forms.Label ship_nameLabel;
            System.Windows.Forms.Label ship_address1Label;
            System.Windows.Forms.Label ship_address2Label;
            System.Windows.Forms.Label ship_cityLabel;
            System.Windows.Forms.Label ship_stateLabel;
            System.Windows.Forms.Label ship_postal_codeLabel;
            System.Windows.Forms.Label ship_countryLabel;
            System.Windows.Forms.Label shipping_feeLabel;
            System.Windows.Forms.Label payment_typeLabel;
            System.Windows.Forms.Label paid_dateLabel;
            System.Windows.Forms.Label order_statusLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.grpThongTinDonHang = new System.Windows.Forms.GroupBox();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.cbbEmployee = new System.Windows.Forms.ComboBox();
            this.nudShipping_fee = new System.Windows.Forms.NumericUpDown();
            this.order_statusTextBox = new System.Windows.Forms.TextBox();
            this.paid_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payment_typeTextBox = new System.Windows.Forms.TextBox();
            this.ship_countryTextBox = new System.Windows.Forms.TextBox();
            this.ship_postal_codeTextBox = new System.Windows.Forms.TextBox();
            this.ship_stateTextBox = new System.Windows.Forms.TextBox();
            this.ship_cityTextBox = new System.Windows.Forms.TextBox();
            this.ship_address2TextBox = new System.Windows.Forms.TextBox();
            this.ship_address1TextBox = new System.Windows.Forms.TextBox();
            this.ship_nameTextBox = new System.Windows.Forms.TextBox();
            this.shipped_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grpThongTinChiTietDonHang = new System.Windows.Forms.GroupBox();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.dgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdetailstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateallocatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDatabaseDataSet = new QuanLyBanHang.QuanLyBanHangDatabaseDataSet();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.grpDanhSachDonHang = new System.Windows.Forms.GroupBox();
            this.btnLayDanhSachDonHang = new System.Windows.Forms.Button();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippeddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipaddress1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipaddress2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippostalcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingfeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paiddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            employee_idLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            order_dateLabel = new System.Windows.Forms.Label();
            shipped_dateLabel = new System.Windows.Forms.Label();
            ship_nameLabel = new System.Windows.Forms.Label();
            ship_address1Label = new System.Windows.Forms.Label();
            ship_address2Label = new System.Windows.Forms.Label();
            ship_cityLabel = new System.Windows.Forms.Label();
            ship_stateLabel = new System.Windows.Forms.Label();
            ship_postal_codeLabel = new System.Windows.Forms.Label();
            ship_countryLabel = new System.Windows.Forms.Label();
            shipping_feeLabel = new System.Windows.Forms.Label();
            payment_typeLabel = new System.Windows.Forms.Label();
            paid_dateLabel = new System.Windows.Forms.Label();
            order_statusLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.grpThongTinDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShipping_fee)).BeginInit();
            this.grpThongTinChiTietDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDatabaseDataSet)).BeginInit();
            this.grpDanhSachDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Location = new System.Drawing.Point(6, 16);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new System.Drawing.Size(66, 13);
            employee_idLabel.TabIndex = 0;
            employee_idLabel.Text = "employee id:";
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(8, 41);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(64, 13);
            customer_idLabel.TabIndex = 2;
            customer_idLabel.Text = "customer id:";
            // 
            // order_dateLabel
            // 
            order_dateLabel.AutoSize = true;
            order_dateLabel.Location = new System.Drawing.Point(14, 70);
            order_dateLabel.Name = "order_dateLabel";
            order_dateLabel.Size = new System.Drawing.Size(58, 13);
            order_dateLabel.TabIndex = 4;
            order_dateLabel.Text = "order date:";
            // 
            // shipped_dateLabel
            // 
            shipped_dateLabel.AutoSize = true;
            shipped_dateLabel.Location = new System.Drawing.Point(8, 98);
            shipped_dateLabel.Name = "shipped_dateLabel";
            shipped_dateLabel.Size = new System.Drawing.Size(71, 13);
            shipped_dateLabel.TabIndex = 6;
            shipped_dateLabel.Text = "shipped date:";
            // 
            // ship_nameLabel
            // 
            ship_nameLabel.AutoSize = true;
            ship_nameLabel.Location = new System.Drawing.Point(21, 124);
            ship_nameLabel.Name = "ship_nameLabel";
            ship_nameLabel.Size = new System.Drawing.Size(58, 13);
            ship_nameLabel.TabIndex = 8;
            ship_nameLabel.Text = "ship name:";
            // 
            // ship_address1Label
            // 
            ship_address1Label.AutoSize = true;
            ship_address1Label.Location = new System.Drawing.Point(6, 151);
            ship_address1Label.Name = "ship_address1Label";
            ship_address1Label.Size = new System.Drawing.Size(75, 13);
            ship_address1Label.TabIndex = 10;
            ship_address1Label.Text = "ship address1:";
            // 
            // ship_address2Label
            // 
            ship_address2Label.AutoSize = true;
            ship_address2Label.Location = new System.Drawing.Point(302, 18);
            ship_address2Label.Name = "ship_address2Label";
            ship_address2Label.Size = new System.Drawing.Size(75, 13);
            ship_address2Label.TabIndex = 12;
            ship_address2Label.Text = "ship address2:";
            // 
            // ship_cityLabel
            // 
            ship_cityLabel.AutoSize = true;
            ship_cityLabel.Location = new System.Drawing.Point(329, 41);
            ship_cityLabel.Name = "ship_cityLabel";
            ship_cityLabel.Size = new System.Drawing.Size(48, 13);
            ship_cityLabel.TabIndex = 14;
            ship_cityLabel.Text = "ship city:";
            // 
            // ship_stateLabel
            // 
            ship_stateLabel.AutoSize = true;
            ship_stateLabel.Location = new System.Drawing.Point(322, 67);
            ship_stateLabel.Name = "ship_stateLabel";
            ship_stateLabel.Size = new System.Drawing.Size(55, 13);
            ship_stateLabel.TabIndex = 16;
            ship_stateLabel.Text = "ship state:";
            // 
            // ship_postal_codeLabel
            // 
            ship_postal_codeLabel.AutoSize = true;
            ship_postal_codeLabel.Location = new System.Drawing.Point(291, 94);
            ship_postal_codeLabel.Name = "ship_postal_codeLabel";
            ship_postal_codeLabel.Size = new System.Drawing.Size(87, 13);
            ship_postal_codeLabel.TabIndex = 18;
            ship_postal_codeLabel.Text = "ship postal code:";
            // 
            // ship_countryLabel
            // 
            ship_countryLabel.AutoSize = true;
            ship_countryLabel.Location = new System.Drawing.Point(311, 121);
            ship_countryLabel.Name = "ship_countryLabel";
            ship_countryLabel.Size = new System.Drawing.Size(67, 13);
            ship_countryLabel.TabIndex = 20;
            ship_countryLabel.Text = "ship country:";
            // 
            // shipping_feeLabel
            // 
            shipping_feeLabel.AutoSize = true;
            shipping_feeLabel.Location = new System.Drawing.Point(311, 148);
            shipping_feeLabel.Name = "shipping_feeLabel";
            shipping_feeLabel.Size = new System.Drawing.Size(67, 13);
            shipping_feeLabel.TabIndex = 22;
            shipping_feeLabel.Text = "shipping fee:";
            // 
            // payment_typeLabel
            // 
            payment_typeLabel.AutoSize = true;
            payment_typeLabel.Location = new System.Drawing.Point(498, 18);
            payment_typeLabel.Name = "payment_typeLabel";
            payment_typeLabel.Size = new System.Drawing.Size(73, 13);
            payment_typeLabel.TabIndex = 24;
            payment_typeLabel.Text = "payment type:";
            // 
            // paid_dateLabel
            // 
            paid_dateLabel.AutoSize = true;
            paid_dateLabel.Location = new System.Drawing.Point(508, 45);
            paid_dateLabel.Name = "paid_dateLabel";
            paid_dateLabel.Size = new System.Drawing.Size(54, 13);
            paid_dateLabel.TabIndex = 26;
            paid_dateLabel.Text = "paid date:";
            // 
            // order_statusLabel
            // 
            order_statusLabel.AutoSize = true;
            order_statusLabel.Location = new System.Drawing.Point(508, 70);
            order_statusLabel.Name = "order_statusLabel";
            order_statusLabel.Size = new System.Drawing.Size(65, 13);
            order_statusLabel.TabIndex = 28;
            order_statusLabel.Text = "order status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 10;
            label1.Text = "product id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(179, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 13);
            label2.TabIndex = 10;
            label2.Text = "quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(349, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 13);
            label3.TabIndex = 10;
            label3.Text = "unit_price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(517, 22);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 13);
            label4.TabIndex = 10;
            label4.Text = "discount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 19);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 13);
            label5.TabIndex = 4;
            label5.Text = "from date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 42);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(43, 13);
            label6.TabIndex = 4;
            label6.Text = "to date:";
            // 
            // grpThongTinDonHang
            // 
            this.grpThongTinDonHang.Controls.Add(this.cbbCustomer);
            this.grpThongTinDonHang.Controls.Add(this.cbbEmployee);
            this.grpThongTinDonHang.Controls.Add(this.nudShipping_fee);
            this.grpThongTinDonHang.Controls.Add(order_statusLabel);
            this.grpThongTinDonHang.Controls.Add(this.order_statusTextBox);
            this.grpThongTinDonHang.Controls.Add(paid_dateLabel);
            this.grpThongTinDonHang.Controls.Add(this.paid_dateDateTimePicker);
            this.grpThongTinDonHang.Controls.Add(payment_typeLabel);
            this.grpThongTinDonHang.Controls.Add(this.payment_typeTextBox);
            this.grpThongTinDonHang.Controls.Add(shipping_feeLabel);
            this.grpThongTinDonHang.Controls.Add(ship_countryLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_countryTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_postal_codeLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_postal_codeTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_stateLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_stateTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_cityLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_cityTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_address2Label);
            this.grpThongTinDonHang.Controls.Add(this.ship_address2TextBox);
            this.grpThongTinDonHang.Controls.Add(ship_address1Label);
            this.grpThongTinDonHang.Controls.Add(this.ship_address1TextBox);
            this.grpThongTinDonHang.Controls.Add(ship_nameLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_nameTextBox);
            this.grpThongTinDonHang.Controls.Add(shipped_dateLabel);
            this.grpThongTinDonHang.Controls.Add(this.shipped_dateDateTimePicker);
            this.grpThongTinDonHang.Controls.Add(order_dateLabel);
            this.grpThongTinDonHang.Controls.Add(this.order_dateDateTimePicker);
            this.grpThongTinDonHang.Controls.Add(customer_idLabel);
            this.grpThongTinDonHang.Controls.Add(employee_idLabel);
            this.grpThongTinDonHang.Location = new System.Drawing.Point(317, 12);
            this.grpThongTinDonHang.Name = "grpThongTinDonHang";
            this.grpThongTinDonHang.Size = new System.Drawing.Size(808, 178);
            this.grpThongTinDonHang.TabIndex = 0;
            this.grpThongTinDonHang.TabStop = false;
            this.grpThongTinDonHang.Text = "Thông tin Đơn hàng";
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(85, 41);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(120, 21);
            this.cbbCustomer.TabIndex = 30;
            // 
            // cbbEmployee
            // 
            this.cbbEmployee.FormattingEnabled = true;
            this.cbbEmployee.Location = new System.Drawing.Point(85, 15);
            this.cbbEmployee.Name = "cbbEmployee";
            this.cbbEmployee.Size = new System.Drawing.Size(120, 21);
            this.cbbEmployee.TabIndex = 30;
            // 
            // nudShipping_fee
            // 
            this.nudShipping_fee.Location = new System.Drawing.Point(384, 146);
            this.nudShipping_fee.Name = "nudShipping_fee";
            this.nudShipping_fee.Size = new System.Drawing.Size(99, 20);
            this.nudShipping_fee.TabIndex = 31;
            // 
            // order_statusTextBox
            // 
            this.order_statusTextBox.Location = new System.Drawing.Point(579, 67);
            this.order_statusTextBox.Name = "order_statusTextBox";
            this.order_statusTextBox.Size = new System.Drawing.Size(189, 20);
            this.order_statusTextBox.TabIndex = 29;
            // 
            // paid_dateDateTimePicker
            // 
            this.paid_dateDateTimePicker.Location = new System.Drawing.Point(579, 41);
            this.paid_dateDateTimePicker.Name = "paid_dateDateTimePicker";
            this.paid_dateDateTimePicker.Size = new System.Drawing.Size(189, 20);
            this.paid_dateDateTimePicker.TabIndex = 27;
            // 
            // payment_typeTextBox
            // 
            this.payment_typeTextBox.Location = new System.Drawing.Point(577, 15);
            this.payment_typeTextBox.Name = "payment_typeTextBox";
            this.payment_typeTextBox.Size = new System.Drawing.Size(191, 20);
            this.payment_typeTextBox.TabIndex = 25;
            // 
            // ship_countryTextBox
            // 
            this.ship_countryTextBox.Location = new System.Drawing.Point(384, 118);
            this.ship_countryTextBox.Name = "ship_countryTextBox";
            this.ship_countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_countryTextBox.TabIndex = 21;
            // 
            // ship_postal_codeTextBox
            // 
            this.ship_postal_codeTextBox.Location = new System.Drawing.Point(384, 91);
            this.ship_postal_codeTextBox.Name = "ship_postal_codeTextBox";
            this.ship_postal_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_postal_codeTextBox.TabIndex = 19;
            // 
            // ship_stateTextBox
            // 
            this.ship_stateTextBox.Location = new System.Drawing.Point(383, 64);
            this.ship_stateTextBox.Name = "ship_stateTextBox";
            this.ship_stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_stateTextBox.TabIndex = 17;
            // 
            // ship_cityTextBox
            // 
            this.ship_cityTextBox.Location = new System.Drawing.Point(383, 38);
            this.ship_cityTextBox.Name = "ship_cityTextBox";
            this.ship_cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_cityTextBox.TabIndex = 15;
            // 
            // ship_address2TextBox
            // 
            this.ship_address2TextBox.Location = new System.Drawing.Point(383, 15);
            this.ship_address2TextBox.Name = "ship_address2TextBox";
            this.ship_address2TextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_address2TextBox.TabIndex = 13;
            // 
            // ship_address1TextBox
            // 
            this.ship_address1TextBox.Location = new System.Drawing.Point(87, 148);
            this.ship_address1TextBox.Name = "ship_address1TextBox";
            this.ship_address1TextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_address1TextBox.TabIndex = 11;
            // 
            // ship_nameTextBox
            // 
            this.ship_nameTextBox.Location = new System.Drawing.Point(85, 121);
            this.ship_nameTextBox.Name = "ship_nameTextBox";
            this.ship_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_nameTextBox.TabIndex = 9;
            // 
            // shipped_dateDateTimePicker
            // 
            this.shipped_dateDateTimePicker.Location = new System.Drawing.Point(85, 94);
            this.shipped_dateDateTimePicker.Name = "shipped_dateDateTimePicker";
            this.shipped_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shipped_dateDateTimePicker.TabIndex = 7;
            // 
            // order_dateDateTimePicker
            // 
            this.order_dateDateTimePicker.Location = new System.Drawing.Point(85, 67);
            this.order_dateDateTimePicker.Name = "order_dateDateTimePicker";
            this.order_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.order_dateDateTimePicker.TabIndex = 5;
            // 
            // grpThongTinChiTietDonHang
            // 
            this.grpThongTinChiTietDonHang.Controls.Add(this.nudGiamGia);
            this.grpThongTinChiTietDonHang.Controls.Add(this.nudDonGia);
            this.grpThongTinChiTietDonHang.Controls.Add(this.nudSoLuong);
            this.grpThongTinChiTietDonHang.Controls.Add(this.cbbProduct);
            this.grpThongTinChiTietDonHang.Controls.Add(this.dgvChiTietDonHang);
            this.grpThongTinChiTietDonHang.Controls.Add(this.btnThemChiTiet);
            this.grpThongTinChiTietDonHang.Controls.Add(label4);
            this.grpThongTinChiTietDonHang.Controls.Add(label3);
            this.grpThongTinChiTietDonHang.Controls.Add(label2);
            this.grpThongTinChiTietDonHang.Controls.Add(label1);
            this.grpThongTinChiTietDonHang.Location = new System.Drawing.Point(317, 196);
            this.grpThongTinChiTietDonHang.Name = "grpThongTinChiTietDonHang";
            this.grpThongTinChiTietDonHang.Size = new System.Drawing.Size(808, 219);
            this.grpThongTinChiTietDonHang.TabIndex = 1;
            this.grpThongTinChiTietDonHang.TabStop = false;
            this.grpThongTinChiTietDonHang.Text = "Thông tin chi tiết Đơn hàng";
            // 
            // nudGiamGia
            // 
            this.nudGiamGia.Location = new System.Drawing.Point(573, 19);
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.Size = new System.Drawing.Size(100, 20);
            this.nudGiamGia.TabIndex = 31;
            // 
            // nudDonGia
            // 
            this.nudDonGia.Location = new System.Drawing.Point(411, 19);
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.Size = new System.Drawing.Size(100, 20);
            this.nudDonGia.TabIndex = 31;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(232, 19);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(111, 20);
            this.nudSoLuong.TabIndex = 31;
            // 
            // cbbProduct
            // 
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(65, 19);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(108, 21);
            this.cbbProduct.TabIndex = 30;
            // 
            // dgvChiTietDonHang
            // 
            this.dgvChiTietDonHang.AutoGenerateColumns = false;
            this.dgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.orderdetailstatusDataGridViewTextBoxColumn,
            this.dateallocatedDataGridViewTextBoxColumn});
            this.dgvChiTietDonHang.DataSource = this.orderdetailsBindingSource;
            this.dgvChiTietDonHang.Location = new System.Drawing.Point(6, 45);
            this.dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            this.dgvChiTietDonHang.Size = new System.Drawing.Size(796, 168);
            this.dgvChiTietDonHang.TabIndex = 0;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "unit_price";
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // orderdetailstatusDataGridViewTextBoxColumn
            // 
            this.orderdetailstatusDataGridViewTextBoxColumn.DataPropertyName = "order_detail_status";
            this.orderdetailstatusDataGridViewTextBoxColumn.HeaderText = "order_detail_status";
            this.orderdetailstatusDataGridViewTextBoxColumn.Name = "orderdetailstatusDataGridViewTextBoxColumn";
            // 
            // dateallocatedDataGridViewTextBoxColumn
            // 
            this.dateallocatedDataGridViewTextBoxColumn.DataPropertyName = "date_allocated";
            this.dateallocatedDataGridViewTextBoxColumn.HeaderText = "date_allocated";
            this.dateallocatedDataGridViewTextBoxColumn.Name = "dateallocatedDataGridViewTextBoxColumn";
            // 
            // orderdetailsBindingSource
            // 
            this.orderdetailsBindingSource.DataMember = "order_details";
            this.orderdetailsBindingSource.DataSource = this.quanLyBanHangDatabaseDataSet;
            // 
            // quanLyBanHangDatabaseDataSet
            // 
            this.quanLyBanHangDatabaseDataSet.DataSetName = "QuanLyBanHangDatabaseDataSet";
            this.quanLyBanHangDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Location = new System.Drawing.Point(679, 19);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(107, 23);
            this.btnThemChiTiet.TabIndex = 7;
            this.btnThemChiTiet.Text = "Thêm chi tiết";
            this.btnThemChiTiet.UseVisualStyleBackColor = true;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // grpDanhSachDonHang
            // 
            this.grpDanhSachDonHang.Controls.Add(this.btnLayDanhSachDonHang);
            this.grpDanhSachDonHang.Controls.Add(this.dgvDonHang);
            this.grpDanhSachDonHang.Controls.Add(this.dtpDenNgay);
            this.grpDanhSachDonHang.Controls.Add(label6);
            this.grpDanhSachDonHang.Controls.Add(this.dtpTuNgay);
            this.grpDanhSachDonHang.Controls.Add(label5);
            this.grpDanhSachDonHang.Location = new System.Drawing.Point(12, 12);
            this.grpDanhSachDonHang.Name = "grpDanhSachDonHang";
            this.grpDanhSachDonHang.Size = new System.Drawing.Size(299, 403);
            this.grpDanhSachDonHang.TabIndex = 2;
            this.grpDanhSachDonHang.TabStop = false;
            this.grpDanhSachDonHang.Text = "Danh sách đơn hàng";
            // 
            // btnLayDanhSachDonHang
            // 
            this.btnLayDanhSachDonHang.Location = new System.Drawing.Point(6, 62);
            this.btnLayDanhSachDonHang.Name = "btnLayDanhSachDonHang";
            this.btnLayDanhSachDonHang.Size = new System.Drawing.Size(287, 23);
            this.btnLayDanhSachDonHang.TabIndex = 7;
            this.btnLayDanhSachDonHang.Text = "Lấy danh sách đơn hàng";
            this.btnLayDanhSachDonHang.UseVisualStyleBackColor = true;
            this.btnLayDanhSachDonHang.Click += new System.EventHandler(this.btnLayDanhSachDonHang_Click);
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AutoGenerateColumns = false;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.shippeddateDataGridViewTextBoxColumn,
            this.shipnameDataGridViewTextBoxColumn,
            this.shipaddress1DataGridViewTextBoxColumn,
            this.shipaddress2DataGridViewTextBoxColumn,
            this.shipcityDataGridViewTextBoxColumn,
            this.shipstateDataGridViewTextBoxColumn,
            this.shippostalcodeDataGridViewTextBoxColumn,
            this.shipcountryDataGridViewTextBoxColumn,
            this.shippingfeeDataGridViewTextBoxColumn,
            this.paymenttypeDataGridViewTextBoxColumn,
            this.paiddateDataGridViewTextBoxColumn,
            this.orderstatusDataGridViewTextBoxColumn});
            this.dgvDonHang.DataSource = this.ordersBindingSource;
            this.dgvDonHang.Location = new System.Drawing.Point(5, 91);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.Size = new System.Drawing.Size(287, 306);
            this.dgvDonHang.TabIndex = 0;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "order_date";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            // 
            // shippeddateDataGridViewTextBoxColumn
            // 
            this.shippeddateDataGridViewTextBoxColumn.DataPropertyName = "shipped_date";
            this.shippeddateDataGridViewTextBoxColumn.HeaderText = "shipped_date";
            this.shippeddateDataGridViewTextBoxColumn.Name = "shippeddateDataGridViewTextBoxColumn";
            // 
            // shipnameDataGridViewTextBoxColumn
            // 
            this.shipnameDataGridViewTextBoxColumn.DataPropertyName = "ship_name";
            this.shipnameDataGridViewTextBoxColumn.HeaderText = "ship_name";
            this.shipnameDataGridViewTextBoxColumn.Name = "shipnameDataGridViewTextBoxColumn";
            this.shipnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // shipaddress1DataGridViewTextBoxColumn
            // 
            this.shipaddress1DataGridViewTextBoxColumn.DataPropertyName = "ship_address1";
            this.shipaddress1DataGridViewTextBoxColumn.HeaderText = "ship_address1";
            this.shipaddress1DataGridViewTextBoxColumn.Name = "shipaddress1DataGridViewTextBoxColumn";
            this.shipaddress1DataGridViewTextBoxColumn.Visible = false;
            // 
            // shipaddress2DataGridViewTextBoxColumn
            // 
            this.shipaddress2DataGridViewTextBoxColumn.DataPropertyName = "ship_address2";
            this.shipaddress2DataGridViewTextBoxColumn.HeaderText = "ship_address2";
            this.shipaddress2DataGridViewTextBoxColumn.Name = "shipaddress2DataGridViewTextBoxColumn";
            this.shipaddress2DataGridViewTextBoxColumn.Visible = false;
            // 
            // shipcityDataGridViewTextBoxColumn
            // 
            this.shipcityDataGridViewTextBoxColumn.DataPropertyName = "ship_city";
            this.shipcityDataGridViewTextBoxColumn.HeaderText = "ship_city";
            this.shipcityDataGridViewTextBoxColumn.Name = "shipcityDataGridViewTextBoxColumn";
            this.shipcityDataGridViewTextBoxColumn.Visible = false;
            // 
            // shipstateDataGridViewTextBoxColumn
            // 
            this.shipstateDataGridViewTextBoxColumn.DataPropertyName = "ship_state";
            this.shipstateDataGridViewTextBoxColumn.HeaderText = "ship_state";
            this.shipstateDataGridViewTextBoxColumn.Name = "shipstateDataGridViewTextBoxColumn";
            this.shipstateDataGridViewTextBoxColumn.Visible = false;
            // 
            // shippostalcodeDataGridViewTextBoxColumn
            // 
            this.shippostalcodeDataGridViewTextBoxColumn.DataPropertyName = "ship_postal_code";
            this.shippostalcodeDataGridViewTextBoxColumn.HeaderText = "ship_postal_code";
            this.shippostalcodeDataGridViewTextBoxColumn.Name = "shippostalcodeDataGridViewTextBoxColumn";
            this.shippostalcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // shipcountryDataGridViewTextBoxColumn
            // 
            this.shipcountryDataGridViewTextBoxColumn.DataPropertyName = "ship_country";
            this.shipcountryDataGridViewTextBoxColumn.HeaderText = "ship_country";
            this.shipcountryDataGridViewTextBoxColumn.Name = "shipcountryDataGridViewTextBoxColumn";
            this.shipcountryDataGridViewTextBoxColumn.Visible = false;
            // 
            // shippingfeeDataGridViewTextBoxColumn
            // 
            this.shippingfeeDataGridViewTextBoxColumn.DataPropertyName = "shipping_fee";
            this.shippingfeeDataGridViewTextBoxColumn.HeaderText = "shipping_fee";
            this.shippingfeeDataGridViewTextBoxColumn.Name = "shippingfeeDataGridViewTextBoxColumn";
            this.shippingfeeDataGridViewTextBoxColumn.Visible = false;
            // 
            // paymenttypeDataGridViewTextBoxColumn
            // 
            this.paymenttypeDataGridViewTextBoxColumn.DataPropertyName = "payment_type";
            this.paymenttypeDataGridViewTextBoxColumn.HeaderText = "payment_type";
            this.paymenttypeDataGridViewTextBoxColumn.Name = "paymenttypeDataGridViewTextBoxColumn";
            this.paymenttypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // paiddateDataGridViewTextBoxColumn
            // 
            this.paiddateDataGridViewTextBoxColumn.DataPropertyName = "paid_date";
            this.paiddateDataGridViewTextBoxColumn.HeaderText = "paid_date";
            this.paiddateDataGridViewTextBoxColumn.Name = "paiddateDataGridViewTextBoxColumn";
            this.paiddateDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderstatusDataGridViewTextBoxColumn
            // 
            this.orderstatusDataGridViewTextBoxColumn.DataPropertyName = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.HeaderText = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.Name = "orderstatusDataGridViewTextBoxColumn";
            this.orderstatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.quanLyBanHangDatabaseDataSet;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(78, 39);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(215, 20);
            this.dtpDenNgay.TabIndex = 5;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(78, 16);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(215, 20);
            this.dtpTuNgay.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(728, 421);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(813, 421);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(894, 421);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(975, 421);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1056, 421);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(642, 421);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(79, 23);
            this.btnInHoaDon.TabIndex = 7;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // FormDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 452);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpDanhSachDonHang);
            this.Controls.Add(this.grpThongTinChiTietDonHang);
            this.Controls.Add(this.grpThongTinDonHang);
            this.Name = "FormDatHang";
            this.Text = "Form đặt hàng";
            this.Load += new System.EventHandler(this.FormDatHang_Load);
            this.grpThongTinDonHang.ResumeLayout(false);
            this.grpThongTinDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShipping_fee)).EndInit();
            this.grpThongTinChiTietDonHang.ResumeLayout(false);
            this.grpThongTinChiTietDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDatabaseDataSet)).EndInit();
            this.grpDanhSachDonHang.ResumeLayout(false);
            this.grpDanhSachDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTinDonHang;
        private System.Windows.Forms.TextBox order_statusTextBox;
        private System.Windows.Forms.DateTimePicker paid_dateDateTimePicker;
        private System.Windows.Forms.TextBox payment_typeTextBox;
        private System.Windows.Forms.TextBox ship_countryTextBox;
        private System.Windows.Forms.TextBox ship_postal_codeTextBox;
        private System.Windows.Forms.TextBox ship_stateTextBox;
        private System.Windows.Forms.TextBox ship_cityTextBox;
        private System.Windows.Forms.TextBox ship_address2TextBox;
        private System.Windows.Forms.TextBox ship_address1TextBox;
        private System.Windows.Forms.TextBox ship_nameTextBox;
        private System.Windows.Forms.DateTimePicker shipped_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker order_dateDateTimePicker;
        private System.Windows.Forms.GroupBox grpThongTinChiTietDonHang;
        private System.Windows.Forms.GroupBox grpDanhSachDonHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTietDonHang;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Button btnLayDanhSachDonHang;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private QuanLyBanHangDatabaseDataSet quanLyBanHangDatabaseDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippeddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipaddress1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipaddress2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipcityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippostalcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingfeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paiddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbbEmployee;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.BindingSource orderdetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdetailstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateallocatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbbProduct;
        private System.Windows.Forms.NumericUpDown nudGiamGia;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.NumericUpDown nudShipping_fee;
        private System.Windows.Forms.Button btnInHoaDon;
    }
}