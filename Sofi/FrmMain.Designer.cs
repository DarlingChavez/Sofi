namespace Sofi
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
            this.components = new System.ComponentModel.Container();
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockManagerPrincipal = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.menuStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerPrincipal)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(1045, 24);
            this.menuStripMenu.TabIndex = 1;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // dockManagerPrincipal
            // 
            this.dockManagerPrincipal.Form = this;
            this.dockManagerPrincipal.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
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
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("0d54bdb8-7a14-4932-a35d-75e53573e54b");
            this.dockPanel1.Location = new System.Drawing.Point(0, 24);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(231, 200);
            this.dockPanel1.SavedSizeFactor = 0D;
            this.dockPanel1.Size = new System.Drawing.Size(231, 407);
            this.dockPanel1.Text = "Menu";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(222, 380);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 431);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.menuStripMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerPrincipal)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManagerPrincipal;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
    }
}