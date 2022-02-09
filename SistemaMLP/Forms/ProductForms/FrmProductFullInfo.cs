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
    public partial class FrmProductFullInfo : Form
    {
        public Product product = new Product();
        public DetailedStock detailed = new DetailedStock();
        public string StockTypeName = "";
        public FrmProductFullInfo()
        {
            InitializeComponent();
        }

        private void FrmProductFullInfo_Load(object sender, EventArgs e)
        {
            FillInfo();
            FillEmptySpaces();
            FillDGV();

        }

        private void FillDGV()
        {
            //Llamada de datos
            DGVDetailedStock.DataSource = product.GetProductDetailedStock();

            //Visual
            DGVDetailedStock.Columns["IDDetailedStock"].Visible = false;
            DGVDetailedStock.Columns["IDProduct"].Visible = false;
            DGVDetailedStock.Columns["IDCutType"].Visible = false;
            DGVDetailedStock.Columns["ProductName"].Visible = false;

            DGVDetailedStock.Columns["RegDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVDetailedStock.Columns["RegDate"].HeaderText = "Fecha de registro";

            DGVDetailedStock.Columns["CutName"].DisplayIndex = 0;
            DGVDetailedStock.Columns["CutName"].HeaderText = "Corte";

            DGVDetailedStock.Columns["Stock"].DisplayIndex = 1;
            DGVDetailedStock.Columns["Stock"].HeaderText = "Existencias";

            DGVDetailedStock.RowHeadersVisible = false;

            if(DGVDetailedStock.Rows.Count > 0)
            {
                DGVDetailedStock.Visible = true;
                LblDetailedTlt.Visible = true;
            }
            else
            {
                DGVDetailedStock.Visible = false;
                LblDetailedTlt.Visible = false;
            }

        }

        private void FillInfo()
        {
            LblProductName.Text = product.ProductName;
            LblBarCode.Text = product.BarCode;
            LblUnitPrice.Text = "₡" + product.UnitPrice.ToString();
            LblTax.Text = product.Tax.ToString() + "%";
            LblStockType.Text = StockTypeName;
            LblGeneralStock.Text = product.GeneralStock.ToString() + " " + StockTypeName;
            LblRegDate.Text = product.RegDate.ToString();
            LblLastUpdate.Text = product.LastUpdate.ToString();
        }

        private void FillEmptySpaces()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    if(control.Text == "")
                    {
                        control.Text = "Sin especificar";
                    }
                }
            }
        }
    }
}
