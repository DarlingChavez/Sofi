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
                var top = e.EditViewInfo.ContentRect.Top;
                var width = e.EditViewInfo.ContentRect.Width;// Convert.ToInt32(e.Graphics.MeasureString(e.CellText, lista.Font).Width + 1);
                var heigth = e.EditViewInfo.ContentRect.Height; //Convert.ToInt32(e.Graphics.MeasureString(e.CellText, lista.Font).Height);
                
                Rectangle rectanguloTexto = new Rectangle(left,top,width,heigth);

                Rectangle rectanguloBase = new Rectangle(left-3, 0,lista.Width,180);

                e.Graphics.FillRectangle(SystemBrushes.Highlight, rectanguloBase);
                lista.Font = new Font(lista.Font.FontFamily, lista.Font.Size, FontStyle.Bold, lista.Font.Unit);
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

        private void treeListMenu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            var nodo = this.treeListMenu.FocusedNode;
            switch(e.KeyCode){
                case System.Windows.Forms.Keys.Right:
                    {
                        if (nodo.HasChildren)
                            nodo.Expand();
                        break;
                    }
                case System.Windows.Forms.Keys.Left:
                    {
                        nodo.Collapse();
                        break;
                    }
                case System.Windows.Forms.Keys.Up:
                    {
                        if(nodo == this.treeListMenu.GetNodeList().Where(n=>n.Visible==true).First())
                        {
                            this.searchControlMenu.Focus();
                        }
                        break;
                    }
            }
        }

        private void searchControlMenu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case System.Windows.Forms.Keys.Down:
                    {
                        this.treeListMenu.Focus();
                        this.treeListMenu.SelectNode(this.treeListMenu.Nodes[this.treeListMenu.TopVisibleNodeIndex]);
                        e.Handled = true;
                        break;
                    }
            }
        }

        private void treeListMenu_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                var tag = treeListMenu.GetDataRecordByNode(this.treeListMenu.FocusedNode);
                DoubleClickEvent(tag);
            }
        }
    }
}
