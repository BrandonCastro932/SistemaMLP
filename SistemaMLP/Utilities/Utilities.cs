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
        public static Forms.ProductForms.FrmSupply frmSupply = new Forms.ProductForms.FrmSupply();
        public static Forms.LogForm.FrmLog frmLog = new Forms.LogForm.FrmLog();
        public static Forms.CreditForms.FrmCreditReceipts frmCredit = new Forms.CreditForms.FrmCreditReceipts();

        public static User user = new User
        {
            IDUser = 2,
            Username = "Brandon",
            Active = true,
        };

        public static void CreateLog(string Msg)
        {
            MLPlib.SistemaMLPDataSetTableAdapters.LogTableAdapter logAdapter = new MLPlib.SistemaMLPDataSetTableAdapters.LogTableAdapter();

            logAdapter.SPLog(user.IDUser, user.Username+" "+Msg, DateTime.Now);
        }

    }
}
