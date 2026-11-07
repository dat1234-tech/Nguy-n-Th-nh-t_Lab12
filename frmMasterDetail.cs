using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Lab12.BUS;
using Lab12.DTO;

namespace Lab12.GUI
{
    public partial class frmMasterDetail : Form
    {
        private readonly KhoaBUS _khoaBus = new KhoaBUS();
        private readonly HocPhanBUS _hocPhanBus = new HocPhanBUS();
        private readonly SinhVienBUS _sinhVienBus = new SinhVienBUS();
        private readonly DangKyBUS _dangKyBus = new DangKyBUS();

        // Danh sach dang ky ban dau dang cho duyet (chua luu xuong CSDL) - dung cho Tab 2
        private readonly List<DangKyDTO> _dsDangKyCho = new List<DangKyDTO>();

        public frmMasterDetail()
        {
            InitializeComponent();
        }

        private void frmMasterDetail_Load(object sender, EventArgs e)
        {
            try
            {
                LoadKhoa();
                LoadHocPhanCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu ban đầu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKhoa()
        {
            List<KhoaDTO> ds = _khoaBus.GetAll();
            dgvKhoa.AutoGenerateColumns = false;
            dgvKhoa.DataSource = ds;

            cboKhoa2.DataSource = _khoaBus.GetAll();
            cboKhoa2.DisplayMember = "TenKhoa";
            cboKhoa2.ValueMember = "MaKhoa";
            cboKhoa2.SelectedIndex = -1;
        }

        private void LoadHocPhanCombos()
        {
            List<HocPhanDTO> ds1 = _hocPhanBus.GetAll();
            cboHocPhanThem.DataSource = ds1;
            cboHocPhanThem.DisplayMember = "TenHP";
            cboHocPhanThem.ValueMember = "MaHP";
            cboHocPhanThem.SelectedIndex = -1;

            List<HocPhanDTO> ds2 = _hocPhanBus.GetAll();
            cboHocPhanDK.DataSource = ds2;
            cboHocPhanDK.DisplayMember = "TenHP";
            cboHocPhanDK.ValueMember = "MaHP";
            cboHocPhanDK.SelectedIndex = -1;
        }

        // ===================== Bai 1: Master-detail Khoa -> SinhVien =====================
        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;
            KhoaDTO khoa = dgvKhoa.CurrentRow.DataBoundItem as KhoaDTO;
            if (khoa == null) return;

            string maKhoa = khoa.MaKhoa;
            try
            {
                List<SinhVienDTO> ds = _sinhVienBus.GetByDepartment(maKhoa);
                dgvSinhVien.AutoGenerateColumns = false;
                dgvSinhVien.DataSource = ds;
                lblTrangThai.Text = "Sinh viên thuộc khoa: " + maKhoa + " (" + ds.Count + " sinh viên).";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sinh viên theo khoa: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Xoa luon bang dang ky vi chua chon sinh vien cu the
            dgvDangKy.DataSource = null;
        }

        // ===================== Bai 2: Master-detail SinhVien -> DangKy =====================
        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;
            SinhVienDTO sv = dgvSinhVien.CurrentRow.DataBoundItem as SinhVienDTO;
            if (sv == null) return;

            LoadDangKyCuaSinhVien(sv.MaSV);
        }

        private void LoadDangKyCuaSinhVien(string maSV)
        {
            try
            {
                List<DangKyDTO> ds = _dangKyBus.GetBySinhVien(maSV);
                dgvDangKy.AutoGenerateColumns = false;
                dgvDangKy.DataSource = ds;
                lblTrangThai.Text = "Đang xem đăng ký của sinh viên: " + maSV + " (" + ds.Count + " học phần).";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách đăng ký: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nut "Thêm đăng ký" ngay trong tab Master-Detail: them 1 dang ky don cho
        // sinh vien dang duoc chon (goi qua DangKyBUS, van dung phuong thuc DAL
        // nhan Connection/Transaction nhu bai 5 yeu cau, chi la giao dich 1 buoc).
        private void btnThemDangKy_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn 1 sinh viên ở bảng trên trước.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SinhVienDTO sv = dgvSinhVien.CurrentRow.DataBoundItem as SinhVienDTO;
            if (sv == null) return;

            if (cboHocPhanThem.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn học phần.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int hocKy;
            if (!int.TryParse(txtHocKyThem.Text.Trim(), out hocKy) || hocKy <= 0)
            {
                MessageBox.Show("Học kỳ không hợp lệ.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DangKyDTO dto = new DangKyDTO
            {
                MaSV = sv.MaSV,
                MaHP = cboHocPhanThem.SelectedValue.ToString(),
                HocKy = hocKy,
                Diem = null
            };

            try
            {
                _dangKyBus.AddEnrollment(dto);
                LoadDangKyCuaSinhVien(sv.MaSV);
                MessageBox.Show("Thêm đăng ký thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== Tab 2: danh sach dang ky ban dau (chua luu) =====================
        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            if (cboHocPhanDK.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn học phần.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int hocKy;
            if (!int.TryParse(txtHocKyDK.Text.Trim(), out hocKy) || hocKy <= 0)
            {
                MessageBox.Show("Học kỳ không hợp lệ.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHP = cboHocPhanDK.SelectedValue.ToString();
            if (_dsDangKyCho.Any(x => x.MaHP == maHP && x.HocKy == hocKy))
            {
                MessageBox.Show("Học phần này (cùng học kỳ) đã có trong danh sách.", "Trùng",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DangKyDTO dto = new DangKyDTO { MaHP = maHP, HocKy = hocKy, TenHP = cboHocPhanDK.Text };
            _dsDangKyCho.Add(dto);
            RefreshDsDangKyCho();
        }

        private void btnXoaKhoiDS_Click(object sender, EventArgs e)
        {
            int index = lstDangKyChoDuyet.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Chọn 1 dòng trong danh sách để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _dsDangKyCho.RemoveAt(index);
            RefreshDsDangKyCho();
        }

        private void RefreshDsDangKyCho()
        {
            lstDangKyChoDuyet.Items.Clear();
            foreach (DangKyDTO dk in _dsDangKyCho)
            {
                lstDangKyChoDuyet.Items.Add(dk.MaHP + " - " + dk.TenHP + " - Học kỳ " + dk.HocKy);
            }
        }

        // ===================== Bai 3 + Bai 4: Transaction + Rollback =====================
        private void btnLuuGiaoDich_Click(object sender, EventArgs e)
        {
            SinhVienDTO dto = ReadSinhVienMoi();
            if (dto == null) return;

            // Sao chep danh sach dang ky ban dau, khong sua truc tiep _dsDangKyCho
            List<DangKyDTO> danhSach = _dsDangKyCho
                .Select(x => new DangKyDTO { MaHP = x.MaHP, HocKy = x.HocKy, TenHP = x.TenHP, Diem = null })
                .ToList();

            // Bai 4: gia lap loi bang cach chen them 1 ma hoc phan khong ton tai,
            // se vi pham khoa ngoai FK_DangKy_HocPhan -> SqlException -> Rollback
            if (chkGiaLapLoi.Checked)
            {
                danhSach.Add(new DangKyDTO { MaHP = "KHONGTONTAI", HocKy = 1, Diem = null });
            }

            try
            {
                _sinhVienBus.AddStudentWithEnrollments(dto, danhSach);
                lblKetQua.Text = "Giao dịch THÀNH CÔNG: đã thêm sinh viên " + dto.MaSV +
                    " cùng " + danhSach.Count + " đăng ký.";
                MessageBox.Show("Lưu giao dịch thành công.");

                // Nap lai Khoa/SinhVien de thay du lieu moi tren luoi (neu dang xem dung khoa)
                dgvKhoa_SelectionChanged(this, EventArgs.Empty);

                _dsDangKyCho.Clear();
                RefreshDsDangKyCho();
                ClearSinhVienMoi();
            }
            catch (Exception ex)
            {
                bool conTonTai = _sinhVienBus.Exists(dto.MaSV);
                lblKetQua.Text = "Giao dịch THẤT BẠI và đã ROLLBACK.\r\n" +
                    "Lỗi: " + ex.Message + "\r\n" +
                    "Sinh viên " + dto.MaSV + " có tồn tại trong CSDL sau khi rollback? " +
                    (conTonTai ? "CÓ (bất thường!)" : "KHÔNG (đúng như kỳ vọng - rollback thành công).");
                MessageBox.Show("Giao dịch thất bại và đã hoàn tác.\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bai 4: nut kiem tra doc lap, xac nhan sinh vien co duoc luu hay khong
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV2.Text.Trim();
            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show("Nhập Mã SV cần kiểm tra ở ô bên trên.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool ton = _sinhVienBus.Exists(maSV);
                lblKetQua.Text = "Kiểm tra: sinh viên " + maSV + (ton
                    ? " ĐÃ TỒN TẠI trong CSDL."
                    : " KHÔNG tồn tại trong CSDL.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private SinhVienDTO ReadSinhVienMoi()
        {
            decimal diem;
            if (!decimal.TryParse(txtDiemTB2.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out diem))
            {
                MessageBox.Show("Điểm trung bình không hợp lệ.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            if (cboKhoa2.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khoa.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new SinhVienDTO
            {
                MaSV = txtMaSV2.Text.Trim(),
                HoTen = txtHoTen2.Text.Trim(),
                NgaySinh = dtpNgaySinh2.Value.Date,
                GioiTinh = radNam2.Checked,
                MaKhoa = cboKhoa2.SelectedValue.ToString(),
                DiemTB = diem,
                Email = txtEmail2.Text.Trim()
            };
        }

        private void ClearSinhVienMoi()
        {
            txtMaSV2.Clear();
            txtHoTen2.Clear();
            dtpNgaySinh2.Value = DateTime.Today;
            radNam2.Checked = true;
            cboKhoa2.SelectedIndex = -1;
            txtDiemTB2.Clear();
            txtEmail2.Clear();
            chkGiaLapLoi.Checked = false;
        }
    }
}
