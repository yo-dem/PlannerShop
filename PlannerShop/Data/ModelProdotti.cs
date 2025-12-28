using System.Data;
using System.Globalization;

namespace PlannerShop.Data
{
    internal struct ModelProdotti
    {
        
        public static DataTable getProdottoById(string idProdotto)
        {
            return DBUtility.GetDBData("SELECT * FROM TPRODOTTI WHERE IDPRODOTTO=@id", new Dictionary<string, object?> { { "@id", idProdotto } });
        }

        public static DataTable getProdotti()
        {
            return DBUtility.GetDBData("SELECT * FROM TPRODOTTI ORDER BY IDPRODOTTO DESC");
        }

        public static DataTable getExistingProdotti()
        {
            return DBUtility.GetDBData("SELECT * FROM TPRODOTTI WHERE QNT <> '0' ORDER BY IDPRODOTTO DESC");
        }

        public static DataTable searchProdotti(string searchTerm)
        {
            string sql = @"SELECT * FROM TPRODOTTI
                           WHERE MARCA LIKE @search OR DESCRIZIONE LIKE @search OR ALIQUOTA LIKE @search OR QNT LIKE @search OR PREZZO_NETTO LIKE @search OR PREZZO_IVATO LIKE @search OR PREZZO_VENDITA LIKE @search OR NOTE LIKE @search
                           ORDER BY IDPRODOTTO DESC";
            var parameters = new Dictionary<string, object?>()
            {
                { "@search", "%" + searchTerm + "%" }
            };
            return DBUtility.GetDBData(sql, parameters);
        }

        public static void addProdotto(
            string data,
            string marca,
            string descrizione,
            string aliquota,
            string qnt,
            string prezzoNetto,
            string prezzoIvato,
            string prezzoVendita,
            string note,
            string? idProdotto = null)
        {

            string sql = @"INSERT INTO TPRODOTTI (DATA,MARCA,DESCRIZIONE,ALIQUOTA,QNT,PREZZO_NETTO,PREZZO_IVATO,PREZZO_VENDITA,NOTE,IDPRODOTTO)
                           VALUES(@data,@marca,@descr,@aliq,@qnt,@pn,@pi,@pv,@note,@idProd)";

            var parameters = new Dictionary<string, object?>()
            {
                { "@data", data },
                { "@marca", marca },
                { "@descr", descrizione },
                { "@aliq", aliquota },
                { "@qnt", qnt },
                { "@pn", prezzoNetto },
                { "@pi", prezzoIvato },
                { "@pv", prezzoVendita },
                { "@note", note },
                { "@idProd", idProdotto ?? (object?)DBNull.Value }
            };

            DBUtility.SetDBData(sql, parameters);
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
            string prezzoVendita,
            string note)
        {
            
            string sql = @"UPDATE TPRODOTTI SET DATA=@data, MARCA=@marca, DESCRIZIONE=@descr, ALIQUOTA=@aliq, QNT=@qnt, PREZZO_NETTO=@pn, PREZZO_IVATO=@pi, PREZZO_VENDITA=@pv, NOTE=@note
                           WHERE IDPRODOTTO=@idProd";

            var parameters = new Dictionary<string, object?>()
            {
                { "@data", data },
                { "@marca", marca },
                { "@descr", descrizione },
                { "@aliq", aliquota },
                { "@qnt", qnt },
                { "@pn", prezzoNetto },
                { "@pi", prezzoIvato },
                { "@pv", prezzoVendita },
                { "@note", note },
                { "@idProd", idProdotto }
            };

            DBUtility.SetDBData(sql, parameters);
        }

        public static void updateQuantity(string idProdotto, int newQnt)
        {
            string sql = @"UPDATE TPRODOTTI SET QNT = @newQnt WHERE IDPRODOTTO = @id";
            DBUtility.SetDBData(sql, new Dictionary<string, object?> { { "@newQnt", newQnt }, { "@id", idProdotto } });
        }

        public static void deleteProdotto(string? idProdotto)
        {
            string sql = @"DELETE FROM TPRODOTTI WHERE IDPRODOTTO=@id";
            DBUtility.SetDBData(sql, new Dictionary<string, object?> { { "@id", idProdotto } });
        }
    }
}