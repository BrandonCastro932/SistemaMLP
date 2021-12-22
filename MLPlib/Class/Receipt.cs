using System;
using System.Collections.Generic;

namespace MLPlib.Class
{
    public class Receipt
    {
        public int IDReceipt { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public bool PaymentConfirmed { get; set; }
        public List<ReceiptDetails> Receipt_Details { get; set; }
        public Customer IDCustomer { get; set; }
        public PaymentMethods PaymentMethod { get; set; }

        public Receipt()
        {
            IDCustomer = new Customer();
            Receipt_Details = new List<ReceiptDetails>();
            PaymentConfirmed = false;
            PaymentMethod = new PaymentMethods();
        }

    }
}