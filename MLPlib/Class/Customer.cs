using System;
using System.Collections.Generic;
using System.Data;

namespace MLPlib.Class
{
    public class Customer
    {
        public int IDCustomer { get; set; }
        public string PersonalID { get; set; }
        public string Fullname { get; set; }
        public string BusinessName { get; set; }
        public string Email { get; set; }
        public DateTime RegDate { get; set; }
        public bool Active { get; set; }

        public List<Receipt> Receipt { get; set; }

        public Customer()
        {
            Receipt = new List<Receipt>();
        }

        public DataTable GetCustomers(string filter = "")
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.CustomerTableAdapter customersAdapter = new SistemaMLPDataSetTableAdapters.CustomerTableAdapter();

            customersAdapter.FillBy(sistemaMLPDataSet.Customer, filter);
            return sistemaMLPDataSet.Customer;
        }

    }
}