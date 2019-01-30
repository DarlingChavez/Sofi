namespace DC.Sofi.UI.WinForm.Seguridad
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dockManagerPrincipal = new DevExpress.XtraBars.Docking.DockManager();
            this.barManagerPrincipal = new DevExpress.XtraBars.BarManager();
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.barSubItemSistema = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemTemas = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemMenu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemReiniciar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.barStaticItemUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockPanelMenu = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanelMenu_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucMenuPrincipal = new DC.Sofi.UI.UserControl.Seguridad.UcMenu();
            this.documentManagerPrincipal = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedViewPrincipal = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerPrincipal)).BeginInit();
            this.dockPanelMenu.SuspendLayout();
            this.dockPanelMenu_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedViewPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManagerPrincipal
            // 
            this.dockManagerPrincipal.Form = this;
            this.dockManagerPrincipal.MenuManager = this.barManagerPrincipal;
            this.dockManagerPrincipal.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelMenu});
            this.dockManagerPrincipal.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // barManagerPrincipal
            // 
            this.barManagerPrincipal.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMenu,
            this.barStatus});
            this.barManagerPrincipal.DockControls.Add(this.barDockControlTop);
            this.barManagerPrincipal.DockControls.Add(this.barDockControlBottom);
            this.barManagerPrincipal.DockControls.Add(this.barDockControlLeft);
            this.barManagerPrincipal.DockControls.Add(this.barDockControlRight);
            this.barManagerPrincipal.DockManager = this.dockManagerPrincipal;
            this.barManagerPrincipal.Form = this;
            this.barManagerPrincipal.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItemUsuario,
            this.barSubItemSistema,
            this.barSubItemTemas,
            this.barButtonItemMenu,
            this.barButtonItemReiniciar,
            this.barButtonItemSalir});
            this.barManagerPrincipal.MainMenu = this.barMenu;
            this.barManagerPrincipal.MaxItemId = 7;
            this.barManagerPrincipal.StatusBar = this.barStatus;
            // 
            // barMenu
            // 
            this.barMenu.BarName = "Menú principal";
            this.barMenu.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemSistema)});
            this.barMenu.OptionsBar.AllowQuickCustomization = false;
            this.barMenu.OptionsBar.UseWholeRow = true;
            this.barMenu.Text = "Menú principal";
            // 
            // barSubItemSistema
            // 
            this.barSubItemSistema.Caption = "Sistema";
            this.barSubItemSistema.Id = 2;
            this.barSubItemSistema.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemTemas),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemReiniciar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSalir)});
            this.barSubItemSistema.Name = "barSubItemSistema";
            // 
            // barSubItemTemas
            // 
            this.barSubItemTemas.Caption = "Temas";
            this.barSubItemTemas.Id = 3;
            this.barSubItemTemas.Name = "barSubItemTemas";
            // 
            // barButtonItemMenu
            // 
            this.barButtonItemMenu.Caption = "Menú";
            this.barButtonItemMenu.Id = 4;
            this.barButtonItemMenu.Name = "barButtonItemMenu";
            // 
            // barButtonItemReiniciar
            // 
            this.barButtonItemReiniciar.Caption = "Reiniciar";
            this.barButtonItemReiniciar.Id = 5;
            this.barButtonItemReiniciar.Name = "barButtonItemReiniciar";
            this.barButtonItemReiniciar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemReiniciar_ItemClick);
            // 
            // barButtonItemSalir
            // 
            this.barButtonItemSalir.Caption = "Salir";
            this.barButtonItemSalir.Id = 6;
            this.barButtonItemSalir.Name = "barButtonItemSalir";
            this.barButtonItemSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSalir_ItemClick);
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Barra de estado";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItemUsuario)});
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Barra de estado";
            // 
            // barStaticItemUsuario
            // 
            this.barStaticItemUsuario.Caption = "Usuario: ";
            this.barStaticItemUsuario.Id = 1;
            this.barStaticItemUsuario.Name = "barStaticItemUsuario";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerPrincipal;
            this.barDockControlTop.Size = new System.Drawing.Size(1045, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 406);
            this.barDockControlBottom.Manager = this.barManagerPrincipal;
            this.barDockControlBottom.Size = new System.Drawing.Size(1045, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManagerPrincipal;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 384);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1045, 22);
            this.barDockControlRight.Manager = this.barManagerPrincipal;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 384);
            // 
            // dockPanelMenu
            // 
            this.dockPanelMenu.Controls.Add(this.dockPanelMenu_Container);
            this.dockPanelMenu.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelMenu.ID = new System.Guid("0d54bdb8-7a14-4932-a35d-75e53573e54b");
            this.dockPanelMenu.Location = new System.Drawing.Point(0, 22);
            this.dockPanelMenu.Name = "dockPanelMenu";
            this.dockPanelMenu.OriginalSize = new System.Drawing.Size(231, 200);
            this.dockPanelMenu.SavedSizeFactor = 0D;
            this.dockPanelMenu.Size = new System.Drawing.Size(231, 384);
            this.dockPanelMenu.Text = "Menu";
            // 
            // dockPanelMenu_Container
            // 
            this.dockPanelMenu_Container.Controls.Add(this.ucMenuPrincipal);
            this.dockPanelMenu_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanelMenu_Container.Name = "dockPanelMenu_Container";
            this.dockPanelMenu_Container.Size = new System.Drawing.Size(222, 357);
            this.dockPanelMenu_Container.TabIndex = 0;
            // 
            // ucMenuPrincipal
            // 
            this.ucMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ucMenuPrincipal.Name = "ucMenuPrincipal";
            this.ucMenuPrincipal.Size = new System.Drawing.Size(222, 357);
            this.ucMenuPrincipal.TabIndex = 0;
            // 
            // documentManagerPrincipal
            // 
            this.documentManagerPrincipal.MdiParent = this;
            this.documentManagerPrincipal.MenuManager = this.barManagerPrincipal;
            this.documentManagerPrincipal.View = this.tabbedViewPrincipal;
            this.documentManagerPrincipal.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedViewPrincipal});
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 431);
            this.Controls.Add(this.dockPanelMenu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Sistema Sofi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerPrincipal)).EndInit();
            this.dockPanelMenu.ResumeLayout(false);
            this.dockPanelMenu_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedViewPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking.DockManager dockManagerPrincipal;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelMenu;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanelMenu_Container;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManagerPrincipal;
        private DevExpress.XtraBars.Bar barMenu;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItemUsuario;
        private DevExpress.XtraBars.BarSubItem barSubItemSistema;
        private DevExpress.XtraBars.BarSubItem barSubItemTemas;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReiniciar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSalir;
        private DC.Sofi.UI.UserControl.Seguridad.UcMenu ucMenuPrincipal;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManagerPrincipal;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedViewPrincipal;
    }
}