using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PlannerShop.Data
{
    internal struct ModelAcquisti
    {
        public static DataTable getAcquistoById(string idAcquisto)
        {
            DataTable dt = DBUtility.getDBData("SELECT * FROM 'TACQUISTI' WHERE IDACQUISTO='" + idAcquisto + "'");
            return dt;
        }

        public static DataTable getAcquisti()
        {
            DataTable dt = DBUtility.getDBData("SELECT * FROM 'TACQUISTI' ORDER BY IDACQUISTO DESC");
            return dt;
        }

        public static DataTable getAcquistiByIdCliente(string idCliente)
        {
            DataTable dt = DBUtility.getDBData("SELECT * FROM 'TACQUISTI' WHERE IDCLIENTE='" + idCliente + "' ORDER BY IDACQUISTO DESC");
            return dt;
        }

        public static DataTable getAcquistiByIdClienteAndProductId(string idCliente, string idProdotto)
        {
            DataTable dt = DBUtility.getDBData("SELECT * FROM 'TACQUISTI' WHERE IDCLIENTE='" + idCliente + "' AND IDPRODOTTO='" + idProdotto + "' ORDER BY IDACQUISTO DESC");
            return dt;
        }

        public static void addAcquisto(
            string marca,
            string descrizione,
            string qnt,
            string prezzoNetto,
            string prezzoIvato,
            string dataAcquisto,
            string idCliente,
            string idProdotto)
        {
            dataAcquisto = dataAcquisto.Replace("'", "''");
            marca = marca.Replace("'", "''");
            descrizione = descrizione.Replace("'", "''");
            qnt = qnt.Replace("'", "''");
            prezzoNetto = prezzoNetto.Replace("'", "''");
            prezzoIvato = prezzoIvato.Replace("'", "''");
            idCliente = idCliente.Replace("'", "''");
            idProdotto = idProdotto.Replace("'", "''");

            string sqlComm = @"INSERT INTO TACQUISTI (MARCA,DESCRIZIONE,QNT,PREZZO_NETTO,PREZZO_IVATO,DATA_ACQUISTO,IDCLIENTE,IDPRODOTTO)VALUES('"
                + marca + "','"
                + descrizione + "','"
                + qnt + "','"
                + prezzoNetto + "','"
                + prezzoIvato + "','"
                + dataAcquisto + "','"
                + int.Parse(idCliente) + "','"
                + int.Parse(idProdotto) + "')";
            DBUtility.setDBData(sqlComm);
        }

        public static void updateQuantity(string idProdotto, string idCliente, int newQnt)
        {
            string sqlComm = @"UPDATE TACQUISTI 
                       SET QNT = '" + newQnt + @"' 
                       WHERE IDPRODOTTO = '" + idProdotto + "' AND IDCLIENTE = '" + idCliente + "'";

            DBUtility.setDBData(sqlComm);
        }

        public static void deleteAcquisto(string? idAcquisto)
        {
            string sqlComm = @"DELETE FROM TACQUISTO WHERE IDACQUISTO='" + idAcquisto + "'";
            DBUtility.setDBData(sqlComm);
        }
    }
}
