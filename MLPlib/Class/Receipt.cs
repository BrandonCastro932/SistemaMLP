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

        public DataTable GetReceipts(string filter = "")
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.ReceiptTableAdapter receiptsAdapter = new SistemaMLPDataSetTableAdapters.ReceiptTableAdapter();

            receiptsAdapter.SPGetReceipts(sistemaMLPDataSet.Receipt, filter);
            return sistemaMLPDataSet.Receipt;
        }

    }
}