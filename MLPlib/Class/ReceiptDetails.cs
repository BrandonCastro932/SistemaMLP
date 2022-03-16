using System;

namespace MLPlib.Class
{
    public class ReceiptDetails
    {
        public int IDDetail { get; set; }
        public int IDReceipt { get; set; }
        public int IDProduct { get; set; }
        public decimal Quantity { get; set; }
        public decimal DetailPrice { get; set; }

        public ReceiptDetails()
        {

        }
    }
}