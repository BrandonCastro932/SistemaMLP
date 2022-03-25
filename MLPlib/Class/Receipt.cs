using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;

namespace MLPlib.Class
{
    public class Receipt
    {
        public int IDReceipt { get; set; }
        public string ReceiptCode { get; set; }
        public int IDCustomer { get; set; }
        public int IDUser { get; set; }
        public int IDPaymentMethod { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public decimal TotalTax { get; set; }
        public bool PaymentConfirmed { get; set; }
        public string Notes { get; set; }
        public List<ReceiptDetails> Receipt_Details { get; set; }


        public Receipt()
        {
            Receipt_Details = new List<ReceiptDetails>();
            PaymentConfirmed = false;
            Date = DateTime.Now;
        }

        public int CreateReceipt()
        {
            SistemaMLPDataSetTableAdapters.ReceiptTableAdapter receiptAdapter = new SistemaMLPDataSetTableAdapters.ReceiptTableAdapter();

            int result = (int)receiptAdapter.SPInsertReceipt(this.ReceiptCode, this.IDCustomer, this.IDUser, this.IDPaymentMethod, this.Date, this.Total, this.TotalTax, this.PaymentConfirmed, this.Notes);

            return result;
        }

        public int ConfirmPayReceipt()
        {
            SistemaMLPDataSetTableAdapters.ReceiptTableAdapter receiptAdapter = new SistemaMLPDataSetTableAdapters.ReceiptTableAdapter();

            int result = (int)receiptAdapter.SPConfirmReceipt(this.IDReceipt);

            return result;
        }

        public DataTable GetReceipts(string filter = "")
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.ReceiptTableAdapter receiptsAdapter = new SistemaMLPDataSetTableAdapters.ReceiptTableAdapter();

            receiptsAdapter.SPGetReceipts(sistemaMLPDataSet.Receipt, filter);
            return sistemaMLPDataSet.Receipt;
        }

        public ReportDocument Print(ReportDocument repo)
        {
            ReportDocument r = repo;
            Crystal crystal = new Crystal(r);
            DataTable data = new DataTable();
            ReceiptDetails receiptDetails = new ReceiptDetails();
            receiptDetails.IDReceipt = this.IDReceipt;

            data = receiptDetails.GetReceiptDetails();


            if (data != null && data.Rows.Count > 0)
            {
                crystal.Data = data;
                r = crystal.GenerateReport();
            }

            return r;
        }

    }
}