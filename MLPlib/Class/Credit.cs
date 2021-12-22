using System;
using System.Collections.Generic;

namespace MLPlib.Class
{
    public class Credit
    {
        public int IDCredit { get; set; }
        public Customer Customer { get; set; }
        public decimal Total { get; set; }
        public bool Canceled { get; set; }
        public DateTime RegDate { get; set; }
        public List<CreditDetails> Credit_Details { get; set; }
        public List<CreditPayments> Credit_Payments { get; set; }

        public Credit()
        {
            Customer = new Customer();
            Canceled = false;
            Credit_Details = new List<CreditDetails>();
            Credit_Payments = new List<CreditPayments>();
        }
    }
}