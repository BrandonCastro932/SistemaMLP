using System.Data;

namespace MLPlib.Class
{
    public class PaymentMethods
    {
        public int IDPaymentMethod { get; set; }
        public string Name { get; set; }

        public PaymentMethods()
        {

        }

        public DataTable GetPaymentMethods()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.PaymentMethodsTableAdapter paymentMethodAdapter = new SistemaMLPDataSetTableAdapters.PaymentMethodsTableAdapter();

            paymentMethodAdapter.Fill(sistemaMLPDataSet.PaymentMethods);
            return sistemaMLPDataSet.PaymentMethods;
        }
    }
}