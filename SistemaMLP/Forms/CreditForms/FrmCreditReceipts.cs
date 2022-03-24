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
    public partial class FrmCreditReceipts : Form
    {
        CreditDetails creditDetails = new CreditDetails();
        Customer customer = new Customer();
        Receipt receipt = new Receipt();
        public FrmCreditReceipts()
        {
            InitializeComponent();
            
            
        }

        private void FrmCreditReceipts_Load(object sender, EventArgs e)
        {
            MdiParent = Utilities.Utilities.main;
            FillDGV();
        }

        private void FillDGV(string filter = "")
        {
            DGVCredits.DataSource = creditDetails.GetCredits(filter);
            
            DGVCredits.Columns["IDCreditDetails"].Visible = false;
            DGVCredits.Columns["IDReceipt"].Visible = false;
            DGVCredits.Columns["IDCustomer"].Visible = false;
            DGVCredits.Columns["IDUser"].Visible = false;
            DGVCredits.Columns["PaymentMethod"].Visible = false;
            DGVCredits.Columns["PaymentConfirmed"].Visible = false;
            DGVCredits.Columns["Notes"].Visible = false;
            DGVCredits.Columns["PersonalID"].Visible = false;
            DGVCredits.Columns["PhoneNumber"].Visible = false;
            DGVCredits.Columns["BusinessName"].Visible = false;
            DGVCredits.Columns["BusinessPhoneNum"].Visible = false;
            DGVCredits.Columns["Email"].Visible = false;
            DGVCredits.Columns["Date"].Visible = false;
            DGVCredits.Columns["Total"].Visible = false;
            DGVCredits.Columns["TotalTax"].Visible = false;

            DGVCredits.Columns["ReceiptCode"].DisplayIndex = 0;
            DGVCredits.Columns["Fullname"].DisplayIndex = 1;
            DGVCredits.Columns["ActualAmount"].DisplayIndex = 2;
            DGVCredits.Columns["PreviousAmount"].DisplayIndex = 3;

            DGVCredits.Columns["ReceiptCode"].HeaderText = "# Factura";
            DGVCredits.Columns["Fullname"].HeaderText = "Cliente";
            DGVCredits.Columns["ActualAmount"].HeaderText = "Monto actual";
            DGVCredits.Columns["PreviousAmount"].HeaderText = "Monto anterior";

            DGVCredits.Columns["NextAmount"].Visible = false;
            DGVCredits.Columns["NextAmount"].HeaderText = "Monto siguiente";
            DGVCredits.Columns["RegDate"].HeaderText = "Fecha de registro";

            DGVCredits.Columns["ReceiptCode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVCredits.Columns["Fullname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVCredits.Columns["RegDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DGVCredits.ClearSelection();
        }

        private void DGVCredits_DoubleClick(object sender, EventArgs e)
        {
            CreditPayment();
        }

        private void BtnCreditPayment_Click(object sender, EventArgs e)
        {
            CreditPayment();
        }


        private void FrmCreditReceipts_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void DGVCredits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if(DGVCredits.SelectedRows.Count > 0)
            {
                BtnCreditPayment.Enabled = true;
            }
            else
            {
                BtnCreditPayment.Enabled = false;
            }
        }

        private void CleanForm()
        {
            TxtSearch.Text = "";
            BtnCreditPayment.Enabled = false;
            DGVCredits.ClearSelection();
            customer = new Customer();
            receipt = new Receipt();
            creditDetails = new CreditDetails();
        }

        private void CreditPayment()
        {
            if (DGVCredits.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = DGVCredits.SelectedRows[0];

                customer = new Customer
                {
                    IDCustomer = Convert.ToInt32(dataRow.Cells["IDCustomer"].Value),
                    PersonalID = Convert.ToString(dataRow.Cells["PersonalID"].Value),
                    Fullname = Convert.ToString(dataRow.Cells["Fullname"].Value)
                };

                receipt = new Receipt
                {
                    IDReceipt = Convert.ToInt32(dataRow.Cells["IDReceipt"].Value),
                    ReceiptCode = Convert.ToString(dataRow.Cells["ReceiptCode"].Value),
                    IDCustomer = customer.IDCustomer,
                    IDUser = Convert.ToInt32(dataRow.Cells["IDUser"].Value),
                    IDPaymentMethod = Convert.ToInt32(dataRow.Cells["PaymentMethod"].Value),
                    Date = Convert.ToDateTime(dataRow.Cells["Date"].Value),
                    Total = Convert.ToDecimal(dataRow.Cells["Total"].Value),
                    TotalTax = Convert.ToDecimal(dataRow.Cells["TotalTax"].Value),
                    PaymentConfirmed = Convert.ToBoolean(dataRow.Cells["PaymentConfirmed"].Value),
                    Notes = Convert.ToString(dataRow.Cells["Notes"].Value)
                };

                creditDetails = new CreditDetails
                {
                    IDCreditDetails = Convert.ToInt32(dataRow.Cells["IDCreditDetails"].Value),
                    IDReceipt = receipt.IDReceipt,
                    PreviousAmount = Convert.ToDecimal(dataRow.Cells["PreviousAmount"].Value),
                    ActualAmount = Convert.ToDecimal(dataRow.Cells["ActualAmount"].Value),
                    NextAmount = Convert.ToDecimal(dataRow.Cells["NextAmount"].Value),
                    RegDate = Convert.ToDateTime(dataRow.Cells["RegDate"].Value)
                };

                CreditForms.FrmCreditPayment frmInfo = new CreditForms.FrmCreditPayment();
                frmInfo.customer = customer;
                frmInfo.creditDetails = creditDetails;
                frmInfo.receipt = receipt;


                DialogResult dialogResult = frmInfo.ShowDialog();
                FillDGV();
                BtnCreditPayment.Enabled = false;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSearch.Text.Trim()) && TxtSearch.Text.Count() >= 1)
            {
                FillDGV(TxtSearch.Text.Trim());
            }
            else
            {
                FillDGV();
            }
        }
    }
}
