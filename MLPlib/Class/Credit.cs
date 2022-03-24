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

        /*
        public bool CustomerHasCredit()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.CreditTableAdapter creditsAdapter = new SistemaMLPDataSetTableAdapters.CreditTableAdapter();

            creditsAdapter.FillBy(sistemaMLPDataSet.Credit, this.Customer.IDCustomer);
            if (sistemaMLPDataSet.Credit.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public void GetCustomerCredit()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.CreditTableAdapter creditsAdapter = new SistemaMLPDataSetTableAdapters.CreditTableAdapter();

            creditsAdapter.FillBy(sistemaMLPDataSet.Credit, this.Customer.IDCustomer);
            this.IDCredit = Convert.ToInt32(sistemaMLPDataSet.Credit[0].IDCustomer);
            this.Total = Convert.ToDecimal(sistemaMLPDataSet.Credit[0].Total);
            this.Canceled = Convert.ToBoolean(sistemaMLPDataSet.Credit[0].Canceled);
            this.RegDate = Convert.ToDateTime(sistemaMLPDataSet.Credit[0].RegDate);
        }
        */
    }
}