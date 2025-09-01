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
        
        public static void addAcquisto(
            string marca,
            string descrizione,
            string qnt,
            string prezzoNetto,
            string prezzoIvato,
            string dataAcquisto,
            string idCliente)
        {
            dataAcquisto = dataAcquisto.Replace("'", "''");
            marca = marca.Replace("'", "''");
            descrizione = descrizione.Replace("'", "''");
            qnt = qnt.Replace("'", "''");
            prezzoNetto = prezzoNetto.Replace("'", "''");
            prezzoIvato = prezzoIvato.Replace("'", "''");
            idCliente = idCliente.Replace("'", "''");

            string sqlComm = @"INSERT INTO TACQUISTI (MARCA,DESCRIZIONE,QNT,PREZZO_NETTO,PREZZO_IVATO,DATA_ACQUISTO,IDCLIENTE)VALUES('"
                + marca + "','"
                + descrizione + "','"
                + qnt + "','"
                + prezzoNetto + "','"
                + prezzoIvato + "','"
                + dataAcquisto + "','"
                + int.Parse(idCliente) + "')";
            DBUtility.setDBData(sqlComm);
        }
        
        public static void editAcquisto(
            string idAcquisto,
            string marca,
            string descrizione,
            string aliquota,
            string qnt,
            string prezzoNetto,
            string prezzoIvato,
            string dataAcquisto,
            string idCliente)
        {
            marca = marca.Replace("'", "''");
            descrizione = descrizione.Replace("'", "''");
            aliquota = aliquota.Replace("'", "''");
            qnt = qnt.Replace("'", "''");
            prezzoNetto = prezzoNetto.Replace("'", "''");
            prezzoIvato = prezzoIvato.Replace("'", "''");
            dataAcquisto = dataAcquisto.Replace("'", "''");
            idCliente = idCliente.Replace("'", "''");

            string sqlComm = @"UPDATE TPRODOTTI SET MARCA='" + marca
                + "', DESCRIZIONE='" + descrizione
                + "', ALIQUOTA='" + aliquota
                + "', QNT='" + qnt
                + "', PREZZO_NETTO='" + prezzoNetto
                + "', PREZZO_IVATO='" + prezzoIvato
                + "', DATA_ACQUISTO='" + dataAcquisto
                + "', IDCLIENTE='" + int.Parse(idCliente)
                + "', DATA = '" + dataAcquisto
                + "' WHERE IDACQUISTO='" + idAcquisto + "'";
            DBUtility.setDBData(sqlComm);
        }
        
        public static void deleteAcquisto(string? idAcquisto)
        {
            string sqlComm = @"DELETE FROM TACQUISTO WHERE IDACQUISTO='" + idAcquisto + "'";
            DBUtility.setDBData(sqlComm);
        }
    }
}
