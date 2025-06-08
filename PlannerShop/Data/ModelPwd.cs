using System.Data;

namespace PlannerShop.Data
{
    internal struct ModelPwd
    {
        public static bool GetAccess(string data)
        {
            DataTable dt = DBUtility.getDBData("SELECT * FROM 'TPWD' WHERE PASSWORD ='" + data + "'");
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void ChangePwd(string newPin)
        {
            string sqlComm = @"UPDATE TPwd SET Password='" + newPin + "' WHERE idPwd='1'";
            DBUtility.setDBData(sqlComm);
        }
        public static bool IsEnabled()
        {
            DataTable dt = DBUtility.getDBData("SELECT ENABLED FROM 'TPWD'");
            if (dt.Rows[0][0].ToString() == "TRUE")
                return true;
            else
                return false;
        }
        public static void SetEnabled(bool b)
        {
            string sqlComm = String.Empty;
            if (b)             
                sqlComm = @"UPDATE TPwd SET ENABLED='TRUE'";
            else
                sqlComm = @"UPDATE TPwd SET ENABLED='FALSE'";
            DBUtility.setDBData(sqlComm);
        }
    }
}
