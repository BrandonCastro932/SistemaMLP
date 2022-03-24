using Microsoft.Toolkit.Uwp.Notifications;
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
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;

namespace SistemaMLP.Forms
{
    public partial class FrmMain : Form
    {
        private SqlTableDependency<CreditDetails> creditPaymentsDependency = new SqlTableDependency<CreditDetails>("Data Source=.;Initial Catalog=SistemaMLP;Integrated Security=True");

        private CreditDetails creditDetails = new CreditDetails();

        public FrmMain()
        {
            InitializeComponent();
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            Utilities.Utilities.main = this;
            LblCredito.Text = "Total en crédito: ₡" + creditDetails.GetCreditsTotal();

            creditPaymentsDependency.OnChanged += CreditDetailsTableDependency_Changed;



            creditPaymentsDependency.Start();

        }

        public void CreditDetailsTableDependency_Changed(object sender, RecordChangedEventArgs<CreditDetails> e)
        {
            if (e.ChangeType != TableDependency.SqlClient.Base.Enums.ChangeType.None)
            {

                LblCredito.Text = "Total en crédito: ₡" + creditDetails.GetCreditsTotal().ToString();


            }
        }


        



        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilities.Utilities.frmBilling.Visible)
            {
                Utilities.Utilities.frmBilling = new BillingForms.FrmBilling();
                Utilities.Utilities.frmBilling.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilities.Utilities.frmCustomers.Visible)
            {
                Utilities.Utilities.frmCustomers = new CustomerForms.FrmCustomers();
                Utilities.Utilities.frmCustomers.Show();
            }
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilities.Utilities.frmProduct.Visible)
            {
                Utilities.Utilities.frmProduct = new CustomerForms.FrmProduct();
                Utilities.Utilities.frmProduct.Show();
            }
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilities.Utilities.frmLog.Visible)
            {
                Utilities.Utilities.frmLog = new LogForm.FrmLog();
                Utilities.Utilities.frmLog.Show();
            }
        }

        private void entradaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilities.Utilities.frmSupply.Visible)
            {
                Utilities.Utilities.frmSupply = new ProductForms.FrmSupply();
                Utilities.Utilities.frmSupply.Show();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilities.Utilities.frmCredit.Visible)
            {
                Utilities.Utilities.frmCredit = new CreditForms.FrmCreditReceipts();
                Utilities.Utilities.frmCredit.Show();
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            creditPaymentsDependency.Stop();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!Utilities.Utilities.frmUsers.Visible)
            {
                Utilities.Utilities.frmUsers = new UserForms.FrmUsers();
                Utilities.Utilities.frmUsers.Show();
            }
        }

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilities.Utilities.frmNotification.Visible)
            {
                Utilities.Utilities.frmNotification = new NotificationForms.FrmNotification();
                Utilities.Utilities.frmNotification.Show();
            }
            //new ToastContentBuilder().AddText("Notificaciones disponibles").AddHeader("1", "Sistema Mariscos La Puebla", "").Show();
        }
    }
}
