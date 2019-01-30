﻿using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using DC.Sofi.UI.WinForm.Seguridad;
using DC.Sofi.Bo;
using DC.Sofi.Bo.Seguridad;
using DC.Sofi.Domain;
using DevExpress.XtraBars.Docking2010;

namespace DC.Sofi.UI.WinForm.Seguridad
{
    public partial class FrmMain : XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private const string StrUsuario = "Usuario";

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(this.barSubItemTemas);
            //string defaultConnection = ConfigurationManager.AppSettings["DefaultConnectionString"].ToString();

            FrmLogin frmLogin = new FrmLogin();
            var result = frmLogin.ShowDialog();
            if(result == DialogResult.OK)
            {
                Param.ActiveUser = frmLogin.Usuario;
                MenuBo menuBo = new MenuBo();
                var listMenu = menuBo.MenuOfUser(Param.ActiveUser.UserName);
                ucMenuPrincipal.DataSource = listMenu;
                barStaticItemUsuario.Caption = string.Format("{0} : {1}",StrUsuario,Param.ActiveUser.UserName);
            }else if(result == DialogResult.Cancel)
            {
                Application.Exit();
            }

            ucMenuPrincipal.DoubleClickEvent += UcMenuPrincipal_DoubleClickEvent;
        }

        private void UcMenuPrincipal_DoubleClickEvent(object tag)
        {
            Domain.Seguridad.Menu menu = (Domain.Seguridad.Menu)tag;
            if (menu.TieneFormulario)
            {
                System.Reflection.Assembly Ensamblado;
                Ensamblado = System.Reflection.Assembly.LoadFrom(menu.NombreAsembly);
                System.Reflection.AssemblyName assemblyName = Ensamblado.GetName();
                Type type = Ensamblado.GetType(assemblyName.Name + "." + menu.NombreFormulario);
                if (type == null)
                {
                    string errorensamblado = "Error al crear el ensamblado del formulario. Consulte con el departamento de sistemas";
                    XtraMessageBox.Show(errorensamblado,
                        Properties.Resources.MessaBoxTittle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }
                string fullName = assemblyName.Name + "." + menu.NombreFormulario;
                int posicion = menu.NombreFormulario.LastIndexOf('.');
                string shortName = menu.NombreFormulario.Substring(posicion + 1, menu.NombreFormulario.Length - posicion - 1);
                var existsForm = this.MdiChildren.Where(x => x.Name.Equals(shortName)).FirstOrDefault();
                if (existsForm != null)
                {
                    existsForm.Activate();
                    return;
                }
                object formObject = Activator.CreateInstance(type);
                Form form = (Form)formObject;
                form.Text = menu.Descripcion;
                form.MdiParent = this;
                form.Tag = menu;
                form.Show();
            }
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
