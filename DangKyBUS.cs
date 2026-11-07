using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Lab12.DAL;
using Lab12.DTO;

namespace Lab12.BUS
{
    public class DangKyBUS
    {
        private readonly DangKyDAL _dal = new DangKyDAL();

        // Bai 2: danh sach hoc phan da dang ky cua 1 sinh vien
        public List<DangKyDTO> GetBySinhVien(string maSV)
        {
            return _dal.GetBySinhVien(maSV);
        }

        // Bai 2 (them dang ky don le, ben ngoai giao dich lon o bai 3):
        // van mo 1 giao dich rieng cho dung 1 cau lenh nay, de tai su dung dung
        // phuong thuc DAL nhan Connection/Transaction nhu bai 5 yeu cau.
        public void AddEnrollment(DangKyDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.MaSV))
                throw new ArgumentException("Thiếu mã sinh viên.");
            if (string.IsNullOrWhiteSpace(dto.MaHP))
                throw new ArgumentException("Vui lòng chọn học phần.");
            if (dto.HocKy <= 0)
                throw new ArgumentException("Học kỳ không hợp lệ.");

            using (SqlConnection conn = DAL.DbConnectionFactory.Create())
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction();
                try
                {
                    _dal.InsertEnrollment(dto, conn, tx);
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
