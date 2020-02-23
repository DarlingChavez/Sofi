namespace DC.Sofi.UI.UserControl.Seguridad
{
    partial class UcMenu
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControlTop = new DevExpress.XtraEditors.PanelControl();
            this.searchControlMenu = new DevExpress.XtraEditors.SearchControl();
            this.treeListMenu = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumnDescripcion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControlFill = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).BeginInit();
            this.panelControlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControlMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFill)).BeginInit();
            this.panelControlFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControlTop
            // 
            this.panelControlTop.Controls.Add(this.searchControlMenu);
            this.panelControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTop.Location = new System.Drawing.Point(0, 0);
            this.panelControlTop.Name = "panelControlTop";
            this.panelControlTop.Size = new System.Drawing.Size(242, 25);
            this.panelControlTop.TabIndex = 0;
            // 
            // searchControlMenu
            // 
            this.searchControlMenu.Client = this.treeListMenu;
            this.searchControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchControlMenu.Location = new System.Drawing.Point(2, 2);
            this.searchControlMenu.Name = "searchControlMenu";
            this.searchControlMenu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.MRUButton()});
            this.searchControlMenu.Properties.Client = this.treeListMenu;
            this.searchControlMenu.Properties.ShowMRUButton = true;
            this.searchControlMenu.Properties.ShowSearchButton = false;
            this.searchControlMenu.Size = new System.Drawing.Size(238, 20);
            this.searchControlMenu.TabIndex = 1;
            this.searchControlMenu.TextChanged += new System.EventHandler(this.searchControlMenu_TextChanged);
            this.searchControlMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchControlMenu_KeyDown);
            // 
            // treeListMenu
            // 
            this.treeListMenu.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumnDescripcion});
            this.treeListMenu.DataSource = this.menuBindingSource;
            this.treeListMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMenu.KeyFieldName = "IdMenu";
            this.treeListMenu.Location = new System.Drawing.Point(2, 2);
            this.treeListMenu.Name = "treeListMenu";
            this.treeListMenu.OptionsBehavior.Editable = false;
            this.treeListMenu.OptionsView.ShowColumns = false;
            this.treeListMenu.OptionsView.ShowHorzLines = false;
            this.treeListMenu.OptionsView.ShowIndicator = false;
            this.treeListMenu.OptionsView.ShowVertLines = false;
            this.treeListMenu.ParentFieldName = "IdMenuPadre";
            this.treeListMenu.Size = new System.Drawing.Size(238, 406);
            this.treeListMenu.TabIndex = 0;
            this.treeListMenu.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeListMenu_CustomDrawNodeCell);
            this.treeListMenu.DoubleClick += new System.EventHandler(this.treeListMenu_DoubleClick);
            this.treeListMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeListMenu_KeyDown);
            this.treeListMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeListMenu_KeyPress);
            // 
            // treeListColumnDescripcion
            // 
            this.treeListColumnDescripcion.Caption = "Menu";
            this.treeListColumnDescripcion.FieldName = "Descripcion";
            this.treeListColumnDescripcion.Name = "treeListColumnDescripcion";
            this.treeListColumnDescripcion.Visible = true;
            this.treeListColumnDescripcion.VisibleIndex = 0;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataSource = typeof(DC.Sofi.Domain.Seguridad.Menu);
            // 
            // panelControlFill
            // 
            this.panelControlFill.Controls.Add(this.treeListMenu);
            this.panelControlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlFill.Location = new System.Drawing.Point(0, 25);
            this.panelControlFill.Name = "panelControlFill";
            this.panelControlFill.Size = new System.Drawing.Size(242, 410);
            this.panelControlFill.TabIndex = 1;
            // 
            // UcMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControlFill);
            this.Controls.Add(this.panelControlTop);
            this.Name = "UcMenu";
            this.Size = new System.Drawing.Size(242, 435);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).EndInit();
            this.panelControlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControlMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFill)).EndInit();
            this.panelControlFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlTop;
        private DevExpress.XtraEditors.SearchControl searchControlMenu;
        private DevExpress.XtraEditors.PanelControl panelControlFill;
        private DevExpress.XtraTreeList.TreeList treeListMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnDescripcion;
        private System.Windows.Forms.BindingSource menuBindingSource;
    }
}
