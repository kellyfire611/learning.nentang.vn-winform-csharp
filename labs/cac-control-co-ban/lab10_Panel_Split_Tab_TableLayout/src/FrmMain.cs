using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_Panel_Split_Tab_TableLayout
{
    public partial class FrmMain : Form
    {
        List<HocPhan> lstHocPhan;

        public FrmMain()
        {
            InitializeComponent();

            lstHocPhan = new List<HocPhan>()
            {
                new HocPhan()
                {
                    Id = 1,
                    Ma = "XH023",
                    Ten = "Anh văn căn bản 1",
                    SoTinChi = 4
                },
                new HocPhan()
                {
                    Id = 2,
                    Ma = "ML014",
                    Ten = "Triết học Mác - Lênin",
                    SoTinChi = 3
                },
                new HocPhan()
                {
                    Id = 3,
                    Ma = "KN002",
                    Ten = "Đổi mới sáng tạo và khởi nghiệp",
                    SoTinChi = 4
                },
                new HocPhan()
                {
                    Id = 4,
                    Ma = "CT200",
                    Ten = "Anh văn căn bản 1",
                    SoTinChi = 4
                },
                new HocPhan()
                {
                    Id = 5,
                    Ma = "XH023",
                    Ten = "Nền tảng công nghệ thông tin",
                    SoTinChi = 2
                },
                new HocPhan()
                {
                    Id = 6,
                    Ma = "CT172",
                    Ten = "Toán rời rạc",
                    SoTinChi = 6
                },
                new HocPhan()
                {
                    Ma = "CT175",
                    Ten = "Lý Thuyết đồ thị",
                    SoTinChi = 5
                },
                new HocPhan()
                {
                    Ma = "XH023",
                    Ten = "Anh văn căn bản 1",
                    SoTinChi = 4
                },
                new HocPhan()
                {
                    Ma = "CT190",
                    Ten = "Nhập môn trí tuệ nhân tạo",
                    SoTinChi = 6
                },
                new HocPhan()
                {
                    Ma = "CT180",
                    Ten = "Cơ sở dữ liệu",
                    SoTinChi = 3
                },
                new HocPhan()
                {
                    Ma = "CT274",
                    Ten = "Lập trình cho thiết bị di động",
                    SoTinChi = 3
                },
                new HocPhan()
                {
                    Ma = "CT190",
                    Ten = " Phát triển hệ thống web",
                    SoTinChi = 5
                },
                new HocPhan()
                {
                    Ma = "CT255",
                    Ten = "Nghiệp vụ thông minh",
                    SoTinChi = 2
                },
                new HocPhan()
                {
                    Ma = "CT280",
                    Ten = "Cơ sở dữ liệu NoSQL",
                    SoTinChi = 4
                },
            };
        }

        // Xử lý sự kiện Load Form
        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class HocPhan
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public int SoTinChi { get; set; }
    }
}
