using System.Data;
using System.Data.SQLite;
using System.Reflection;
using System.Globalization;

namespace PlannerShop.Data
{
    internal struct DBStats
    {
        private static double ExecuteScalarDouble(string query)
        {
            double result = 0;
            var location = Assembly.GetEntryAssembly();
            if (location != null)
            {
                string connString = @"Data Source='" + Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db'";
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        conn.Open();
                        object value = command.ExecuteScalar();
                        if (value != DBNull.Value && value != null)
                        {
                            double.TryParse(Convert.ToString(value, CultureInfo.InvariantCulture), NumberStyles.Any, CultureInfo.InvariantCulture, out result);
                        }
                    }
                }
            }
            return result;
        }

        private static int ExecuteScalarInt(string query)
        {
            double val = ExecuteScalarDouble(query);
            return Convert.ToInt32(Math.Round(val));
        }

        private static int GetCount(string tableName)
        {
            return ExecuteScalarInt($"SELECT COUNT(*) FROM {tableName}");
        }

        private static int GetSum(string column, string table)
        {
            return ExecuteScalarInt($"SELECT SUM({column}) FROM {table}");
        }

        private static string GetMostCommonValue(string column, string table)
        {
            DataTable dt = DBUtility.getDBData($"SELECT {column}, COUNT(*) as Count FROM {table} GROUP BY {column} ORDER BY Count DESC LIMIT 1");
            return dt.Rows.Count > 0 ? dt.Rows[0][column].ToString() : "N/A";
        }

        public static int GetTotalProducts() => GetCount("TPRODOTTI");
        public static int GetTotalSuppliers() => GetCount("TFORNITORI");
        public static int GetTotalQuantity() => GetSum("QNT", "TPRODOTTI");

        public static int GetTotalInventoryValueNet()
        {
            string q = @"SELECT SUM(QNT * CAST(REPLACE(PREZZO_NETTO, '€', '') AS REAL)) FROM TPRODOTTI";
            return ExecuteScalarInt(q);
        }

        public static int GetTotalInventoryValueGross()
        {
            string q = @"SELECT SUM(QNT * CAST(REPLACE(PREZZO_IVATO, '€', '') AS REAL)) FROM TPRODOTTI";
            return ExecuteScalarInt(q);
        }

        public static string GetMostCommonBrand() => GetMostCommonValue("MARCA", "TPRODOTTI");
    }
}