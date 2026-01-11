using System.Data;

namespace PlannerShop.Data
{
    internal struct ModelClienti
    {
        public static DataTable getClienteById(string idCliente)
        {
            return DBUtility.GetDBData("SELECT * FROM TCLIENTI WHERE IDCLIENTE=@id", new Dictionary<string, object?> { { "@id", idCliente } });
        }

        public static DataTable getClienti()
        {
            return DBUtility.GetDBData("SELECT * FROM TCLIENTI ORDER BY IDCLIENTE DESC", null);
        }

        public static DataTable searchClienti(string searchTerm)
        {
            string sql = @"SELECT * FROM TCLIENTI
                           WHERE NOME LIKE @term OR COGNOME LIKE @term OR INDIRIZZO LIKE @term OR TELEFONO LIKE @term OR EMAIL LIKE @term
                           ORDER BY IDCLIENTE DESC";
            var parameters = new Dictionary<string, object?>()
            {
                { "@term", "%" + searchTerm + "%" }
            };
            return DBUtility.GetDBData(sql, parameters);
        }

        public static DataTable searchBirthdayClienti()
        {
            return DBUtility.GetDBData(@"SELECT * FROM TCLIENTI WHERE
                    SUBSTR(TRIM(COMPLEANNO), 4, 2) = STRFTIME('%m', 'now')
                    ORDER BY
                   CAST(SUBSTR(TRIM(COMPLEANNO), 1, 2) AS INTEGER),
                    IDCLIENTE DESC", null);
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

            DBUtility.SetDBData(sql, parameters);
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

            DBUtility.SetDBData(sql, parameters);
        }

        public static void deleteCliente(string? idCliente)
        {
            DBUtility.SetDBData("DELETE FROM TCLIENTI WHERE IDCLIENTE=@id", new Dictionary<string, object?> { { "@id", idCliente } });
        }

    }
}