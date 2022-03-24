using System.Data;

namespace MLPlib.Class
{
    public class ReceiptDetails
    {
        public int IDDetail { get; set; }
        public int IDReceipt { get; set; }
        public int IDProduct { get; set; }
        public int? IDCutType { get; set; }
        public decimal Quantity { get; set; }
        public decimal DetailPrice { get; set; }

        public ReceiptDetails()
        {

        }

        public int CreateReceiptDetail()
        {
            SistemaMLPDataSetTableAdapters.ReceiptDetailsTableAdapter receiptDetailsAdapter = new SistemaMLPDataSetTableAdapters.ReceiptDetailsTableAdapter();

            int result = (int)receiptDetailsAdapter.SPInsertReceiptDetail(this.IDReceipt, this.IDProduct, this.IDCutType, this.Quantity, this.DetailPrice);

            return result;
        }

        public DataTable GetReceiptDetails()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.ReceiptDetailsTableAdapter receiptDetailsAdapter = new SistemaMLPDataSetTableAdapters.ReceiptDetailsTableAdapter();

            receiptDetailsAdapter.FillBy(sistemaMLPDataSet.ReceiptDetails,this.IDReceipt);
            return sistemaMLPDataSet.ReceiptDetails;
        }
    }
}