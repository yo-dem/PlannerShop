using System.Data;
using System.Globalization;

namespace PlannerShop.Data
{
    internal struct ModelStatistiche
    {
        public static DataTable GetAllAcquistiAttivi()
        {
            return DBUtility.GetDBData(
                @"SELECT a.*, c.NOME AS NOME_CLIENTE, c.COGNOME AS COGNOME_CLIENTE
                  FROM TACQUISTI a
                  LEFT JOIN TCLIENTI c ON a.IDCLIENTE = c.IDCLIENTE
                  WHERE a.ISDELETED='FALSE'
                  ORDER BY a.IDACQUISTO DESC",
                null);
        }

        public static DataTable GetAllProdotti()
        {
            return DBUtility.GetDBData("SELECT * FROM TPRODOTTI", null);
        }

        public static decimal ParseEuro(object? val)
        {
            if (val == null || val == DBNull.Value) return 0m;
            string s = val.ToString()!
                .Replace("€", "")
                .Replace(" ", "")
                .Trim();
            // Formato italiano: virgola = decimale, punto = migliaia (es. "1.500,50").
            // Rimuovere i punti (migliaia) e sostituire la virgola con il punto prima del parse.
            if (s.Contains(','))
            {
                string normalized = s.Replace(".", "").Replace(",", ".");
                if (decimal.TryParse(normalized, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal r))
                    return r;
            }
            if (decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal r2))
                return r2;
            return 0m;
        }

        public static DateTime? ParseData(string? dateStr)
        {
            if (string.IsNullOrWhiteSpace(dateStr)) return null;
            string s = dateStr.Trim();

            string[] fmts = {
                "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy",
                "yyyy-MM-dd", "yyyy-MM-dd HH:mm:ss", "dd/MM/yyyy HH:mm:ss",
                "M/d/yyyy HH:mm:ss", "d/M/yyyy HH:mm:ss"
            };

            if (DateTime.TryParseExact(s, fmts, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime r))
                return r;
            if (DateTime.TryParse(s, new CultureInfo("it-IT"), DateTimeStyles.None, out r))
                return r;
            if (DateTime.TryParse(s, CultureInfo.InvariantCulture, DateTimeStyles.None, out r))
                return r;
            return null;
        }
    }
}
