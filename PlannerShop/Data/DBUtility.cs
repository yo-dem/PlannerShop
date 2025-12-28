using System.Data;
using System.Data.SQLite;
using System.Reflection;

namespace PlannerShop.Data
{
    struct DBUtility
    {
        public static DataTable GetDBData(string queryString)
        {
            DataTable dt = new();
            var location = Assembly.GetEntryAssembly();
            if (location != null)
            {
                string connString = @"Data Source='" + Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db'";
                using (SQLiteConnection conn = new(connString))
                {
                    using (var command = new SQLiteCommand(queryString, conn))
                    {
                        conn.Open();
                        using (SQLiteDataReader reader = command.ExecuteReader())
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

        public static DataTable GetDBData(string queryString, IDictionary<string, object?> parameters)
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
                        foreach (var p in parameters)
                            cmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);

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

        public static void SetDBData(string queryString)
        {
            var location = Assembly.GetEntryAssembly();
            if (location != null)
            {
                string connString = @"Data Source='" + Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db'";
                using (SQLiteConnection conn = new(connString))
                {
                    using (var command = new SQLiteCommand(queryString, conn))
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
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

        public static void ExecuteInTransaction(Action<SQLiteConnection, SQLiteTransaction> action)
        {
            var location = Assembly.GetEntryAssembly();
            if (location == null) return;

            string connString = @"Data Source='" + Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db'";
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        action(conn, tran);
                        tran.Commit();
                    }
                    catch
                    {
                        try { tran.Rollback(); } catch { }
                        throw;
                    }
                }
            }
        }
    }
}