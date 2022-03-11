using System;

namespace MLPlib.Class
{
    public class CreditPayments
    {
        public int IDCreditPayment { get; set; }
        public int IDCreditDetail { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime RegDate { get; set; }

        public CreditPayments()
        {

        }

    }
}