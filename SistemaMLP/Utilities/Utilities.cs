using MLPlib.Class;
using System;
using System.Windows.Forms;

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
        public static Forms.UserForms.FrmUsers frmUsers = new Forms.UserForms.FrmUsers();
        public static Forms.NotificationForms.FrmNotification frmNotification = new Forms.NotificationForms.FrmNotification();
        public static Forms.ReceiptForms.FrmReceipts frmReceipts = new Forms.ReceiptForms.FrmReceipts();
        public static Forms.CutTypesForms.FrmCutTypes frmCuts = new Forms.CutTypesForms.FrmCutTypes();
        public static Forms.WaitingForm.FrmWaiting frmWaiting = new Forms.WaitingForm.FrmWaiting();


        public static User user = new User();
       

        public static void CreateLog(string Msg)
        {
            MLPlib.SistemaMLPDataSetTableAdapters.LogTableAdapter logAdapter = new MLPlib.SistemaMLPDataSetTableAdapters.LogTableAdapter();

            logAdapter.SPLog(user.IDUser, user.Username + " " + Msg, DateTime.Now);
        }


    }
}
