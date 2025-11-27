using System.Data;
using System.Globalization;

namespace PlannerShop.Data
{
    internal struct ModelAcquisti
    {
        static double ParsePriceToDouble(string? price)
        {
            if (string.IsNullOrWhiteSpace(price)) return 0.0;
            var cleaned = price.Replace("€", "").Trim();
            cleaned = cleaned.Replace(" ", "");
            if (double.TryParse(cleaned, NumberStyles.Any, CultureInfo.GetCultureInfo("it-IT"), out double v))
                return v;
            cleaned = cleaned.Replace(",", ".");
            double.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out v);
            return v;
        }

        public static DataTable getAcquistoById(string idAcquisto)
        {
            return DBUtility.getDBData("SELECT * FROM TACQUISTI WHERE IDACQUISTO=@id", new Dictionary<string, object?> { { "@id", idAcquisto } });
        }

        public static DataTable getAcquistiByIdCliente(string idCliente, string timeStamp)
        {
            return DBUtility.getDBData("SELECT * FROM TACQUISTI WHERE IDCLIENTE=@idCliente AND TIMESTAMP=@ts ORDER BY IDACQUISTO DESC",
                new Dictionary<string, object?> { { "@idCliente", idCliente }, { "@ts", timeStamp } });
        }

        public static DataTable getAcquistiByIdClienteAndProductId(string idCliente, string idProdotto)
        {
            return DBUtility.getDBData("SELECT * FROM TACQUISTI WHERE IDCLIENTE=@idCliente AND IDPRODOTTO=@idProdotto ORDER BY IDACQUISTO DESC",
                new Dictionary<string, object?> { { "@idCliente", idCliente }, { "@idProdotto", idProdotto } });
        }

        public static void addAcquisto(
            string marca,
            string descrizione,
            string qnt,
            string prezzoNetto,
            string prezzoIvato,
            string dataAcquisto,
            string idCliente,
            string idProdotto,
            string aliquota,
            string note,
            string timeStamp)
        {
            double pn = ParsePriceToDouble(prezzoNetto);
            double pi = ParsePriceToDouble(prezzoIvato);

            string sql = @"INSERT INTO TACQUISTI (MARCA,DESCRIZIONE,QNT,PREZZO_NETTO,PREZZO_IVATO,DATA,IDCLIENTE,IDPRODOTTO,ALIQUOTA,NOTE,TIMESTAMP)
                           VALUES(@marca,@descr,@qnt,@pn,@pi,@data,@idCliente,@idProd,@aliq,@note,@ts)";

            var parameters = new Dictionary<string, object?>()
            {
                { "@marca", marca },
                { "@descr", descrizione },
                { "@qnt", qnt },
                { "@pn", pn },
                { "@pi", pi },
                { "@data", dataAcquisto },
                { "@idCliente", int.Parse(idCliente) },
                { "@idProd", int.Parse(idProdotto) },
                { "@aliq", aliquota },
                { "@note", note },
                { "@ts", timeStamp }
            };

            DBUtility.setDBData(sql, parameters);
        }

        public static void updateQuantity(string idProdotto, string idCliente, int newQnt)
        {
            string sql = @"UPDATE TACQUISTI SET QNT = @newQnt WHERE IDPRODOTTO = @idProd AND IDCLIENTE = @idClient";
            DBUtility.setDBData(sql, new Dictionary<string, object?> { { "@newQnt", newQnt }, { "@idProd", idProdotto }, { "@idClient", idCliente } });
        }

        public static void deleteAcquisto(string? idProdotto, string? idCliente)
        {
            string sql = @"DELETE FROM TACQUISTI WHERE IDPRODOTTO=@idProd AND IDCLIENTE=@idClient";
            DBUtility.setDBData(sql, new Dictionary<string, object?> { { "@idProd", idProdotto }, { "@idClient", idCliente } });
        }
    }
}