using System;
using System.Data;

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

        public int CreateCreditPayment()
        {
            SistemaMLPDataSetTableAdapters.CreditPaymentsTableAdapter creditPaymentAdapter = new SistemaMLPDataSetTableAdapters.CreditPaymentsTableAdapter();

            int result = (int)creditPaymentAdapter.SPInsertCreditPayment(this.IDCreditDetail, this.PaymentAmount, this.RegDate);

            return result;
        }

        public DataTable GetCreditPayments()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.CreditPaymentsTableAdapter creditPaymentAdapter = new SistemaMLPDataSetTableAdapters.CreditPaymentsTableAdapter();

            creditPaymentAdapter.SPGetCreditPayments(sistemaMLPDataSet.CreditPayments, this.IDCreditDetail);
            return sistemaMLPDataSet.CreditPayments;
        }

        public DataTable PrintCredit()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.CreditPaymentsTableAdapter creditDetailAdapter = new SistemaMLPDataSetTableAdapters.CreditPaymentsTableAdapter();

            creditDetailAdapter.SPCreditPaymentsPrint(sistemaMLPDataSet.CreditPayments, IDCreditDetail);
            return sistemaMLPDataSet.CreditPayments;
        }
    }
}