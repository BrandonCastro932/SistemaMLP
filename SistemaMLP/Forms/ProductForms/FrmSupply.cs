using MLPlib.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMLP.Forms.ProductForms
{
    public partial class FrmSupply : Form
    {
        List<DetailedStock> detailedStocks = new List<DetailedStock>();
        Product product = new Product();
        public FrmSupply()
        {
            InitializeComponent();
        }
        private void FrmSupply_Load(object sender, EventArgs e)
        {
            MdiParent = Utilities.Utilities.main;
            FillDGV();
            BtnLayout();
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnLayout()
        {
            if(detailedStocks.Count > 0)
            {
                BtnDetail.Enabled = true;
                TxtStock.Enabled = false;
            }
            else
            {
                BtnDetail.Enabled = false;
                TxtStock.Enabled = true;
            }
        }

        private void GetProductDetailedStock()
        {
            //Convertir datatable en lista con linq
            DataView dv = new DataView(product.GetProductDetailedStock());
            DataTable dt = dv.ToTable(true, "IDDetailedStock", "IDProduct", "IDCutType", "Stock", "RegDate");

            detailedStocks = (from DataRow dr in dt.Rows
                              select new DetailedStock()
                              {
                                  IDDetailedStock = Convert.ToInt32(dr["IDDetailedStock"]),
                                  IDProduct = Convert.ToInt32(dr["IDProduct"]),
                                  IDCutType = Convert.ToInt32(dr["IDCutType"]),
                                  Stock = Convert.ToDecimal(dr["Stock"]),
                                  RegDate = Convert.ToDateTime(dr["RegDate"].ToString())
                              }).ToList();
        }

        private void FillDGV(string Filter = "")
        {
            //Llamada de datos
            DGVProduct.DataSource = product.GetProducts(Filter);

            //Visual
            DGVProduct.Columns["IDProduct"].Visible = false;

            DGVProduct.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVProduct.Columns["ProductName"].HeaderText = "Nombre del producto";

            DGVProduct.Columns["BarCode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVProduct.Columns["BarCode"].HeaderText = "Código de barras";

            DGVProduct.Columns["UnitPrice"].HeaderText = "Precio unitario";
            DGVProduct.Columns["UnitPrice"].Visible = false;

            DGVProduct.Columns["Tax"].HeaderText = "Impuesto(%)";
            DGVProduct.Columns["Tax"].Visible = false;

            DGVProduct.Columns["StockType"].Visible = false;

            DGVProduct.Columns["GeneralStock"].HeaderText = "Existencias";

            DGVProduct.Columns["RegDate"].Visible = false;
            DGVProduct.Columns["RegDate"].Visible = false;

            DGVProduct.Columns["LastUpdate"].HeaderText = "Ultimo abastecimiento";

            DGVProduct.Columns["Active"].Visible = false;
            DGVProduct.Columns["Active"].Visible = false;

            DGVProduct.Columns["StockTypeName"].HeaderText = "Tipo de inventario";
            DGVProduct.Columns["StockTypeName"].DisplayIndex = 4;
            DGVProduct.Columns["StockTypeName"].Visible = false;

            DGVProduct.RowHeadersVisible = false;

        }

        

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSearch.Text.Trim()) && TxtSearch.Text.Count() >= 1)
            {
                FillDGV(TxtSearch.Text.Trim());
            }
            else
            {
                FillDGV();
            }
        }

        private void DGVProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            DataGridViewRow dataRow = DGVProduct.SelectedRows[0];
            product = new Product
            {
                IDProduct = Convert.ToInt32(dataRow.Cells["IDProduct"].Value),
                ProductName = Convert.ToString(dataRow.Cells["ProductName"].Value),
                BarCode = Convert.ToString(dataRow.Cells["BarCode"].Value),
                UnitPrice = Convert.ToDecimal(dataRow.Cells["UnitPrice"].Value),
                Tax = Convert.ToDecimal(dataRow.Cells["Tax"].Value),
                StockType = Convert.ToInt32(dataRow.Cells["StockType"].Value),
                GeneralStock = Convert.ToDecimal(dataRow.Cells["GeneralStock"].Value),
                RegDate = Convert.ToDateTime(dataRow.Cells["RegDate"].Value),
                LastUpdate = Convert.ToDateTime(dataRow.Cells["LastUpdate"].Value),
                Active = Convert.ToBoolean(dataRow.Cells["Active"].Value)
            };
            GetProductDetailedStock();
            BtnLayout();

            if (e.RowIndex == -1 || e.ColumnIndex != 3)
                return;
        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
