using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;

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