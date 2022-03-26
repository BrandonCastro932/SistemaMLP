using CrystalDecisions.CrystalReports.Engine;
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
            FillDGV();
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

            if(customer.PersonalID == "1")
            {
                LblTitlePersonalID.Visible = false;
                LblPersonalID.Visible = false;
            }
            else
            {
                LblTitlePersonalID.Visible = true;
                LblPersonalID.Visible = true;
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

        private void FillDGV()
        {
            receiptDetails.IDReceipt = receipt.IDReceipt;
            DGVReceiptDetails.DataSource = receiptDetails.GetReceiptDetails();

            DGVReceiptDetails.Columns["IDDetail"].Visible = false;
            DGVReceiptDetails.Columns["IDReceipt"].Visible = false;
            DGVReceiptDetails.Columns["IDProduct"].Visible = false;
            DGVReceiptDetails.Columns["IDCutType"].Visible = false;
            DGVReceiptDetails.Columns["Active"].Visible = false;
            DGVReceiptDetails.Columns["LastUpdate"].Visible = false;
            DGVReceiptDetails.Columns["RegDate"].Visible = false;
            DGVReceiptDetails.Columns["GeneralStock"].Visible = false;
            DGVReceiptDetails.Columns["IDCutType"].Visible = false;
            DGVReceiptDetails.Columns["Barcode"].Visible = false;
            DGVReceiptDetails.Columns["UnitPrice"].Visible = false;
            DGVReceiptDetails.Columns["Tax"].Visible = false;
            DGVReceiptDetails.Columns["Username"].Visible = false;
            DGVReceiptDetails.Columns["ReceiptCode"].Visible = false;
            DGVReceiptDetails.Columns["PaymentMethod"].Visible = false;
            DGVReceiptDetails.Columns["Date"].Visible = false;
            DGVReceiptDetails.Columns["Total"].Visible = false;
            DGVReceiptDetails.Columns["TotalTax"].Visible = false;
            DGVReceiptDetails.Columns["Fullname"].Visible = false;

            DGVReceiptDetails.Columns["Quantity"].HeaderText = "Cantidad comprada";
            DGVReceiptDetails.Columns["DetailPrice"].HeaderText = "Precio detalle";
            DGVReceiptDetails.Columns["ProductName"].HeaderText = "Producto";
            DGVReceiptDetails.Columns["StockTypeName"].HeaderText = "Tipo de inventario";
            DGVReceiptDetails.Columns["CutName"].HeaderText = "Corte comprado";

            DGVReceiptDetails.Columns["ProductName"].DisplayIndex = 0;
            DGVReceiptDetails.Columns["Quantity"].DisplayIndex = 1;
            DGVReceiptDetails.Columns["StockTypeName"].DisplayIndex = 2;
            DGVReceiptDetails.Columns["CutName"].DisplayIndex = 3;

            DGVReceiptDetails.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            try
            {
                DialogResult dialog = MessageBox.Show("Está seguro que desea confirmar el pago de la factura?","Confirmar pago",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (receipt.ConfirmPayReceipt() == 1)
                    {
                        MessageBox.Show("Se ha confirmado el pago", "Pago confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Utilities.Utilities.CreateLog("ha confirmado el pago de la factura: " + receipt.ReceiptCode);
                        this.DialogResult = DialogResult.OK;
                        return;
                    }
                }
            }
            catch
            {

            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show("Desea reimprimir la factura?", "Reimprimir factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult1 == DialogResult.Yes)
            {
                ReportDocument report = new ReportDocument();
                report = new Report.Receipt();
                report = receipt.Print(report);
                Report.FrmReceiptVisualizer frm = new Report.FrmReceiptVisualizer();
                frm.ReportViewer.ReportSource = report;
                frm.ShowDialog();
            }
        }
    }
}
