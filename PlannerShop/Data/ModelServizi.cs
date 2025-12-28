using System.Data;
using System.Globalization;

namespace PlannerShop.Data
{
    internal struct ModelServizi
    {
        
        public static DataTable getServizioById(string idServizio)
        {
            return DBUtility.GetDBData("SELECT * FROM TSERVIZI WHERE IDSERVIZIO=@id", new Dictionary<string, object?> { { "@id", idServizio } });
        }

        public static DataTable getServizi()
        {
            return DBUtility.GetDBData("SELECT * FROM TSERVIZI ORDER BY IDSERVIZIO DESC");
        }

        public static DataTable searchServizi(string searchTerm)
        {
            string sql = @"SELECT * FROM TSERVIZI
                           WHERE NOME LIKE @search OR DESCRIZIONE LIKE @search OR ALIQUOTA LIKE @search OR PREZZO_NETTO LIKE @search OR PREZZO_IVATO LIKE @search OR PREZZO_VENDITA LIKE @search OR NOTE LIKE @search
                           ORDER BY IDSERVIZIO DESC";
            var parameters = new Dictionary<string, object?>()
            {
                { "@search", "%" + searchTerm + "%" }
            };
            return DBUtility.GetDBData(sql, parameters);
        }

        public static void addServizio(
            string data,
            string nome,
            string descrizione,
            string aliquota,
            string prezzoNetto,
            string prezzoIvato,
            string prezzoVendita,
            string note,
            string? idServizio = null)
        {

            string sql = @"INSERT INTO TSERVIZI (DATA,NOME,DESCRIZIONE,ALIQUOTA,PREZZO_NETTO,PREZZO_IVATO,PREZZO_VENDITA,NOTE,IDSERVIZIO)
                           VALUES(@data,@nome,@descr,@aliq,@pn,@pi,@pv,@note,@idServ)";

            var parameters = new Dictionary<string, object?>()
            {
                { "@data", data },
                { "@nome", nome },
                { "@descr", descrizione },
                { "@aliq", aliquota },
                { "@pn", prezzoNetto },
                { "@pi", prezzoIvato },
                { "@pv", prezzoVendita },
                { "@note", note },
                { "@idServ", idServizio ?? (object?)DBNull.Value }
            };

            DBUtility.SetDBData(sql, parameters);
        }

        public static void editServizio(
            string idServizio,
            string data,
            string nome,
            string descrizione,
            string aliquota,
            string prezzoNetto,
            string prezzoIvato,
            string prezzoVendita,
            string note)
        {
            
            string sql = @"UPDATE TSERVIZI SET DATA=@data, NOME=@nome, DESCRIZIONE=@descr, ALIQUOTA=@aliq, PREZZO_NETTO=@pn, PREZZO_IVATO=@pi, PREZZO_VENDITA=@pv, NOTE=@note
                           WHERE IDSERVIZIO=@idServ";

            var parameters = new Dictionary<string, object?>()
            {
                { "@data", data },
                { "@nome", nome },
                { "@descr", descrizione },
                { "@aliq", aliquota },
                { "@pn", prezzoNetto },
                { "@pi", prezzoIvato },
                { "@pv", prezzoVendita },
                { "@note", note },
                { "@idServ", idServizio }
            };

            DBUtility.SetDBData(sql, parameters);
        }

        public static void deleteServizio(string idServizio)
        {
            string sql = @"DELETE FROM TSERVIZI WHERE IDSERVIZIO=@idServ";
            DBUtility.SetDBData(sql, new Dictionary<string, object?> { { "@idServ", idServizio } });
        }
    }
}