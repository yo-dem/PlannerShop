using System.Data;
using System.Data.SQLite;
using System.Reflection;

namespace PlannerShop.Data
{
    struct DBUtility
    {
        public static DataTable getDBData(string queryString)
        {
            DataTable dt = new DataTable();
            var location = Assembly.GetEntryAssembly();
            if (location != null)
            {
                string connString = @"Data Source='" + Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db'";
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    SQLiteCommand command = new SQLiteCommand("", conn);
                    command.CommandText = queryString;
                    conn.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
            return dt;
        }
        public static void setDBData(string queryString)
        {
            var location = Assembly.GetEntryAssembly();
            if (location != null)
            {
                string connString = @"Data Source='" + Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db'";
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    SQLiteCommand command = new SQLiteCommand("", conn);
                    command.CommandText = queryString;
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
