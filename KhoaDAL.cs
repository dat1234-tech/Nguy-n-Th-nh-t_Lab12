using System.Collections.Generic;
using System.Data.SqlClient;
using Lab12.DTO;

namespace Lab12.DAL
{
    public class KhoaDAL
    {
        public List<KhoaDTO> GetAll()
        {
            List<KhoaDTO> ds = new List<KhoaDTO>();
            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand("SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY TenKhoa", conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ds.Add(new KhoaDTO(reader["MaKhoa"].ToString(), reader["TenKhoa"].ToString()));
                    }
                }
            }
            return ds;
        }
    }
}
