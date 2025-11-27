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

        public static DataTable getDBData(string queryString, IDictionary<string, object?> parameters)
        {
            DataTable dt = new DataTable();
            var location = Assembly.GetEntryAssembly();
            if (location != null)
            {
                string connString = @"Data Source='" + Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db'";
                using (SQLiteConnection conn = new SQLiteConnection(connString))
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

        public static void setDBData(string queryString)
        {
            var location = Assembly.GetEntryAssembly();
            if (location != null)
            {
                string connString = @"Data Source='" + Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db'";
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    using (var command = new SQLiteCommand(queryString, conn))
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void setDBData(string queryString, IDictionary<string, object?> parameters)
        {
            var location = Assembly.GetEntryAssembly();
            if (location != null)
            {
                string connString = @"Data Source='" + Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db'";
                using (SQLiteConnection conn = new SQLiteConnection(connString))
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