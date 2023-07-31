using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_CheckBox_Radio
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện click show Sở thích của bạn
        private void btnSoThichCuaBan_Click(object sender, EventArgs e)
        {
            string sothich = "";
            if (chkDocSach.Checked == true)
            {
                sothich += "Bạn có sở thích đọc sách.\n";
            }

            if (chkNgheNhac.Checked == true)
            {
                sothich += "Bạn có sở thích nghe nhạc.\n";
            }

            if (chkXemPhim.Checked == true)
            {
                sothich += "Bạn có sở thích xem phim.\n";
            }

            if (chkVietCode.Checked == true)
            {
                sothich += "Bạn có sở thích viết code.\n";
            }

            if (String.IsNullOrEmpty(sothich))
            {
                MessageBox.Show("Bạn không có sở thích nào?!");
            }
            else
            {
                MessageBox.Show(sothich);
            }
        }

        private void btnThemeBanLuaChon_Click(object sender, EventArgs e)
        {
            string theme = "";
            if(rdThemeNenSang.Checked == true)
            {
                theme = "Bạn đang chọn theme nền sáng!";
            }
            else if(rdThemeNenToi.Checked == true)
            {
                theme = "Bạn đang chọn theme nền tối!";
            }
            else if (rdThemeNenRock.Checked == true)
            {
                theme = "Bạn đang chọn theme nền rock!";
            }

            if (String.IsNullOrEmpty(theme))
            {
                MessageBox.Show("Bạn chưa chọn Theme.");
            }
            else
            {
                MessageBox.Show(theme);
            }
        }

        private void rdTheme_CheckedChanged(object sender, EventArgs e)
        {
            if(rdThemeNenSang.Checked)
            {
                btnThemeBanLuaChon.ForeColor = Color.Blue;
                btnThemeBanLuaChon.BackColor = Color.White;
                btnThemeBanLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else if(rdThemeNenToi.Checked)
            {
                btnThemeBanLuaChon.BackColor = Color.Black;
                btnThemeBanLuaChon.ForeColor = Color.White;
                btnThemeBanLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else if(rdThemeNenRock.Checked)
            {
                btnThemeBanLuaChon.BackColor = Color.Purple;
                btnThemeBanLuaChon.ForeColor = Color.Yellow;
                btnThemeBanLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
    }
}
