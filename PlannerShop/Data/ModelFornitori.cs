using System.Data;

namespace PlannerShop.Data
{
    internal struct ModelFornitori
    {
        public static DataTable getFornitoreById(string idFornitore)
        {
            DataTable dt = DBUtility.getDBData("SELECT * FROM 'TFORNITORI' WHERE IDFORNITORE='" + idFornitore + "'");
            return dt;
        }
        
        public static DataTable getFornitori()
        {
            DataTable dt = DBUtility.getDBData("SELECT * FROM 'TFORNITORI' ORDER BY IDFORNITORE DESC");
            return dt;
        }
        
        public static void addFornitore(
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

            string sqlComm = @"INSERT INTO TFORNITORI (NOME,INDIRIZZO,TELEFONO_FISSO,TELEFONO_MOBILE,EMAIL,NOTE)VALUES('"
                + nome + "','"
                + indirizzo + "','"
                + telefonoFisso + "','"
                + telefonoMobile + "','"
                + email + "','"
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
        
        public static void deleteFornitore(string? idFornitore)
        {
            string sqlComm = @"DELETE FROM TFORNITORI WHERE IDFORNITORE='" + idFornitore + "'";
            DBUtility.setDBData(sqlComm);
        }
    }
}
