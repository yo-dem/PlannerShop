using System.Data;

namespace PlannerShop.Data
{
    internal struct ModelClienti
    {
        public static DataTable getClienteById(string idCliente)
        {
            return DBUtility.getDBData("SELECT * FROM TCLIENTI WHERE IDCLIENTE=@id", new Dictionary<string, object?> { { "@id", idCliente } });
        }

        public static DataTable getClienti()
        {
            return DBUtility.getDBData("SELECT * FROM TCLIENTI ORDER BY IDCLIENTE DESC");
        }

        public static void addCliente(
            string nome,
            string cognome,
            string compleanno,
            string indirizzo,
            string telefono,
            string email,
            string note)
        {
            string sql = @"INSERT INTO TCLIENTI (NOME, COGNOME, COMPLEANNO, INDIRIZZO, TELEFONO, EMAIL, NOTE)
                           VALUES (@nome,@cognome,@data,@indirizzo,@tel,@email,@note)";

            var parameters = new Dictionary<string, object?>()
            {
                { "@nome", nome },
                { "@cognome", cognome },
                { "@data", compleanno },
                { "@indirizzo", indirizzo },
                { "@tel", telefono },
                { "@email", email },
                { "@note", note }
            };

            DBUtility.setDBData(sql, parameters);
        }

        public static void editCliente(
            string idCliente,
            string nome,
            string cognome,
            string compleanno,
            string indirizzo,
            string telefono,
            string email,
            string note)
        {
            string sql = @"UPDATE TCLIENTI SET NOME=@nome, COGNOME=@cognome, COMPLEANNO=@data, INDIRIZZO=@indirizzo,
                           TELEFONO=@tel, EMAIL=@email, NOTE=@note
                           WHERE IDCLIENTE=@id";

            var parameters = new Dictionary<string, object?>()
            {
                { "@nome", nome },
                { "@cognome", cognome },
                { "@data", compleanno },
                { "@indirizzo", indirizzo },
                { "@tel", telefono },
                { "@email", email },
                { "@note", note },
                { "@id", idCliente }
            };

            DBUtility.setDBData(sql, parameters);
        }

        public static void deleteCliente(string? idCliente)
        {
            DBUtility.setDBData("DELETE FROM TCLIENTI WHERE IDCLIENTE=@id", new Dictionary<string, object?> { { "@id", idCliente } });
        }
    }
}