using System.Data.SqlClient;

namespace Lab12.DAL
{
    public static class DbConnectionFactory
    {
        // Doi "MSI\\SQLEXPRESS" thanh dung ten server tren may ban
        private const string ConnectionString =
            @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True";

        public static SqlConnection Create()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
