using System.Data;

namespace PlannerShop.Data
{
    internal struct ModelClienti
    {
        public static DataTable getClienteById(string idCliente)
        {
            DataTable dt = DBUtility.getDBData("SELECT * FROM 'TCLIENTI' WHERE IDCLIENTE='" + idCliente + "'");
            return dt;
        }
        
        public static DataTable getClienti()
        {
            DataTable dt = DBUtility.getDBData("SELECT * FROM 'TCLIENTI' ORDER BY IDCLIENTE DESC");
            return dt;
        }
        
        public static void addCliente(
            string nome,
            string cognome,
            string datanascita,
            string telefonoFisso,
            string telefonoMobile,
            string email,
            string indirizzo,
            string note)
        {
            nome = nome.Replace("'", "''");
            cognome = cognome.Replace("'", "''");
            datanascita = datanascita.Replace("'", "''");
            telefonoFisso = telefonoFisso.Replace("'", "''");
            telefonoMobile = telefonoMobile.Replace("'", "''");
            email = email.Replace("'", "''");
            indirizzo = indirizzo.Replace("'", "''");
            note = note.Replace("'", "''");

            string sqlComm = @"INSERT INTO TCLIENTI (NOME, COGNOME, DATA_NASCITA, INDIRIZZO, TELEFONO_FISSO, TELEFONO_MOBILE, EMAIL, NOTE) VALUES ('"
                + nome + "', '"
                + cognome + "', '"
                + datanascita + "', '"
                + indirizzo + "', '"
                + telefonoFisso + "', '"
                + telefonoMobile + "', '"
                + email + "', '"
                + note + "')";
            DBUtility.setDBData(sqlComm);
        }
        
        public static void editFornitore(
            string idFornitore,
            string nome,
            string indirizzo,
            string telefonoFisso,
            string telefonoMobile,
            string email,
            string note)
        {
            nome = nome.Replace("'", "''");
            indirizzo = indirizzo.Replace("'", "''");
            telefonoFisso = telefonoFisso.Replace("'", "''");
            telefonoMobile = telefonoMobile.Replace("'", "''");
            email = email.Replace("'", "''");
            note = note.Replace("'", "''");

            string sqlComm = @"UPDATE TFORNITORI SET NOME ='" + nome
                + "', INDIRIZZO='" + indirizzo
                + "', TELEFONO_FISSO='" + telefonoFisso
                + "', TELEFONO_MOBILE='" + telefonoMobile
                + "', EMAIL='" + email
                + "', NOTE='" + note
                + "' WHERE IDFORNITORE='" + idFornitore + "'";
            DBUtility.setDBData(sqlComm);
        }

        public static void editCliente(
            string idCliente,
            string nome,
            string cognome,
            string datanascita,
            string indirizzo,
            string telefonoFisso,
            string telefonoMobile,
            string email,
            string note)
        {
            nome = nome.Replace("'", "''");
            cognome = cognome.Replace("'", "''");
            datanascita = datanascita.Replace("'", "''");
            indirizzo = indirizzo.Replace("'", "''");
            telefonoFisso = telefonoFisso.Replace("'", "''");
            telefonoMobile = telefonoMobile.Replace("'", "''");
            email = email.Replace("'", "''");
            note = note.Replace("'", "''");

            string sqlComm = @"UPDATE TCLIENTI SET "
                + "NOME = '" + nome + "', "
                + "COGNOME = '" + cognome + "', "
                + "DATA_NASCITA = '" + datanascita + "', "
                + "INDIRIZZO = '" + indirizzo + "', "
                + "TELEFONO_FISSO = '" + telefonoFisso + "', "
                + "TELEFONO_MOBILE = '" + telefonoMobile + "', "
                + "EMAIL = '" + email + "', "
                + "NOTE = '" + note + "' "
                + "WHERE IDCLIENTE = '" + idCliente + "'";

            DBUtility.setDBData(sqlComm);
        }

        public static void deleteCliente(string? idCliente)
        {
            string sqlComm = @"DELETE FROM TCLIENTI WHERE IDCLIENTE='" + idCliente + "'";
            DBUtility.setDBData(sqlComm);
        }
    }
}
