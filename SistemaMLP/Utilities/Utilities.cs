using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLPlib.Class;

namespace SistemaMLP.Utilities
{
    public static class Utilities
    {
        public static Form main = new Forms.FrmMain();
        public static Forms.BillingForms.FrmBilling frmBilling = new Forms.BillingForms.FrmBilling();
        public static Forms.CustomerForms.FrmCustomers frmCustomers = new Forms.CustomerForms.FrmCustomers();
        public static Forms.CustomerForms.FrmProduct frmProduct = new Forms.CustomerForms.FrmProduct();
        public static User User = new User();
    }
}
