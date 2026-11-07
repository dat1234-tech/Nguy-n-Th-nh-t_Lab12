using System.Collections.Generic;
using System.Data.SqlClient;
using Lab12.DTO;

namespace Lab12.DAL
{
    public class HocPhanDAL
    {
        public List<HocPhanDTO> GetAll()
        {
            List<HocPhanDTO> ds = new List<HocPhanDTO>();
            using (SqlConnection conn = DbConnectionFactory.Create())
            using (SqlCommand cmd = new SqlCommand("SELECT MaHP, TenHP, SoTinChi FROM HocPhan ORDER BY MaHP", conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ds.Add(new HocPhanDTO(
                            reader["MaHP"].ToString(),
                            reader["TenHP"].ToString(),
                            System.Convert.ToInt32(reader["SoTinChi"])));
                    }
                }
            }
            return ds;
        }
    }
}
