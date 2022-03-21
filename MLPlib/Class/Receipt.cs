using System;
using System.Collections.Generic;

namespace MLPlib.Class
{
    public class Receipt
    {
        public string IDReceipt { get; set; }
        public string IDCustomer { get; set; }
        public int IDUser { get; set; }
        public int IDPaymentMethod { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public bool PaymentConfirmed { get; set; }
        public string Notes { get; set; }
        public List<ReceiptDetails> Receipt_Details { get; set; }


        public Receipt()
        {
            Receipt_Details = new List<ReceiptDetails>();
            PaymentConfirmed = false;
        }

    }
}