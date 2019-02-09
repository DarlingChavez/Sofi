using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DC.Sofi.UI.WinForm
{
    public partial class FrmWait : DevExpress.XtraEditors.XtraForm
    {
        public Action Worked { get; set; }

        public FrmWait(Action action)
        {
            InitializeComponent();
            this.Text = Bo.Param.SystemName;
            if (action == null)
                throw new ArgumentNullException();
            Worked = action;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worked).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

    }
}