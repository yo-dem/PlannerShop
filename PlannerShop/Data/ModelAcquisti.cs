using System.Data;
using System.Globalization;

namespace PlannerShop.Data
{
    internal struct ModelAcquisti
    {
        public static DataTable getAcquistoById(string idAcquisto)
        {
            return DBUtility.getDBData("SELECT * FROM TACQUISTI WHERE IDACQUISTO=@id", new Dictionary<string, object?> { { "@id", idAcquisto } });
        }

        public static DataTable getAcquistiByIdClienteAndTimestamp(string idCliente, string timeStamp)
        {
            return DBUtility.getDBData("SELECT * FROM TACQUISTI WHERE IDCLIENTE=@idCliente AND TIMESTAMP=@ts ORDER BY IDACQUISTO DESC",
                new Dictionary<string, object?> { { "@idCliente", idCliente }, { "@ts", timeStamp } });
        }

        public static DataTable getAcquistiByIdCliente(string idCliente)
        {
            return DBUtility.getDBData("SELECT * FROM TACQUISTI WHERE IDCLIENTE=@idCliente ORDER BY IDACQUISTO DESC",
                new Dictionary<string, object?> { { "@idCliente", idCliente } });
        }

        public static DataTable getAcquistiByIdClienteAndProductId(string idCliente, string idProdotto)
        {
            return DBUtility.getDBData("SELECT * FROM TACQUISTI WHERE IDCLIENTE=@idCliente AND IDPRODOTTO=@idProdotto ORDER BY IDACQUISTO DESC",
                new Dictionary<string, object?> { { "@idCliente", idCliente }, { "@idProdotto", idProdotto } });
        }

        public static DataTable searchAcquisti(string searchTerm, string idCliente)
        {
            string sql = @"SELECT * FROM TACQUISTI
                           WHERE ( MARCA LIKE @search OR NOME LIKE @search OR DESCRIZIONE LIKE @search OR ALIQUOTA LIKE @search OR QNT LIKE @search OR PREZZO_NETTO LIKE @search OR PREZZO_IVATO LIKE @search OR PREZZO_VENDITA LIKE @search OR NOTE LIKE @search )
                           AND IDCLIENTE=@idCliente
                           ORDER BY IDACQUISTO DESC";
            var parameters = new Dictionary<string, object?>()
            {
                { "@search", "%" + searchTerm + "%" },
                { "@idCliente", idCliente }
            };
            return DBUtility.getDBData(sql, parameters);
        }

        public static void addAcquisto(
            string marca,
            string nome,
            string descrizione,
            string qnt,
            string prezzoNetto,
            string prezzoIvato,
            string prezzoVendita,
            string totale,
            string sconto,
            string dataAcquisto,
            string idCliente,
            string idProdotto,
            string idServizio,
            string aliquota,
            string note,
            string timeStamp)
        {

            string sql = @"INSERT INTO TACQUISTI (MARCA,NOME,DESCRIZIONE,QNT,PREZZO_NETTO,PREZZO_IVATO,PREZZO_VENDITA,TOTALE,SCONTO,DATA,IDCLIENTE,IDPRODOTTO,IDSERVIZIO,ALIQUOTA,NOTE,TIMESTAMP)
                           VALUES(@marca,@nome,@descr,@qnt,@pn,@pi,@pv,@pt,@sconto,@data,@idCliente,@idProd,@idServ,@aliq,@note,@ts)";

            object? idProdParam = string.IsNullOrWhiteSpace(idProdotto) ? DBNull.Value : int.Parse(idProdotto);

            object? idServParam = string.IsNullOrWhiteSpace(idServizio) ? DBNull.Value : int.Parse(idServizio);

            var parameters = new Dictionary<string, object?>()
            {
                { "@marca", marca },
                { "@nome", nome },
                { "@descr", descrizione },
                { "@qnt", qnt },
                { "@pn", prezzoNetto },
                { "@pi", prezzoIvato },
                { "@pv", prezzoVendita },
                { "@pt", totale },
                { "@sconto", sconto },
                { "@data", dataAcquisto },
                { "@idCliente", int.Parse(idCliente) },
                { "@idProd", idProdParam },
                { "@idServ", idServParam },
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