using System.Data;

namespace PlannerShop.Data
{
    internal struct ModelPwd
    {
        public static bool GetAccess(string data)
        {
            DataTable dt = DBUtility.GetDBData("SELECT * FROM TPWD WHERE PASSWORD = @pwd", new Dictionary<string, object?> { { "@pwd", data } });
            return dt.Rows.Count > 0;
        }
        public static void ChangePwd(string newPin)
        {
            DBUtility.SetDBData("UPDATE TPwd SET Password=@pwd WHERE idPwd='1'", new Dictionary<string, object?> { { "@pwd", newPin } });
        }
        public static bool IsEnabled()
        {
            DataTable dt = DBUtility.GetDBData("SELECT ENABLED FROM TPWD", null);
            if (dt.Rows.Count == 0) return false;
            return dt.Rows[0][0].ToString()?.ToUpper() == "TRUE";
        }
        public static void SetEnabled(bool b)
        {
            DBUtility.SetDBData("UPDATE TPwd SET ENABLED=@val", new Dictionary<string, object?> { { "@val", b ? "TRUE" : "FALSE" } });
        }
    }
}