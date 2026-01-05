using System.Data;

namespace PlannerShop.Data
{
    internal struct ModelOpzioni
    {
        public static string GetOpzione(string key)
        {
            string sql = @"SELECT VALUE FROM TOpzioni WHERE KEY = @key";

            var parameters = new Dictionary<string, object?>()
            {
                { "@key", key }
            };

            DataTable dt = DBUtility.GetDBData(sql, parameters);

            if (dt.Rows.Count == 0)
                return string.Empty;

            return dt.Rows[0]["VALUE"]?.ToString() ?? string.Empty;
        }

        public static void SetOpzione(string key, string value)
        {
            string sql = @"
                UPDATE TOpzioni
                SET VALUE = @value
                WHERE KEY = @key;

                INSERT INTO TOpzioni (KEY, VALUE)
                SELECT @key, @value
                WHERE NOT EXISTS (
                    SELECT 1 FROM TOpzioni WHERE KEY = @key
                );
                ";

            var parameters = new Dictionary<string, object?>()
            {
                { "@key", key },
                { "@value", value }
            };

            DBUtility.SetDBData(sql, parameters);
        }
    }
}
