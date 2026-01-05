using System.Data;
using System.Data.SQLite;
using System.Reflection;

namespace PlannerShop.Data
{
    struct DBUtility
    {        
        public static DataTable GetDBData(string queryString, IDictionary<string, object?>? parameters)
        {
            DataTable dt = new();
            var location = Assembly.GetEntryAssembly();
            if (location != null)
            {
                string connString = @"Data Source='" + Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db'";
                using (SQLiteConnection conn = new(connString))
                {
                    using (var cmd = new SQLiteCommand(queryString, conn))
                    {
                        if (parameters != null)
                        {
                            foreach (var p in parameters)
                                cmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                        }

                        conn.Open();
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                }
            }
            return dt;
        }

        public static void SetDBData(string queryString, IDictionary<string, object?> parameters)
        {
            var location = Assembly.GetEntryAssembly();
            if (location != null)
            {
                string connString = @"Data Source='" + Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db'";
                using (SQLiteConnection conn = new(connString))
                {
                    using (var cmd = new SQLiteCommand(queryString, conn))
                    {
                        foreach (var p in parameters)
                            cmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}