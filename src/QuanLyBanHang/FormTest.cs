using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();

            rtbComment.Select(0, 5);
            rtbComment.SelectionFont = new Font("Verdana", 15, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbNam.Checked == true)
            {
                MessageBox.Show("Ban dang chon gioi tinh Nam!");
            }
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbNu.Checked == true)
            {
                MessageBox.Show("Ban dang chon gioi tinh Nu!");
            }
        }

        private void btnChonCheck_Click(object sender, EventArgs e)
        {
            int buoiSang = 1;
            int buoiChieu = 2;
            int buoiToi = 3;
            int giaTri = 0;

            if(chkBuoiSang.Checked == true)
            {
                giaTri += buoiSang;
            }

            if(chkBuoiChieu.Checked == true)
            {
                giaTri += buoiChieu;
            }

            if (chkBuoiToi.Checked == true)
            {
                giaTri += buoiToi;
            }

            // 000
            // 100
            // 110
            // 111
            // 010
            // 011

            switch(giaTri)
            {
                case 6: // 1 + 2 + 3
                    MessageBox.Show("Ban da chon dang ky 3 buoi");
                    break;
                case 3: // 1 + 2
                    MessageBox.Show("Ban da chon dang ky buoi sang + chieu");
                    break;
                case 4: // 1 + 3
                    MessageBox.Show("Ban da chon dang ky sang + toi");
                    break;
                case 5: // 2 + 3
                    MessageBox.Show("Ban da chon dang ky chieu + toi");
                    break;
                default:
                    break;
            }
        }

        private void btnClbCauLacBo_Click(object sender, EventArgs e)
        {
            if(clbCauLacBo.GetItemChecked(0) == true)
            {
                MessageBox.Show("Ban da chon Bo dao nha Vo dich!!!");
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Ban da chon nut: {0}", treeViewComputer.SelectedNode.Text));
        }

        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
            
            if (pgbTinhDiemTen.Value < pgbTinhDiemTen.Maximum)
            {
                pgbTinhDiemTen.PerformStep();
            }
            else
            {
                MessageBox.Show("Da dat ten con xong!!!");
            }
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.MaxDate = DateTime.Now;
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dtpNgaySinh.Value.ToString("dd/MM/yyyy"));
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionEnd.ToString("dd/MM/yyyy"));
        }

        int gio;
        int phut;
        int giay;
        private void timer1_Tick(object sender, EventArgs e)
        {
            giay++;
            if(giay >= 60)
            {
                phut++;
                giay = 0;
            }

            if(phut >= 60)
            {
                gio++;
            }

            // 9
            lblGioPhutGiay.Text = String.Format("{0}:{1}:{2}", gio, phut, giay.ToString().PadLeft(2, '0'));
        }

        private void btnStartTime_Click(object sender, EventArgs e)
        {
            timer1.Start();
            gio = DateTime.Now.Hour;
            phut = DateTime.Now.Minute;
            giay = DateTime.Now.Second;
            lblGioPhutGiay.Text = String.Format("{0}:{1}:{2}", gio, phut, giay);
        }

        private void btnStopTime_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }

    public enum ProgressBarDisplayText
    {
        Percentage,
        CustomText
    }

    class CustomProgressBar : ProgressBar
    {
        //Property to set to decide whether to print a % or Text
        public ProgressBarDisplayText DisplayStyle { get; set; }

        //Property to hold the custom text
        public String CustomText { get; set; }

        public CustomProgressBar()
        {
            // Modify the ControlStyles flags
            //http://msdn.microsoft.com/en-us/library/system.windows.forms.controlstyles.aspx
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = ClientRectangle;
            Graphics g = e.Graphics;

            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            rect.Inflate(-3, -3);
            if (Value > 0)
            {
                // As we doing this ourselves we need to draw the chunks on the progress bar
                Rectangle clip = new Rectangle(rect.X, rect.Y, (int)Math.Round(((float)Value / Maximum) * rect.Width), rect.Height);
                ProgressBarRenderer.DrawHorizontalChunks(g, clip);
            }

            // Set the Display text (Either a % amount or our custom text
            string text = DisplayStyle == ProgressBarDisplayText.Percentage ? Value.ToString() + '%' : CustomText;


            using (Font f = new Font(FontFamily.GenericSerif, 10))
            {

                SizeF len = g.MeasureString(text, f);
                // Calculate the location of the text (the middle of progress bar)
                // Point location = new Point(Convert.ToInt32((rect.Width / 2) - (len.Width / 2)), Convert.ToInt32((rect.Height / 2) - (len.Height / 2)));
                Point location = new Point(Convert.ToInt32((Width / 2) - len.Width / 2), Convert.ToInt32((Height / 2) - len.Height / 2));
                // The commented-out code will centre the text into the highlighted area only. This will centre the text regardless of the highlighted area.
                // Draw the custom text
                g.DrawString(text, f, Brushes.Red, location);
            }
        }
    }
}
