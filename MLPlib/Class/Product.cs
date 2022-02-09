using System;
using System.Collections.Generic;
using System.Data;

namespace MLPlib.Class
{
    public class Product
    {
        public int IDProduct { get; set; }
        public string ProductName { get; set; }
        public string BarCode { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Tax { get; set; }
        public int StockType { get; set; }
        public decimal GeneralStock { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool Active { get; set; }

        public DetailedStock Detailed_Stock { get; set; }
        public List<ReceiptDetails> Receipt_Details { get; set; }

        public Product()
        {
            ProductName = string.Empty;
            BarCode = string.Empty;
            Active = true;
            Detailed_Stock = new DetailedStock();
            Receipt_Details = new List<ReceiptDetails>();
        }

        public DataTable GetProducts(string filter = "")
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.ProductTableAdapter productsAdapter = new SistemaMLPDataSetTableAdapters.ProductTableAdapter();

            productsAdapter.FillBy(sistemaMLPDataSet.Product, filter);
            return sistemaMLPDataSet.Product;
        }

        public DataTable GetProductDetailedStock()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.DetailedStockTableAdapter productsAdapter = new SistemaMLPDataSetTableAdapters.DetailedStockTableAdapter();

            productsAdapter.FillBy(sistemaMLPDataSet.DetailedStock,IDProduct);
            return sistemaMLPDataSet.DetailedStock;
        }
    }
}