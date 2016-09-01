using Koontabi.Domain;
using System;
using System.Linq;
using System.Windows.Forms;
using Koontabi.BusinessLogic.DBInitializerBL;

namespace KoontabiTelerikWinFormsApp
{
    static class Program
    {
        public static Employee currentEmployee { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBContextInitializerBL db = new DBContextInitializerBL();
            db.InitDb();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //KoontabiTelerikWinFormsApp.Splash.KoontabiSplashRadForm splash = new KoontabiTelerikWinFormsApp.Splash.KoontabiSplashRadForm();
            //if (splash.ShowDialog() == DialogResult.OK)
            //{
            //    Login.LoginRadForm login = new Login.LoginRadForm();
            //    if (login.ShowDialog() == DialogResult.OK)
            //    {

            //        Application.Run(new MainRadRibbonForm(currentEmployee));
            //    }

            //}

            //For Testing
            Application.Run(new MainRadRibbonForm(new Employee() {FullName = "Text" }));

        }
    }
}