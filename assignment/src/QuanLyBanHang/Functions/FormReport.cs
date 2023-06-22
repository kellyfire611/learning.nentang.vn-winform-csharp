using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang.Functions
{
    public partial class FormReport : Form
    {
        /// <summary>
        /// Chuỗi kết nối
        /// Lấy từ cấu hình (settings) của Project
        /// </summary>
        string connectionString = QuanLyBanHang.Properties.Settings.Default.QuanLyBanHangDatabaseConnectionString;

        public string ReportDataSourceName { get; set; }
        public object Data { get; set; }

        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource(this.ReportDataSourceName, this.Data);
            this.reportViewerCommon.LocalReport.DataSources.Clear();
            this.reportViewerCommon.LocalReport.DataSources.Add(rds);
            this.reportViewerCommon.LocalReport.Refresh();
            this.reportViewerCommon.RefreshReport();
        }
    }
}
