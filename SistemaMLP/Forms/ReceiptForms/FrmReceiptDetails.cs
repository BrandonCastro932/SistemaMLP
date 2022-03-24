using MLPlib.Class;
using System;
using System.Windows.Forms;

namespace SistemaMLP.Forms.ReceiptForms
{
    public partial class FrmReceiptDetails : Form
    {
        public Customer customer = new Customer();
        public User user = new User();
        public Receipt receipt = new Receipt();
        public ReceiptDetails receiptDetails = new ReceiptDetails();
        public PaymentMethods paymentMethods = new PaymentMethods();

        public FrmReceiptDetails()
        {
            InitializeComponent();
        }


        private void FrmReceiptDetails_Load(object sender, EventArgs e)
        {
            FillInfo();
        }

        private void FillInfo()
        {
            LblReceiptCode.Text = receipt.ReceiptCode.ToString();
            LblDate.Text = receipt.Date.ToString();
            LblTotal.Text = "₡" + receipt.Total.ToString();
            LblTotalTax.Text = "₡" + receipt.TotalTax.ToString();
            LblTotalAmount.Text = "₡" + Convert.ToString(receipt.Total + receipt.TotalTax);
            TxtNotes.Text = receipt.Notes.ToString();



            LblPersonalID.Text = customer.PersonalID.ToString();
            LblFullname.Text = customer.Fullname.ToString();

            LblPaymentMethod.Text = paymentMethods.Name.ToString();

            if (paymentMethods.IDPaymentMethod == 2 && !receipt.PaymentConfirmed)
            {
                BtnPaymentConfirm.Visible = true;
            }
            else
            {
                BtnPaymentConfirm.Visible = false;
            }

            if (receipt.PaymentConfirmed)
            {
                LblCancel.Visible = true;
            }
            else
            {
                LblCancel.Visible = false;
            }

            LblUsername.Text = user.Username.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnPaymentConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
