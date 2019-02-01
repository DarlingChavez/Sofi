using System;
using System.Linq;
using System.Collections.Generic;
using DC.Sofi.Domain.Seguridad;
using DevExpress.XtraTreeList;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DC.Sofi.UI.UserControl.Seguridad
{
    public partial class UcMenu : System.Windows.Forms.UserControl
    {
        public UcMenu()
        {
            InitializeComponent();
            //// Disable the default look-and-feel settings. 
            //this.treeListMenu.LookAndFeel.UseDefaultLookAndFeel = false;
            //// Specify the skin. 
            //this.treeListMenu.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            //this.treeListMenu.LookAndFeel.SkinName = "Seven Classic";
        }
        
        private DevExpress.XtraTreeList.Nodes.TreeListNode lastNodeSelected;
        public delegate void DoubleClickDelegate(object tag);
        public event DoubleClickDelegate DoubleClickEvent;
        public List<Menu> DataSource
        {
            set { this.treeListMenu.DataSource = value; }
        }

        public Menu LastSelected
        {
            get { return this.treeListMenu.GetDataRecordByNode(lastNodeSelected) as Menu; }
        }

        private void treeListMenu_DoubleClick(object sender, EventArgs e)
        {
            TreeListHitInfo hi = treeListMenu.CalcHitInfo(treeListMenu.PointToClient(System.Windows.Forms.Control.MousePosition));
            if (hi.Node != null)
            {
                lastNodeSelected = hi.Node;
                var tag = treeListMenu.GetDataRecordByNode(lastNodeSelected);
                DoubleClickEvent(tag);
            }
        }

        private void treeListMenu_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            TreeList lista = sender as TreeList;
            if (e.Node == lista.FocusedNode)
            {
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                var left = e.EditViewInfo.ContentRect.Left;
                Rectangle rectanguloTexto = new Rectangle(left,e.EditViewInfo.ContentRect.Top,
                    Convert.ToInt32(e.Graphics.MeasureString(e.CellText, lista.Font).Width + 1),
                    Convert.ToInt32(e.Graphics.MeasureString(e.CellText, lista.Font).Height));

                Rectangle rectanguloBase = new Rectangle(left-3, 0,lista.Width,150);

                e.Graphics.FillRectangle(SystemBrushes.Highlight, rectanguloBase);
                e.Graphics.DrawString(e.CellText, lista.Font, SystemBrushes.HighlightText, rectanguloTexto);
                e.Handled = true;
            }
        }

        private void searchControlMenu_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchControlMenu.Text))
            {
                this.treeListMenu.ExpandAll();
            }
        }
        
    }
}
