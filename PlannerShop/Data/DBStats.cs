using System.Data;
using System.Data.SQLite;
using System.Reflection;

namespace PlannerShop.Data
{
    internal struct DBStats
    {
        private static int GetCount(string tableName)
        {
            return ExecuteScalarQuery($"SELECT COUNT(*) FROM {tableName}");
        }

        private static int GetSum(string column, string table)
        {
            return ExecuteScalarQuery($"SELECT SUM({column}) FROM {table}");
        }

        private static string GetMostCommonValue(string column, string table)
        {
            DataTable dt = DBUtility.getDBData($"SELECT {column}, COUNT(*) as Count FROM {table} GROUP BY {column} ORDER BY Count DESC LIMIT 1");
            return dt.Rows.Count > 0 ? dt.Rows[0][column].ToString() : "N/A";
        }

        private static int ExecuteScalarQuery(string query)
        {
            int result = 0;
            var location = Assembly.GetEntryAssembly();
            if (location != null)
            {
                string connString = @"Data Source='" + Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db'";
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    SQLiteCommand command = new SQLiteCommand(query, conn);
                    conn.Open();
                    object value = command.ExecuteScalar();
                    if (value != DBNull.Value && value != null)
                    {
                        result = Convert.ToInt32(value);
                    }
                }
            }
            return result;
        }

        public static int GetTotalProducts() => GetCount("TPRODOTTI");
        public static int GetTotalSuppliers() => GetCount("TFORNITORI");
        public static int GetTotalQuantity() => GetSum("QNT", "TPRODOTTI");
        public static int GetTotalInventoryValueNet() => GetSum("QNT * PREZZO_NETTO", "TPRODOTTI");
        public static int GetTotalInventoryValueGross() => GetSum("QNT * PREZZO_IVATO", "TPRODOTTI");
        public static string GetMostCommonBrand() => GetMostCommonValue("MARCA", "TPRODOTTI");
    }
}
