using System.Data;

namespace PlannerShop.Data
{
    internal struct ModelFornitori
    {
        public static DataTable getFornitoreById(string idFornitore)
        {
            return DBUtility.getDBData("SELECT * FROM TFORNITORI WHERE IDFORNITORE=@id", new Dictionary<string, object?> { { "@id", idFornitore } });
        }

        public static DataTable getFornitori()
        {
            return DBUtility.getDBData("SELECT * FROM TFORNITORI ORDER BY IDFORNITORE DESC");
        }

        public static void addFornitore(
            string nome,
            string indirizzo,
            string telefono,
            string email,
            string note)
        {
            string sql = @"INSERT INTO TFORNITORI (NOME,INDIRIZZO,TELEFONO,EMAIL,NOTE)
                           VALUES(@nome,@indirizzo,@tel,@email,@note)";

            var parameters = new Dictionary<string, object?>()
            {
                { "@nome", nome },
                { "@indirizzo", indirizzo },
                { "@tel", telefono },
                { "@email", email },
                { "@note", note }
            };

            DBUtility.setDBData(sql, parameters);
        }

        public static void editFornitore(
            string idFornitore,
            string nome,
            string indirizzo,
            string telefono,
            string email,
            string note)
        {
            string sql = @"UPDATE TFORNITORI SET NOME=@nome, INDIRIZZO=@indirizzo, TELEFONO=@tel, EMAIL=@email, NOTE=@note
                           WHERE IDFORNITORE=@id";

            var parameters = new Dictionary<string, object?>()
            {
                { "@nome", nome },
                { "@indirizzo", indirizzo },
                { "@tel", telefono },
                { "@email", email },
                { "@note", note },
                { "@id", idFornitore }
            };

            DBUtility.setDBData(sql, parameters);
        }

        public static void deleteFornitore(string? idFornitore)
        {
            DBUtility.setDBData("DELETE FROM TFORNITORI WHERE IDFORNITORE=@id", new Dictionary<string, object?> { { "@id", idFornitore } });
        }
    }
}