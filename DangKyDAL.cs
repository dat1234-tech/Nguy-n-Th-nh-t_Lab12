using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Lab12.DTO;

namespace Lab12.DAL
{
    public class DangKyDAL
    {
        // Bai 2: lay danh sach dang ky cua 1 sinh vien, JOIN de lay ten hoc phan
        public List<DangKyDTO> GetBySinhVien(string maSV)
        {
            string sql = @"SELECT dk.MaSV, dk.MaHP, hp.TenHP, hp.SoTinChi, dk.HocKy, dk.Diem
                     FROM DangKy dk
                     JOIN HocPhan hp ON dk.MaHP = hp.MaHP
                     WHERE dk.MaSV = @MaSV
                     ORDER BY dk.HocKy, hp.TenHP";
            List<DangKyDTO> ds = new List<DangKyDTO>();
            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 15).Value = maSV;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ds.Add(new DangKyDTO
                        {
                            MaSV = reader["MaSV"].ToString(),
                            MaHP = reader["MaHP"].ToString(),
                            TenHP = reader["TenHP"].ToString(),
                            SoTinChi = Convert.ToInt32(reader["SoTinChi"]),
                            HocKy = Convert.ToInt32(reader["HocKy"]),
                            Diem = reader["Diem"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(reader["Diem"])
                        });
                    }
                }
            }
            return ds;
        }

        // Bai 5: nhan SqlConnection va SqlTransaction tu ben ngoai - dung code mau
        // dung het trong de bai (giup tai su dung o ca giao dich don va giao dich nhieu buoc).
        public void InsertEnrollment(DangKyDTO dto, SqlConnection conn, SqlTransaction tx)
        {
            const string sql = @"INSERT INTO DangKy(MaSV,MaHP,HocKy,Diem)
                           VALUES(@MaSV,@MaHP,@HocKy,@Diem)";
            using (SqlCommand cmd = new SqlCommand(sql, conn, tx))
            {
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 15).Value = dto.MaSV;
                cmd.Parameters.Add("@MaHP", SqlDbType.VarChar, 10).Value = dto.MaHP;
                cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = dto.HocKy;
                cmd.Parameters.Add("@Diem", SqlDbType.Decimal).Value =
                    dto.Diem.HasValue ? (object)dto.Diem.Value : DBNull.Value;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
