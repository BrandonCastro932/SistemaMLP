using System;
using System.Data;

namespace MLPlib.Class
{
    public class DetailedStock
    {
        public int IDDetailedStock { get; set; }
        public decimal FiletStock { get; set; }
        public decimal ChoppedStock { get; set; }
        public decimal Waste { get; set; }
        public DateTime RegDate { get; set; }


        public DetailedStock()
        {

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
                this.FiletStock = Convert.ToDecimal(data.Rows[0]["FiletStock"].ToString());
                this.ChoppedStock = Convert.ToDecimal(data.Rows[0]["ChoppedStock"].ToString());
                this.Waste = Convert.ToDecimal(data.Rows[0]["Waste"].ToString());
                this.RegDate = Convert.ToDateTime(data.Rows[0]["RegDate"].ToString());
            }

        }

    }
}