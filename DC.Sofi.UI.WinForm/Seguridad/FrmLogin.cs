﻿using DevExpress.XtraEditors;
using System;
using System.Linq;
using DC.Sofi.Bo.Seguridad;
using System.Windows.Forms;
using DC.Sofi.Domain.Seguridad;

namespace DC.Sofi.UI.WinForm.Seguridad
{
    public partial class FrmLogin : XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Usuario Usuario { get; set; }
        private const string ErrorLogin = "Credenciales incorrectas, intente con otro usuario o revise su contraseña";
        private void simpleButtonIngresar_Click(object sender, EventArgs e)
        {
            string usuario = textEditUsuario.Text;
            string password = textEditPassword.Text;
            UsuarioBo usuarioBo = new UsuarioBo();
            bool valido = usuarioBo.Login(usuario, password);
            if (valido)
            {
                var entity = usuarioBo.Get(usuario);
                Usuario = entity;
                DialogResult = DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show(ErrorLogin, Properties.Resources.MessaBoxTittle, MessageBoxButtons.OK);
                textEditUsuario.Focus();
            }
        }

        private void simpleButtonExit_Click(object sender, EventArgs e)
        {
            string mensage = "¿Esta seguro que desea salir del sistema?";
            var result = XtraMessageBox.Show(mensage,
                Properties.Resources.MessaBoxTittle,
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

    }
}
