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
            RegDate = DateTime.Now;
            LastUpdate = DateTime.Now;
            Detailed_Stock = new DetailedStock();
            Receipt_Details = new List<ReceiptDetails>();
        }

        public int CreateProduct()
        {
            SistemaMLPDataSetTableAdapters.ProductTableAdapter productAdapter = new SistemaMLPDataSetTableAdapters.ProductTableAdapter();

            int result = (int)productAdapter.SPInsertProduct(this.ProductName, this.BarCode, this.UnitPrice, this.Tax, this.StockType, this.GeneralStock,this.RegDate,this.LastUpdate);

            return result;
        }

        public int UpdateProduct()
        {
            SistemaMLPDataSetTableAdapters.ProductTableAdapter productAdapter = new SistemaMLPDataSetTableAdapters.ProductTableAdapter();

            int result = (int)productAdapter.SPUpdateProduct(this.IDProduct,this.ProductName, this.BarCode, this.UnitPrice, this.Tax, this.StockType, this.GeneralStock, this.LastUpdate);

            return result;
        }

        public int DeleteProduct()
        {
            SistemaMLPDataSetTableAdapters.ProductTableAdapter productAdapter = new SistemaMLPDataSetTableAdapters.ProductTableAdapter();

            int result = (int)productAdapter.SPDeleteProduct(this.IDProduct);

            return result;
        }

        public int RestoreProduct()
        {
            SistemaMLPDataSetTableAdapters.ProductTableAdapter productAdapter = new SistemaMLPDataSetTableAdapters.ProductTableAdapter();

            int result = (int)productAdapter.SPRestoreProduct(this.IDProduct);

            return result;
        }

        public int ProductStockEntry()
        {
            SistemaMLPDataSetTableAdapters.ProductTableAdapter productAdapter = new SistemaMLPDataSetTableAdapters.ProductTableAdapter();

            int result = (int)productAdapter.SPProductSupply(this.IDProduct, this.GeneralStock, this.LastUpdate);

            return result;
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

        public DataTable GetDeletedProducts(string filter = "")
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.ProductTableAdapter productsAdapter = new SistemaMLPDataSetTableAdapters.ProductTableAdapter();

            productsAdapter.FillByDeleted(sistemaMLPDataSet.Product, filter);
            return sistemaMLPDataSet.Product;
        }
    }
}