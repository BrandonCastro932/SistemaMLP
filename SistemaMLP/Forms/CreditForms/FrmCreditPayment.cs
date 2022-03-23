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

namespace SistemaMLP.Forms.CreditForms
{
    public partial class FrmCreditPayment : Form
    {
        public Customer customer = new Customer();
        public Receipt receipt = new Receipt();
        public CreditDetails creditDetails = new CreditDetails();
        public CreditPayments creditPayments = new CreditPayments();

        public FrmCreditPayment()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FrmCreditPayment_Load(object sender, EventArgs e)
        {
            FillInfo();
            FillDGV();
        }

        private void FillInfo()
        {
            LblReceiptCode.Text = receipt.ReceiptCode.ToString();
            LblFullname.Text = customer.Fullname.ToString();
            LblRegDate.Text = creditDetails.RegDate.ToString();
            LblNextAmount.Text = creditDetails.NextAmount.ToString();
            LblPreviousAmount.Text = creditDetails.PreviousAmount.ToString();
            LblActualAmount.Text = creditDetails.ActualAmount.ToString();
            LblReceiptTotal.Text = Convert.ToString(receipt.Total + receipt.TotalTax);
        }

        private void FillDGV()
        {
            creditPayments.IDCreditDetail = creditDetails.IDCreditDetails;
            DGVPayments.DataSource = creditPayments.GetCreditPayments();

            DGVPayments.Columns["IDCreditPayment"].Visible = false;
            DGVPayments.Columns["IDCreditDetail"].Visible = false;

            DGVPayments.Columns["PaymentAmount"].HeaderText = "Cantidad pagada";
            DGVPayments.Columns["RegDate"].HeaderText = "Fecha del pago";

            DGVPayments.Columns["PaymentAmount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVPayments.Columns["RegDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DGVPayments.Sort(DGVPayments.Columns["RegDate"], ListSortDirection.Descending);
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                CreditPayments payments = new CreditPayments
                {
                    IDCreditDetail = creditDetails.IDCreditDetails,
                    PaymentAmount = Convert.ToDecimal(TxtPayment.Text),
                    RegDate = DateTime.Now
                };
                if(payments.CreateCreditPayment() == 1)
                {
                    MessageBox.Show("OK");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {

            }
        }

        private void TxtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            //Asi solo se permite una coma para los decimales
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
