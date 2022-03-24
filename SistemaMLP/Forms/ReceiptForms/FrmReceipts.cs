using MLPlib.Class;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace SistemaMLP.Forms.ReceiptForms
{
    public partial class FrmReceipts : Form
    {
        Receipt receipt = new Receipt();
        Customer customer = new Customer();
        User user = new User();
        PaymentMethods paymentMethods = new PaymentMethods();

        public FrmReceipts()
        {
            InitializeComponent();
            MdiParent = Utilities.Utilities.main;

            FillDGV();
        }

        private void FrmReceipts_Load(object sender, EventArgs e)
        {

        }

        private void FillDGV(string filter = "")
        {
            DGVReceipts.DataSource = receipt.GetReceipts(filter);

            DGVReceipts.Columns["IDReceipt"].Visible = false;
            DGVReceipts.Columns["IDCustomer"].Visible = false;
            DGVReceipts.Columns["IDReceipt"].Visible = false;
            DGVReceipts.Columns["PaymentMethod"].Visible = false;
            DGVReceipts.Columns["IDUser"].Visible = false;
            DGVReceipts.Columns["PersonalID"].Visible = false;
            DGVReceipts.Columns["Username"].Visible = false;
            DGVReceipts.Columns["PaymentConfirmed"].Visible = false;
            DGVReceipts.Columns["Notes"].Visible = false;

            DGVReceipts.Columns["ReceiptCode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVReceipts.Columns["Fullname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVReceipts.Columns["ReceiptCode"].DisplayIndex = 0;
            DGVReceipts.Columns["Fullname"].DisplayIndex = 1;
            DGVReceipts.Columns["Total"].DisplayIndex = 2;
            DGVReceipts.Columns["TotalTax"].DisplayIndex = 3;
            DGVReceipts.Columns["Date"].DisplayIndex = 4;

            DGVReceipts.Columns["ReceiptCode"].HeaderText = "# Factura";
            DGVReceipts.Columns["Fullname"].HeaderText = "Cliente";
            DGVReceipts.Columns["Total"].HeaderText = "Total sin impuesto";
            DGVReceipts.Columns["TotalTax"].HeaderText = "Impuestos";
            DGVReceipts.Columns["Date"].HeaderText = "Fecha de venta";
            DGVReceipts.Columns["PaymentMethodName"].HeaderText = "Método de pago";

            DGVReceipts.Sort(DGVReceipts.Columns["Date"], ListSortDirection.Descending);

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSearch.Text.Trim()) && TxtSearch.Text.Count() >= 2)
            {
                FillDGV(TxtSearch.Text.Trim());
            }
            else
            {
                FillDGV();
            }
        }

        private void TxtSearch_MouseHover(object sender, EventArgs e)
        {
            TtSearch.SetToolTip(TxtSearch, "Búsqueda disponible por: Nombre, teléfono, correo electrónico y cédula del cliente, número de factura y método de pago");
        }

        private void DGVReceipts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

        }

        private void ReceiptDetails()
        {
            if (DGVReceipts.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = DGVReceipts.SelectedRows[0];
                receipt = new Receipt
                {
                    IDReceipt = Convert.ToInt32(dataRow.Cells["IDReceipt"].Value),
                    ReceiptCode = dataRow.Cells["ReceiptCode"].Value.ToString(),
                    IDCustomer = Convert.ToInt32(dataRow.Cells["IDCustomer"].Value),
                    IDUser = Convert.ToInt32(dataRow.Cells["IDUser"].Value),
                    IDPaymentMethod = Convert.ToInt32(dataRow.Cells["PaymentMethod"].Value),
                    Date = Convert.ToDateTime(dataRow.Cells["Date"].Value),
                    Total = Convert.ToDecimal(dataRow.Cells["Total"].Value),
                    TotalTax = Convert.ToDecimal(dataRow.Cells["TotalTax"].Value),
                    PaymentConfirmed = Convert.ToBoolean(dataRow.Cells["PaymentConfirmed"].Value),
                    Notes = dataRow.Cells["Notes"].Value.ToString()
                };

                user = new User
                {
                    IDUser = Convert.ToInt32(dataRow.Cells["IDUser"].Value),
                    Username = dataRow.Cells["Username"].Value.ToString(),
                };

                customer = new Customer
                {
                    IDCustomer = Convert.ToInt32(dataRow.Cells["IDCustomer"].Value),
                    PersonalID = dataRow.Cells["PersonalID"].Value.ToString(),
                    Fullname = dataRow.Cells["Fullname"].Value.ToString(),
                };

                paymentMethods = new PaymentMethods
                {
                    IDPaymentMethod = Convert.ToInt32(dataRow.Cells["PaymentMethod"].Value),
                    Name = dataRow.Cells["PaymentMethodName"].Value.ToString()
                };

                FrmReceiptDetails frm = new FrmReceiptDetails();

                frm.customer = customer;
                frm.receipt = receipt;
                frm.paymentMethods = paymentMethods;
                frm.user = user;

                DialogResult dialogResult = frm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    FillDGV();
                }
            }
        }

        private void DGVReceipts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ReceiptDetails();
            }
            catch
            {

            }
        }
    }
}
