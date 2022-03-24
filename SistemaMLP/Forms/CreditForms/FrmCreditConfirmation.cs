using MLPlib.Class;
using System;
using System.Windows.Forms;

namespace SistemaMLP.Forms.CreditForms
{
    public partial class FrmCreditConfirmation : Form
    {
        public Customer customer = new Customer();
        public Credit credit = new Credit();

        public FrmCreditConfirmation()
        {
            InitializeComponent();
        }

        private void FrmCreditConfirmation_Load(object sender, EventArgs e)
        {
            LblCustomerName.Text = customer.Fullname;
            LblTotalCredit.Text = "₡" + Convert.ToString(credit.Total);
            this.KeyPreview = true;
        }

        private void FrmCreditConfirmation_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmCreditConfirmation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
            if (e.KeyData == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            if (e.KeyData == Keys.Y)
            {
                this.DialogResult = DialogResult.OK;
            }
            if (e.KeyData == Keys.N)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
