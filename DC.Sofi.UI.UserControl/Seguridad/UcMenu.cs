using System;
using System.Linq;
using System.Collections.Generic;
using DC.Sofi.Domain.Seguridad;
using DevExpress.XtraTreeList;

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
                DoubleClickEvent(LastSelected);
            }
        }

    }
}
