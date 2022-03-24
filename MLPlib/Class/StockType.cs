using System.Data;

namespace MLPlib.Class
{
    public class StockType
    {
        public int IDStockType { get; set; }
        public string StockTypeName { get; set; }

        public StockType()
        {

        }

        public DataTable GetStockTypes()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.StockTypeTableAdapter stockTypeAdapter = new SistemaMLPDataSetTableAdapters.StockTypeTableAdapter();

            stockTypeAdapter.Fill(sistemaMLPDataSet.StockType);
            return sistemaMLPDataSet.StockType;
        }
    }
}
