using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMLP.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.BillingForms.FrmBilling frm = new BillingForms.FrmBilling ();
            frm.Show();
        }
    }
}
