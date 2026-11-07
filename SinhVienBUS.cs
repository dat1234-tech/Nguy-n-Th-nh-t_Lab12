using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Lab12.DAL;
using Lab12.DTO;

namespace Lab12.BUS
{
    public class SinhVienBUS
    {
        private readonly SinhVienDAL _svDal = new SinhVienDAL();
        private readonly DangKyDAL _dkDal = new DangKyDAL();

        private static readonly Regex EmailPattern =
            new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

        // Bai 1: lay danh sach sinh vien theo khoa (master-detail Khoa - SinhVien)
        public List<SinhVienDTO> GetByDepartment(string maKhoa)
        {
            return _svDal.GetByDepartment(maKhoa);
        }

        // Bai 4: kiem tra sinh vien co trong CSDL khong, dung de xac nhan rollback
        public bool Exists(string maSV)
        {
            return _svDal.Exists(maSV);
        }

        private static void ValidateSinhVien(SinhVienDTO dto)
        {
            if (dto == null) throw new ArgumentNullException("dto");
            if (string.IsNullOrWhiteSpace(dto.MaSV))
                throw new ArgumentException("Mã sinh viên không được rỗng.");
            if (string.IsNullOrWhiteSpace(dto.HoTen))
                throw new ArgumentException("Họ tên không được rỗng.");
            if (string.IsNullOrWhiteSpace(dto.MaKhoa))
                throw new ArgumentException("Chưa chọn khoa.");
            if (dto.NgaySinh > DateTime.Today.AddYears(-15))
                throw new ArgumentException("Tuổi sinh viên chưa hợp lệ.");
            if (dto.DiemTB < 0 || dto.DiemTB > 10)
                throw new ArgumentException("Điểm phải thuộc [0,10].");
            if (!string.IsNullOrWhiteSpace(dto.Email) && !EmailPattern.IsMatch(dto.Email.Trim()))
                throw new ArgumentException("Email không đúng định dạng.");
        }

        private static void ValidateDangKy(DangKyDTO dk)
        {
            if (string.IsNullOrWhiteSpace(dk.MaHP))
                throw new ArgumentException("Thiếu mã học phần trong danh sách đăng ký.");
            if (dk.HocKy <= 0)
                throw new ArgumentException("Học kỳ không hợp lệ trong danh sách đăng ký.");
        }

        // Bai 3 + bai 4: them sinh vien va danh sach dang ky trong CUNG MOT giao dich.
        // Neu bat ky buoc nao loi (vi du MaHP sai -> vi pham khoa ngoai), toan bo
        // giao dich duoc Rollback: sinh vien cung KHONG duoc luu.
        public void AddStudentWithEnrollments(SinhVienDTO dto, List<DangKyDTO> danhSachDangKy)
        {
            ValidateSinhVien(dto);
            if (danhSachDangKy != null)
            {
                foreach (DangKyDTO dk in danhSachDangKy) ValidateDangKy(dk);
            }

            using (SqlConnection conn = DAL.DbConnectionFactory.Create())
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction();
                try
                {
                    _svDal.Insert(dto, conn, tx);

                    if (danhSachDangKy != null)
                    {
                        foreach (DangKyDTO dk in danhSachDangKy)
                        {
                            dk.MaSV = dto.MaSV;
                            _dkDal.InsertEnrollment(dk, conn, tx);
                        }
                    }

                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
    }
}
