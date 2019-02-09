namespace DC.Sofi.UI.WinForm.Seguridad
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditUsuario = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonIngresar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonExit = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEditImagen = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditImagen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Usuario";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(47, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Clave";
            // 
            // textEditUsuario
            // 
            this.textEditUsuario.Location = new System.Drawing.Point(95, 22);
            this.textEditUsuario.Name = "textEditUsuario";
            this.textEditUsuario.Size = new System.Drawing.Size(143, 20);
            this.textEditUsuario.TabIndex = 2;
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(95, 64);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.UseSystemPasswordChar = true;
            this.textEditPassword.Size = new System.Drawing.Size(143, 20);
            this.textEditPassword.TabIndex = 3;
            this.textEditPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditPassword_KeyDown);
            // 
            // simpleButtonIngresar
            // 
            this.simpleButtonIngresar.Location = new System.Drawing.Point(85, 150);
            this.simpleButtonIngresar.Name = "simpleButtonIngresar";
            this.simpleButtonIngresar.Size = new System.Drawing.Size(101, 33);
            this.simpleButtonIngresar.TabIndex = 4;
            this.simpleButtonIngresar.Text = "Ingresar";
            this.simpleButtonIngresar.Click += new System.EventHandler(this.simpleButtonIngresar_Click);
            // 
            // simpleButtonExit
            // 
            this.simpleButtonExit.Location = new System.Drawing.Point(257, 150);
            this.simpleButtonExit.Name = "simpleButtonExit";
            this.simpleButtonExit.Size = new System.Drawing.Size(101, 33);
            this.simpleButtonExit.TabIndex = 5;
            this.simpleButtonExit.Text = "Salir";
            this.simpleButtonExit.Click += new System.EventHandler(this.simpleButtonExit_Click);
            // 
            // pictureEditImagen
            // 
            this.pictureEditImagen.EditValue = global::DC.Sofi.UI.WinForm.Properties.Resources.usuarios;
            this.pictureEditImagen.Location = new System.Drawing.Point(257, 2);
            this.pictureEditImagen.Name = "pictureEditImagen";
            this.pictureEditImagen.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEditImagen.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEditImagen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEditImagen.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditImagen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditImagen.Size = new System.Drawing.Size(184, 142);
            this.pictureEditImagen.TabIndex = 6;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 212);
            this.ControlBox = false;
            this.Controls.Add(this.pictureEditImagen);
            this.Controls.Add(this.simpleButtonExit);
            this.Controls.Add(this.simpleButtonIngresar);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.textEditUsuario);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autenticación";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditImagen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditUsuario;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButtonIngresar;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExit;
        private DevExpress.XtraEditors.PictureEdit pictureEditImagen;
    }
}