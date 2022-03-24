using System;
using System.Data;

namespace MLPlib.Class
{
    public class DetailedStock
    {
        public int IDDetailedStock { get; set; }
        public int IDProduct { get; set; }
        public int IDCutType { get; set; }
        public decimal Stock { get; set; }
        public DateTime RegDate { get; set; }


        public DetailedStock()
        {
            RegDate = DateTime.Now;
        }

        public int CreateDetailedStock()
        {
            SistemaMLPDataSetTableAdapters.DetailedStockTableAdapter detailedStockAdapter = new SistemaMLPDataSetTableAdapters.DetailedStockTableAdapter();

            int result = (int)detailedStockAdapter.SPInsertDetailedStock(this.IDProduct, this.IDCutType, this.Stock, this.RegDate);

            return result;
        }

        public int UpdateDetailedStock()
        {
            SistemaMLPDataSetTableAdapters.DetailedStockTableAdapter detailedStockAdapter = new SistemaMLPDataSetTableAdapters.DetailedStockTableAdapter();

            int result = (int)detailedStockAdapter.SPUpdateDetailedStock(this.IDDetailedStock, this.IDProduct, this.IDCutType, this.Stock, this.RegDate);

            return result;
        }

        public int DeleteDetailedStock()
        {
            SistemaMLPDataSetTableAdapters.DetailedStockTableAdapter detailedStockAdapter = new SistemaMLPDataSetTableAdapters.DetailedStockTableAdapter();

            int result = (int)detailedStockAdapter.SPDeleteDetailedStock(this.IDProduct);

            return result;
        }

        public void GetProductDetailedStock(int IDProduct)
        {
            DataTable data = new DataTable();
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.DetailedStockTableAdapter detailedStockAdapter = new SistemaMLPDataSetTableAdapters.DetailedStockTableAdapter();

            detailedStockAdapter.FillBy(sistemaMLPDataSet.DetailedStock, IDProduct);
            data = sistemaMLPDataSet.DetailedStock;
            if (data.Rows.Count > 0)
            {
                this.IDDetailedStock = Convert.ToInt32(data.Rows[0]["IDProduct"].ToString());

                this.RegDate = Convert.ToDateTime(data.Rows[0]["RegDate"].ToString());
            }

        }

    }
}