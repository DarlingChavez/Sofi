using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace Sofi
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string feel = ConfigurationManager.AppSettings["SkinName"].ToString();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(feel);

            string defaultConnectionString = ConfigurationManager.AppSettings["DefaultConnectionString"].ToString();
            DC.Sofi.Bo.Param.DefaultConnectionString = defaultConnectionString;

            Application.Run(new FrmMain());
        }
    }
}
