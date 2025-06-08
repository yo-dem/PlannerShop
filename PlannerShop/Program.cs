using PlannerShop.Data;
using PlannerShop.Forms;

namespace PlannerShop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (ModelPwd.IsEnabled())
            {
                LoginForm lgf = new LoginForm();
                Application.Run(lgf);
                if (lgf.logged)
                    Application.Run(new MainForm());
            }
            else
                Application.Run(new MainForm());
        }
    }
}