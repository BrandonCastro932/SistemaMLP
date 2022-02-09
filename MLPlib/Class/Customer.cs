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
        public string PhoneNumber { get; set; }
        public string BusinessName { get; set; }
        public string BusinessPhoneNum { get; set; }
        public string Email { get; set; }
        public DateTime RegDate { get; set; }
        public bool Active { get; set; }

        public List<Receipt> Receipt { get; set; }

        public Customer()
        {
            Receipt = new List<Receipt>();
        }

        public int CreateCustomer()
        {
            SistemaMLPDataSetTableAdapters.CustomerTableAdapter customersAdapter = new SistemaMLPDataSetTableAdapters.CustomerTableAdapter();

            int result = (int)customersAdapter.SPInsertCustomer(this.PersonalID, this.Fullname,this.PhoneNumber, this.BusinessName,this.BusinessPhoneNum, this.Email);
             
            return result;
        }

        public int UpdateCustomer()
        {
            SistemaMLPDataSetTableAdapters.CustomerTableAdapter customersAdapter = new SistemaMLPDataSetTableAdapters.CustomerTableAdapter();

            int result = (int)customersAdapter.SPUpdateCustomer(this.PersonalID, this.Fullname, this.PhoneNumber, this.BusinessName, this.BusinessPhoneNum, this.Email);

            return result;
        }

        public int DeleteCustomer()
        {
            SistemaMLPDataSetTableAdapters.CustomerTableAdapter customersAdapter = new SistemaMLPDataSetTableAdapters.CustomerTableAdapter();

            int result = (int)customersAdapter.SPDeleteCustomer(this.PersonalID);

            return result;
        }

        public int RestoreCustomer()
        {
            SistemaMLPDataSetTableAdapters.CustomerTableAdapter customersAdapter = new SistemaMLPDataSetTableAdapters.CustomerTableAdapter();

            int result = (int)customersAdapter.SPRestoreCustomer(this.PersonalID);

            return result;
        }

        public DataTable GetCustomers(string filter = "")
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.CustomerTableAdapter customersAdapter = new SistemaMLPDataSetTableAdapters.CustomerTableAdapter();

            customersAdapter.FillBy(sistemaMLPDataSet.Customer, filter);
            return sistemaMLPDataSet.Customer;
        }

        public DataTable GetDeletedCustomers(string filter = "")
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.CustomerTableAdapter customersAdapter = new SistemaMLPDataSetTableAdapters.CustomerTableAdapter();

            customersAdapter.FillByDeleted(sistemaMLPDataSet.Customer, filter);
            return sistemaMLPDataSet.Customer;
        }

    }
}