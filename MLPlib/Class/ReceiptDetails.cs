using System;

namespace MLPlib.Class
{
    public class ReceiptDetails
    {
        public int IDDetail { get; set; }
        public decimal Quantity { get; set; }
        public Product Product { get; set; }

        public ReceiptDetails()
        {
            Product = new Product();
        }
    }
}