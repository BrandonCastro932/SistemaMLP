using MLPlib.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMLP.Forms.LogForm
{
    public partial class FrmLog : Form
    {
        Log log = new Log();
        public FrmLog()
        {
            InitializeComponent();
        }

        private void FrmLog_Load(object sender, EventArgs e)
        {
            MdiParent = Utilities.Utilities.main;
            FillDGV();

            DGVLog.Columns["IDLog"].Visible = false;

            DGVLog.Columns["LogMSG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVLog.Columns["LogMSG"].HeaderText = "Movimiento";
            DGVLog.Columns["RegDate"].Width = 120;
            DGVLog.Columns["RegDate"].HeaderText = "Fecha y hora";

            DGVLog.Sort(DGVLog.Columns["RegDate"],ListSortDirection.Descending);
        }

        private void FillDGV()
        {
            DGVLog.DataSource = log.GetLog();
        }
    }
}
