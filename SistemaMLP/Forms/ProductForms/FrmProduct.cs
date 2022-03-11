using MLPlib.Class;
using SistemaMLP.Forms.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMLP.Forms.CustomerForms
{
    public partial class FrmProduct : Form
    {
        private Product product = new Product();
        private bool DeletedMode = false;
        public FrmProduct()
        {
            InitializeComponent();
            FillDGV();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FrmProductCU frmProductCU = new FrmProductCU();
            frmProductCU.ShowDialog();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            MdiParent = Utilities.Utilities.main;
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

            DGVProduct.Columns["Tax"].HeaderText = "Impuesto(%)";

            DGVProduct.Columns["StockType"].Visible = false;

            DGVProduct.Columns["GeneralStock"].HeaderText = "Existencias";

            DGVProduct.Columns["RegDate"].Visible = false;

            DGVProduct.Columns["LastUpdate"].HeaderText = "Ultimo abastecimiento";

            DGVProduct.Columns["Active"].Visible = false;

            DGVProduct.Columns["StockTypeName"].HeaderText = "Tipo de inventario";
            DGVProduct.Columns["StockTypeName"].DisplayIndex = 4;

            DGVProduct.RowHeadersVisible = false;

        }
        private void IdleLayout()
        {
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnCreate.Enabled = true;
            DGVProduct.ClearSelection();
            BtnDelete.Text = "Eliminar cliente";
        }

        private void DeletedModeLayout()
        {
            BtnCreate.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = true;
            BtnDelete.Text = "Restaurar cliente";
        }
        private void ProductSelectedLayout()
        {
            if (!DeletedMode)
            {
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = true;
            }
        }

        private void DGVProduct_DoubleClick(object sender, EventArgs e)
        {
            if(DGVProduct.SelectedRows.Count > 0)
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
                ProductForms.FrmProductFullInfo frmInfo = new ProductForms.FrmProductFullInfo();
                frmInfo.product = product;
                frmInfo.StockTypeName = Convert.ToString(dataRow.Cells["StockTypeName"].Value);

                DialogResult dialogResult = frmInfo.ShowDialog();

            }

            
        }

        private void DGVProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductSelectedLayout();
            if (e.RowIndex == -1 || e.ColumnIndex != 3)
                return;
        }
    }
}
