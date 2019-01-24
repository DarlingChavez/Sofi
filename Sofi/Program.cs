using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using DC.Sofi.UI.WinForm;
using DC.Sofi.Bo;

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

            string defaultConnectionString = ConfigurationManager.AppSettings["defaultcn"].ToString();
            //Param.DefaultConnectionString = ConfigurationManager.ConnectionStrings[defaultConnectionString].ConnectionString;
            Param.DefaultConnectionString = defaultConnectionString;

            Application.Run(new DC.Sofi.UI.WinForm.Seguridad.FrmMain());
        }
    }
}
