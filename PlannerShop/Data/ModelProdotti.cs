using System.Data;
using System.Globalization;

namespace PlannerShop.Data
{
    internal struct ModelProdotti
    {
        static double ParsePriceToDouble(string? price)
        {
            if (string.IsNullOrWhiteSpace(price)) return 0.0;
            var cleaned = price.Replace("€", "").Trim();
            cleaned = cleaned.Replace(" ", "");
            // Try italian style
            if (double.TryParse(cleaned, NumberStyles.Any, CultureInfo.GetCultureInfo("it-IT"), out double v))
                return v;
            // Try invariant with dot
            cleaned = cleaned.Replace(",", ".");
            double.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out v);
            return v;
        }

        public static DataTable getProdottoById(string idProdotto)
        {
            return DBUtility.getDBData("SELECT * FROM TPRODOTTI WHERE IDPRODOTTO=@id", new Dictionary<string, object?> { { "@id", idProdotto } });
        }

        public static DataTable getProdotti()
        {
            return DBUtility.getDBData("SELECT * FROM TPRODOTTI ORDER BY IDPRODOTTO DESC");
        }

        public static void addProdotto(
            string data,
            string marca,
            string descrizione,
            string aliquota,
            string qnt,
            string prezzoNetto,
            string prezzoIvato,
            string note,
            string? idProdotto = null)
        {
            double pn = ParsePriceToDouble(prezzoNetto);
            double pi = ParsePriceToDouble(prezzoIvato);

            string sql = @"INSERT INTO TPRODOTTI (DATA,MARCA,DESCRIZIONE,ALIQUOTA,QNT,PREZZO_NETTO,PREZZO_IVATO,NOTE,IDPRODOTTO)
                           VALUES(@data,@marca,@descr,@aliq,@qnt,@pn,@pi,@note,@idProd)";

            var parameters = new Dictionary<string, object?>()
            {
                { "@data", data },
                { "@marca", marca },
                { "@descr", descrizione },
                { "@aliq", aliquota },
                { "@qnt", qnt },
                { "@pn", pn },
                { "@pi", pi },
                { "@note", note },
                { "@idProd", idProdotto ?? (object?)DBNull.Value }
            };

            DBUtility.setDBData(sql, parameters);
        }

        public static void editProdotto(
            string idProdotto,
            string data,
            string marca,
            string descrizione,
            string aliquota,
            string qnt,
            string prezzoNetto,
            string prezzoIvato,
            string note)
        {
            double pn = ParsePriceToDouble(prezzoNetto);
            double pi = ParsePriceToDouble(prezzoIvato);

            string sql = @"UPDATE TPRODOTTI SET DATA=@data, MARCA=@marca, DESCRIZIONE=@descr, ALIQUOTA=@aliq, QNT=@qnt, PREZZO_NETTO=@pn, PREZZO_IVATO=@pi, NOTE=@note
                           WHERE IDPRODOTTO=@idProd";

            var parameters = new Dictionary<string, object?>()
            {
                { "@data", data },
                { "@marca", marca },
                { "@descr", descrizione },
                { "@aliq", aliquota },
                { "@qnt", qnt },
                { "@pn", pn },
                { "@pi", pi },
                { "@note", note },
                { "@idProd", idProdotto }
            };

            DBUtility.setDBData(sql, parameters);
        }

        public static void updateQuantity(string idProdotto, int newQnt)
        {
            string sql = @"UPDATE TPRODOTTI SET QNT = @newQnt WHERE IDPRODOTTO = @id";
            DBUtility.setDBData(sql, new Dictionary<string, object?> { { "@newQnt", newQnt }, { "@id", idProdotto } });
        }

        public static void deleteProdotto(string? idProdotto)
        {
            string sql = @"DELETE FROM TPRODOTTI WHERE IDPRODOTTO=@id";
            DBUtility.setDBData(sql, new Dictionary<string, object?> { { "@id", idProdotto } });
        }
    }
}