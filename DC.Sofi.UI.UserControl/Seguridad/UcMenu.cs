using System;
using System.Linq;
using System.Collections.Generic;
using DC.Sofi.Domain.Seguridad;
using DevExpress.XtraTreeList;
using System.Drawing;

namespace DC.Sofi.UI.UserControl.Seguridad
{
    public partial class UcMenu : System.Windows.Forms.UserControl
    {
        public UcMenu()
        {
            InitializeComponent();
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
                Rectangle rectangulo = new Rectangle(e.EditViewInfo.ContentRect.Left,
                    e.EditViewInfo.ContentRect.Top,
                    Convert.ToInt32(e.Graphics.MeasureString(e.CellText, lista.Font).Width + 1),
                    Convert.ToInt32(e.Graphics.MeasureString(e.CellText, lista.Font).Height));
                e.Graphics.FillRectangle(SystemBrushes.Highlight, rectangulo);
                e.Graphics.DrawString(e.CellText, lista.Font, SystemBrushes.HighlightText, rectangulo);

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
