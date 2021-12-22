using System;

namespace MLPlib.Class
{
    public class CreditDetails
    {

        public int IDCreditDetails { get; set; }
        public Receipt Receipt { get; set; }
        public DateTime RegDate { get; set; }

        public CreditDetails()
        {
            Receipt = new Receipt();
        }
    }
}