using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Lab12.DTO;

namespace Lab12.DAL
{
    public class SinhVienDAL
    {
        // Bai 1: lay danh sach sinh vien theo khoa, dung cho master-detail Khoa - SinhVien
        public List<SinhVienDTO> GetByDepartment(string maKhoa)
        {
            string sql = @"SELECT sv.MaSV, sv.HoTen, sv.NgaySinh, sv.GioiTinh,
                        sv.MaKhoa, k.TenKhoa, sv.DiemTB, sv.Email
                   FROM SinhVien sv JOIN Khoa k ON sv.MaKhoa = k.MaKhoa
                   WHERE sv.MaKhoa = @MaKhoa
                   ORDER BY sv.HoTen";
            List<SinhVienDTO> ds = new List<SinhVienDTO>();
            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10).Value = maKhoa;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ds.Add(MapRow(reader));
                    }
                }
            }
            return ds;
        }

        // Bai 4: kiem tra sinh vien co ton tai hay khong, dung de xac nhan rollback
        public bool Exists(string maSV)
        {
            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SinhVien WHERE MaSV = @MaSV", conn))
            {
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 15).Value = maSV;
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // Bai 5: phuong thuc nhan SqlConnection va SqlTransaction tu ben ngoai de tham
        // gia vao 1 giao dich dung chung (khong tu mo/dong connection rieng).
        public void Insert(SinhVienDTO dto, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = @"INSERT INTO SinhVien(MaSV,HoTen,NgaySinh,GioiTinh,MaKhoa,DiemTB,Email)
                           VALUES(@MaSV,@HoTen,@NgaySinh,@GioiTinh,@MaKhoa,@DiemTB,@Email)";
            using (SqlCommand cmd = new SqlCommand(sql, conn, tx))
            {
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 15).Value = dto.MaSV;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = dto.HoTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dto.NgaySinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = dto.GioiTinh;
                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10).Value = dto.MaKhoa;
                cmd.Parameters.Add("@DiemTB", SqlDbType.Decimal).Value = dto.DiemTB;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value =
                    string.IsNullOrWhiteSpace(dto.Email) ? (object)DBNull.Value : dto.Email;
                cmd.ExecuteNonQuery();
            }
        }

        private static SinhVienDTO MapRow(SqlDataReader reader)
        {
            return new SinhVienDTO
            {
                MaSV = reader["MaSV"].ToString(),
                HoTen = reader["HoTen"].ToString(),
                NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                GioiTinh = Convert.ToBoolean(reader["GioiTinh"]),
                MaKhoa = reader["MaKhoa"].ToString(),
                TenKhoa = reader["TenKhoa"].ToString(),
                DiemTB = Convert.ToDecimal(reader["DiemTB"]),
                Email = reader["Email"] == DBNull.Value ? "" : reader["Email"].ToString()
            };
        }
    }
}
