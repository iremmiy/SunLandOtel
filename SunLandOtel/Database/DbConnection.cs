using System;
using System.Data; // Bunu da ekleyelim, lazım olacak
using System.Data.SqlClient;

namespace SunLandOtel.Database // Buradaki SunLandOtel proje adınla aynı mı?
{
    public class DbConnection
    {
        private static string connectionString = @"Server=localhost\SQLEXPRESS;Database=SunLandOtel;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}