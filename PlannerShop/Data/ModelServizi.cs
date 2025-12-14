using System.Data;
using System.Globalization;

namespace PlannerShop.Data
{
    internal struct ModelServizi
    {
        
        public static DataTable getServizioById(string idServizio)
        {
            return DBUtility.getDBData("SELECT * FROM TSERVIZI WHERE IDSERVIZIO=@id", new Dictionary<string, object?> { { "@id", idServizio } });
        }

        public static DataTable getServizi()
        {
            return DBUtility.getDBData("SELECT * FROM TSERVIZI ORDER BY IDSERVIZIO DESC");
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

            DBUtility.setDBData(sql, parameters);
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

            DBUtility.setDBData(sql, parameters);
        }

        public static void deleteServizio(string idServizio)
        {
            string sql = @"DELETE FROM TSERVIZI WHERE IDSERVIZIO=@idServ";
            DBUtility.setDBData(sql, new Dictionary<string, object?> { { "@idServ", idServizio } });
        }
    }
}