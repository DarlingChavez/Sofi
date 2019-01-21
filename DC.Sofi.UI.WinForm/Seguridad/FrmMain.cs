using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sofi
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(this.barSubItemTemas);
        }

        private void barButtonItemSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mensage = "¿Esta seguro que desea salir del sistema?";
            var respuesta = XtraMessageBox.Show(mensage, "Mensage de confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void barButtonItemReiniciar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mensage = "¿Esta seguro que desea reiniciar el sistema?";
            var respuesta = XtraMessageBox.Show(mensage, "Mensage de confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}