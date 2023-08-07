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
        private string _formState;
        public string FormState
        {
            get
            {
                return _formState;
            }
            set
            {
                _formState = value;
                if (_formState == "VIEW")
                {
                    // Panel Trái
                    dgvDanhSachSinhVien.ReadOnly = true;

                    // Panel Phải
                    // -- Tab Thông tin cá nhân
                    txtMaSV.Enabled = false;
                    txtHoTen.Enabled = false;
                    dtpNgaySinh.Enabled = false;
                    rdGioiTinhNam.Enabled = false;
                    rdGioiTinhNu.Enabled = false;
                    txtDienThoai.Enabled = false;
                    txtEmail.Enabled = false;
                    cbbDanToc.Enabled = false;
                    cbbTonGiao.Enabled = false;
                    txtDiaChi.Enabled = false;
                    rtxtGhiChu.Enabled = false;
                    btnLuaChonHinh.Enabled = false;
                    btnXoaBoHinh.Enabled = false;

                    // -- Tab Thông tin điểm thi tuyển
                    rdPhuongAn1.Enabled = false;
                    cbbPhuongAn1_Mon1.Enabled = false;
                    numPhuongAn1_Mon1_DiemTB_Lop10.Enabled = false;
                    numPhuongAn1_Mon1_DiemTB_Lop11.Enabled = false;
                    numPhuongAn1_Mon1_DiemTB_Lop12.Enabled = false;

                    cbbPhuongAn1_Mon2.Enabled = false;
                    numPhuongAn1_Mon2_DiemTB_Lop10.Enabled = false;
                    numPhuongAn1_Mon2_DiemTB_Lop11.Enabled = false;
                    numPhuongAn1_Mon2_DiemTB_Lop12.Enabled = false;

                    cbbPhuongAn1_Mon3.Enabled = false;
                    numPhuongAn1_Mon3_DiemTB_Lop10.Enabled = false;
                    numPhuongAn1_Mon3_DiemTB_Lop11.Enabled = false;
                    numPhuongAn1_Mon3_DiemTB_Lop12.Enabled = false;

                    rdPhuongAn2.Enabled = false;
                    cbbPhuongAn2_Mon1.Enabled = false;
                    numPhuongAn2_Mon1_DiemTB_Lop12.Enabled = false;

                    cbbPhuongAn2_Mon2.Enabled = false;
                    numPhuongAn2_Mon2_DiemTB_Lop12.Enabled = false;

                    cbbPhuongAn2_Mon3.Enabled = false;
                    numPhuongAn2_Mon3_DiemTB_Lop12.Enabled = false;

                    // Các button
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = false;
                    btnThoat.Enabled = true;
                    btnBoQua.Visible = false;
                    btnBoQua.Enabled = false;
                }
                else if (_formState == "ADD")
                {
                    // Panel Trái
                    dgvDanhSachSinhVien.ReadOnly = true;

                    // Panel Phải
                    // -- Tab Thông tin cá nhân
                    txtMaSV.Enabled = true;
                    txtHoTen.Enabled = true;
                    dtpNgaySinh.Enabled = true;
                    rdGioiTinhNam.Enabled = true;
                    rdGioiTinhNu.Enabled = true;
                    txtDienThoai.Enabled = true;
                    txtEmail.Enabled = true;
                    cbbDanToc.Enabled = true;
                    cbbTonGiao.Enabled = true;
                    txtDiaChi.Enabled = true;
                    rtxtGhiChu.Enabled = true;
                    btnLuaChonHinh.Enabled = true;
                    btnXoaBoHinh.Enabled = true;

                    // -- Tab Thông tin điểm thi tuyển
                    rdPhuongAn1.Enabled = true;
                    cbbPhuongAn1_Mon1.Enabled = true;
                    numPhuongAn1_Mon1_DiemTB_Lop10.Enabled = true;
                    numPhuongAn1_Mon1_DiemTB_Lop11.Enabled = true;
                    numPhuongAn1_Mon1_DiemTB_Lop12.Enabled = true;

                    cbbPhuongAn1_Mon2.Enabled = true;
                    numPhuongAn1_Mon2_DiemTB_Lop10.Enabled = true;
                    numPhuongAn1_Mon2_DiemTB_Lop11.Enabled = true;
                    numPhuongAn1_Mon2_DiemTB_Lop12.Enabled = true;

                    cbbPhuongAn1_Mon3.Enabled = true;
                    numPhuongAn1_Mon3_DiemTB_Lop10.Enabled = true;
                    numPhuongAn1_Mon3_DiemTB_Lop11.Enabled = true;
                    numPhuongAn1_Mon3_DiemTB_Lop12.Enabled = true;

                    rdPhuongAn2.Enabled = true;
                    cbbPhuongAn2_Mon1.Enabled = true;
                    numPhuongAn2_Mon1_DiemTB_Lop12.Enabled = true;

                    cbbPhuongAn2_Mon2.Enabled = true;
                    numPhuongAn2_Mon2_DiemTB_Lop12.Enabled = true;

                    cbbPhuongAn2_Mon3.Enabled = true;
                    numPhuongAn2_Mon3_DiemTB_Lop12.Enabled = true;

                    // Các button
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnThoat.Enabled = false;
                    btnBoQua.Visible = true;
                    btnBoQua.Enabled = true;
                }
                else if (_formState == "MODIFY")
                {

                }
                else if (_formState == "DELETE")
                {

                }
                else if (_formState == "SAVE")
                {

                }
            }
        }

        List<DanToc> lstDanToc;
        List<TonGiao> lstTonGiao;
        List<MonHoc> lstMonHoc;
        List<SinhVien> lstSinhVien;

        public FrmMain()
        {
            InitializeComponent();

            // Load dữ liệu ban đầu
            lstDanToc = new List<DanToc>()
            {
                new DanToc()
                {
                    Id = 1,
                    MaDanToc = "K",
                    TenDanToc = "Kinh"
                },
                new DanToc()
                {
                    Id = 2,
                    MaDanToc = "Khome",
                    TenDanToc = "Khơ me"
                },
                new DanToc()
                {
                    Id = 3,
                    MaDanToc = "T",
                    TenDanToc = "Tày"
                },
                new DanToc()
                {
                    Id = 4,
                    MaDanToc = "N",
                    TenDanToc = "Nùng"
                },
            };

            lstTonGiao = new List<TonGiao>()
            {
                new TonGiao()
                {
                    Id = 1,
                    MaTonGiao = "PG",
                    TenTonGiao = "Phật giáo"
                },
                new TonGiao()
                {
                    Id = 2,
                    MaTonGiao = "TC",
                    TenTonGiao = "Thiên chúa"
                },
                new TonGiao()
                {
                    Id = 3,
                    MaTonGiao = "HH",
                    TenTonGiao = "Hòa hão"
                },
            };

            lstMonHoc = new List<MonHoc>()
            {
                new MonHoc()
                {
                    Id = 1,
                    MaMonHoc = "T",
                    TenMonHoc = "Toán"
                },
                new MonHoc()
                {
                    Id = 2,
                    MaMonHoc = "L",
                    TenMonHoc = "Lý"
                },
                new MonHoc()
                {
                    Id = 3,
                    MaMonHoc = "H",
                    TenMonHoc = "Hóa"
                },
                new MonHoc()
                {
                    Id = 4,
                    MaMonHoc = "S",
                    TenMonHoc = "Sinh"
                },
                new MonHoc()
                {
                    Id = 5,
                    MaMonHoc = "Su",
                    TenMonHoc = "Sử"
                },
                new MonHoc()
                {
                    Id = 6,
                    MaMonHoc = "D",
                    TenMonHoc = "Địa"
                },
                new MonHoc()
                {
                    Id = 7,
                    MaMonHoc = "AV",
                    TenMonHoc = "Anh văn"
                },
            };

            lstSinhVien = new List<SinhVien>()
            {
                new SinhVien()
                {
                    Id = 1,
                    MaSV = "SV001",
                    HoTen = "Dương Nguyễn Phú Cường",
                    NgaySinh = new DateTime(1989, 06, 11),
                    GioiTinh = "Nam",
                    DienThoai = "0915659223",
                    Email = "phucuong@ctu.edu.vn",
                    DanTocId = 1,
                    TonGiaoId = 2,
                    DiaChi = "130 Xô Viết Nghệ Tỉnh, Cần Thơ",
                    GhiChu = "Mới gởi đơn xét tuyển, còn thiếu bản công chứng giấy khai sinh, CCCD. Cần bổ sung trước khi nộp hồ sơ nhập học.",

                    PhuongAn1 = true,
                    PhuongAn1_MonHoc1_Id = 1,
                    PhuongAn1_MonHoc1_DiemTB_Lop10 = 8,
                    PhuongAn1_MonHoc1_DiemTB_Lop11 = 9.8M,
                    PhuongAn1_MonHoc1_DiemTB_Lop12 = 9.7M,

                    PhuongAn1_MonHoc2_Id = 2,
                    PhuongAn1_MonHoc2_DiemTB_Lop10 = 9.8M,
                    PhuongAn1_MonHoc2_DiemTB_Lop11 = 9.6M,
                    PhuongAn1_MonHoc2_DiemTB_Lop12 = 9.9M,

                    PhuongAn1_MonHoc3_Id = 3,
                    PhuongAn1_MonHoc3_DiemTB_Lop10 = 10M,
                    PhuongAn1_MonHoc3_DiemTB_Lop11 = 8.9M,
                    PhuongAn1_MonHoc3_DiemTB_Lop12 = 9.8M,
                }
            };

            // Set trạng thái mặc định của Form là VIEW
            this.FormState = "VIEW";
        }

        // Xử lý sự kiện Load Form
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Panel Trái
            dgvDanhSachSinhVien.AutoGenerateColumns = false;
            dgvDanhSachSinhVien.DataSource = lstSinhVien;

            // Panel Phải
            cbbDanToc.DataSource = lstDanToc;
            cbbDanToc.DisplayMember = "TenDanToc";
            cbbDanToc.ValueMember = "Id";

            cbbTonGiao.DataSource = lstTonGiao;
            cbbTonGiao.DisplayMember = "TenTonGiao";
            cbbTonGiao.ValueMember = "Id";

            cbbPhuongAn1_Mon1.DataSource = lstMonHoc.ToList();
            cbbPhuongAn1_Mon1.DisplayMember = "TenMonHoc";
            cbbPhuongAn1_Mon1.ValueMember = "Id";

            cbbPhuongAn1_Mon2.DataSource = lstMonHoc.ToList();
            cbbPhuongAn1_Mon2.DisplayMember = "TenMonHoc";
            cbbPhuongAn1_Mon2.ValueMember = "Id";

            cbbPhuongAn1_Mon3.DataSource = lstMonHoc.ToList();
            cbbPhuongAn1_Mon3.DisplayMember = "TenMonHoc";
            cbbPhuongAn1_Mon3.ValueMember = "Id";

            cbbPhuongAn2_Mon1.DataSource = lstMonHoc.ToList();
            cbbPhuongAn2_Mon1.DisplayMember = "TenMonHoc";
            cbbPhuongAn2_Mon1.ValueMember = "Id";

            cbbPhuongAn2_Mon2.DataSource = lstMonHoc.ToList();
            cbbPhuongAn2_Mon2.DisplayMember = "TenMonHoc";
            cbbPhuongAn2_Mon2.ValueMember = "Id";

            cbbPhuongAn2_Mon3.DataSource = lstMonHoc.ToList();
            cbbPhuongAn2_Mon3.DisplayMember = "TenMonHoc";
            cbbPhuongAn2_Mon3.ValueMember = "Id";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDanhSachSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SinhVien currentSV = lstSinhVien[e.RowIndex];
            if (currentSV != null)
            {
                txtMaSV.Text = currentSV.MaSV;
                txtHoTen.Text = currentSV.HoTen;
                dtpNgaySinh.Value = currentSV.NgaySinh;
                if (currentSV.GioiTinh == "Nam")
                {
                    rdGioiTinhNam.Checked = true;
                    rdGioiTinhNu.Checked = false;
                }
                else if (currentSV.GioiTinh == "Nữ")
                {
                    rdGioiTinhNam.Checked = false;
                    rdGioiTinhNu.Checked = true;
                }
                txtDienThoai.Text = currentSV.DienThoai;
                txtEmail.Text = currentSV.Email;
                cbbDanToc.SelectedValue = currentSV.DanTocId;
                cbbTonGiao.SelectedValue = currentSV.TonGiaoId;
                txtDiaChi.Text = currentSV.DiaChi;
                rtxtGhiChu.Text = currentSV.GhiChu;

                rdPhuongAn1.Checked = currentSV.PhuongAn1;
                cbbPhuongAn1_Mon1.SelectedValue = currentSV.PhuongAn1_MonHoc1_Id;
                numPhuongAn1_Mon1_DiemTB_Lop10.Value = currentSV.PhuongAn1_MonHoc1_DiemTB_Lop10;
                numPhuongAn1_Mon1_DiemTB_Lop11.Value = currentSV.PhuongAn1_MonHoc1_DiemTB_Lop11;
                numPhuongAn1_Mon1_DiemTB_Lop12.Value = currentSV.PhuongAn1_MonHoc1_DiemTB_Lop12;

                cbbPhuongAn1_Mon2.SelectedValue = currentSV.PhuongAn1_MonHoc2_Id;
                numPhuongAn1_Mon2_DiemTB_Lop10.Value = currentSV.PhuongAn1_MonHoc2_DiemTB_Lop10;
                numPhuongAn1_Mon2_DiemTB_Lop11.Value = currentSV.PhuongAn1_MonHoc2_DiemTB_Lop11;
                numPhuongAn1_Mon2_DiemTB_Lop12.Value = currentSV.PhuongAn1_MonHoc2_DiemTB_Lop12;

                cbbPhuongAn1_Mon3.SelectedValue = currentSV.PhuongAn1_MonHoc3_Id;
                numPhuongAn1_Mon3_DiemTB_Lop10.Value = currentSV.PhuongAn1_MonHoc3_DiemTB_Lop10;
                numPhuongAn1_Mon3_DiemTB_Lop11.Value = currentSV.PhuongAn1_MonHoc3_DiemTB_Lop11;
                numPhuongAn1_Mon3_DiemTB_Lop12.Value = currentSV.PhuongAn1_MonHoc3_DiemTB_Lop12;

                rdPhuongAn2.Checked = currentSV.PhuongAn2;
                cbbPhuongAn2_Mon1.SelectedValue = currentSV.PhuongAn2_MonHoc1_Id;
                numPhuongAn2_Mon1_DiemTB_Lop12.Value = currentSV.PhuongAn2_MonHoc1_DiemTB_Lop12;

                cbbPhuongAn2_Mon2.SelectedValue = currentSV.PhuongAn2_MonHoc2_Id;
                numPhuongAn2_Mon2_DiemTB_Lop12.Value = currentSV.PhuongAn2_MonHoc2_DiemTB_Lop12;

                cbbPhuongAn2_Mon3.SelectedValue = currentSV.PhuongAn2_MonHoc3_Id;
                numPhuongAn2_Mon3_DiemTB_Lop12.Value = currentSV.PhuongAn2_MonHoc3_DiemTB_Lop12;
            }
        }

        private void PhuongAn1_TinhTongDiem(object sender, EventArgs e)
        {
            // Lớp 10
            decimal tongDiem_Lop10 = (numPhuongAn1_Mon1_DiemTB_Lop10.Value
                + numPhuongAn1_Mon2_DiemTB_Lop10.Value
                + numPhuongAn1_Mon3_DiemTB_Lop10.Value);

            lblPhuongAn1_TongDiem_Lop10.Text = String.Format("{0:n2}", tongDiem_Lop10);

            // Lớp 11
            decimal tongDiem_Lop11 = (numPhuongAn1_Mon1_DiemTB_Lop11.Value
                + numPhuongAn1_Mon2_DiemTB_Lop11.Value
                + numPhuongAn1_Mon3_DiemTB_Lop11.Value);

            lblPhuongAn1_TongDiem_Lop11.Text = String.Format("{0:n2}", tongDiem_Lop11);

            // Lớp 12
            decimal tongDiem_Lop12 = (numPhuongAn1_Mon1_DiemTB_Lop12.Value
                + numPhuongAn1_Mon2_DiemTB_Lop12.Value
                + numPhuongAn1_Mon3_DiemTB_Lop12.Value);

            lblPhuongAn1_TongDiem_Lop12.Text = String.Format("{0:n2}", tongDiem_Lop12);

            // Trung bình cộng
            decimal trungBinhCong = (tongDiem_Lop10 + tongDiem_Lop11 + tongDiem_Lop12) / 3;

            lblPhuongAn1_TrungBinhCong.Text = String.Format("{0:n2}", trungBinhCong);
        }

        private void PhuongAn2_TinhTongDiem(object sender, EventArgs e)
        {
            decimal tongDiem = (numPhuongAn2_Mon1_DiemTB_Lop12.Value
                + numPhuongAn2_Mon2_DiemTB_Lop12.Value
                + numPhuongAn2_Mon3_DiemTB_Lop12.Value);

            lblPhuongAn2_TongDiem.Text = String.Format("{0:n2}", tongDiem);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.FormState = "ADD";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.FormState = "MODIFY";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.FormState = "DELETE";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.FormState = "SAVE";
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.FormState = "VIEW";
        }

        private void LuaChonPhuongAn(object sender, EventArgs e)
        {
            if (rdPhuongAn1.Checked)
            {
                // -- Tab Thông tin điểm thi tuyển
                rdPhuongAn1.Enabled = true;
                cbbPhuongAn1_Mon1.Enabled = true;
                numPhuongAn1_Mon1_DiemTB_Lop10.Enabled = true;
                numPhuongAn1_Mon1_DiemTB_Lop11.Enabled = true;
                numPhuongAn1_Mon1_DiemTB_Lop12.Enabled = true;

                cbbPhuongAn1_Mon2.Enabled = true;
                numPhuongAn1_Mon2_DiemTB_Lop10.Enabled = true;
                numPhuongAn1_Mon2_DiemTB_Lop11.Enabled = true;
                numPhuongAn1_Mon2_DiemTB_Lop12.Enabled = true;

                cbbPhuongAn1_Mon3.Enabled = true;
                numPhuongAn1_Mon3_DiemTB_Lop10.Enabled = true;
                numPhuongAn1_Mon3_DiemTB_Lop11.Enabled = true;
                numPhuongAn1_Mon3_DiemTB_Lop12.Enabled = true;

                rdPhuongAn2.Enabled = false;
                cbbPhuongAn2_Mon1.Enabled = false;
                numPhuongAn2_Mon1_DiemTB_Lop12.Enabled = false;

                cbbPhuongAn2_Mon2.Enabled = false;
                numPhuongAn2_Mon2_DiemTB_Lop12.Enabled = false;

                cbbPhuongAn2_Mon3.Enabled = false;
                numPhuongAn2_Mon3_DiemTB_Lop12.Enabled = false;
            }
            else if (rdPhuongAn2.Checked)
            {
                // -- Tab Thông tin điểm thi tuyển
                rdPhuongAn1.Enabled = true;
                cbbPhuongAn1_Mon1.Enabled = false;
                numPhuongAn1_Mon1_DiemTB_Lop10.Enabled = false;
                numPhuongAn1_Mon1_DiemTB_Lop11.Enabled = false;
                numPhuongAn1_Mon1_DiemTB_Lop12.Enabled = false;

                cbbPhuongAn1_Mon2.Enabled = false;
                numPhuongAn1_Mon2_DiemTB_Lop10.Enabled = false;
                numPhuongAn1_Mon2_DiemTB_Lop11.Enabled = false;
                numPhuongAn1_Mon2_DiemTB_Lop12.Enabled = false;

                cbbPhuongAn1_Mon3.Enabled = false;
                numPhuongAn1_Mon3_DiemTB_Lop10.Enabled = false;
                numPhuongAn1_Mon3_DiemTB_Lop11.Enabled = false;
                numPhuongAn1_Mon3_DiemTB_Lop12.Enabled = false;

                rdPhuongAn2.Enabled = true;
                cbbPhuongAn2_Mon1.Enabled = true;
                numPhuongAn2_Mon1_DiemTB_Lop12.Enabled = true;

                cbbPhuongAn2_Mon2.Enabled = true;
                numPhuongAn2_Mon2_DiemTB_Lop12.Enabled = true;

                cbbPhuongAn2_Mon3.Enabled = true;
                numPhuongAn2_Mon3_DiemTB_Lop12.Enabled = true;
            }
        }
    }

    public class DanToc
    {
        public int Id { get; set; }
        public string MaDanToc { get; set; }
        public string TenDanToc { get; set; }
    }

    public class TonGiao
    {
        public int Id { get; set; }
        public string MaTonGiao { get; set; }
        public string TenTonGiao { get; set; }
    }

    public class MonHoc
    {
        public int Id { get; set; }
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
    }

    public class SinhVien
    {
        public int Id { get; set; }
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public int DanTocId { get; set; }
        public int TonGiaoId { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
        public string HinhDaiDien { get; set; }

        public bool PhuongAn1 { get; set; }
        public int PhuongAn1_MonHoc1_Id { get; set; }
        public decimal PhuongAn1_MonHoc1_DiemTB_Lop10 { get; set; }
        public decimal PhuongAn1_MonHoc1_DiemTB_Lop11 { get; set; }
        public decimal PhuongAn1_MonHoc1_DiemTB_Lop12 { get; set; }

        public int PhuongAn1_MonHoc2_Id { get; set; }
        public decimal PhuongAn1_MonHoc2_DiemTB_Lop10 { get; set; }
        public decimal PhuongAn1_MonHoc2_DiemTB_Lop11 { get; set; }
        public decimal PhuongAn1_MonHoc2_DiemTB_Lop12 { get; set; }

        public int PhuongAn1_MonHoc3_Id { get; set; }
        public decimal PhuongAn1_MonHoc3_DiemTB_Lop10 { get; set; }
        public decimal PhuongAn1_MonHoc3_DiemTB_Lop11 { get; set; }
        public decimal PhuongAn1_MonHoc3_DiemTB_Lop12 { get; set; }

        public bool PhuongAn2 { get; set; }
        public int PhuongAn2_MonHoc1_Id { get; set; }
        public decimal PhuongAn2_MonHoc1_DiemTB_Lop12 { get; set; }

        public int PhuongAn2_MonHoc2_Id { get; set; }
        public decimal PhuongAn2_MonHoc2_DiemTB_Lop12 { get; set; }

        public int PhuongAn2_MonHoc3_Id { get; set; }
        public decimal PhuongAn2_MonHoc3_DiemTB_Lop12 { get; set; }
    }
}
