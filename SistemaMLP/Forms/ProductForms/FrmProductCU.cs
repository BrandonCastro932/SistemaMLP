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
    public partial class FrmProductCU : Form
    {
        //TODO: Si el stock es en cajas no se puede detallar

        public List<DetailedStock> detailedStocks { get; set; }
        public StockType stockType { get; set; }

        public FrmProductCU()
        {
            InitializeComponent();
            stockType = new StockType();
        }

        private void FrmProductCU_Load(object sender, EventArgs e)
        {
            FillCB();
        }

        private void FillCB()
        {
            CbStockType.DisplayMember = "StockTypeName";
            CbStockType.ValueMember = "IDStockType";

            CbStockType.DataSource = stockType.GetStockTypes();
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            FrmDetailStock frmDetailStock = new FrmDetailStock();
            if (detailedStocks != null)
            {
                frmDetailStock.stocks = detailedStocks;
            }

            if (frmDetailStock.ShowDialog() == DialogResult.OK)
            {
                decimal aux = 0;
                detailedStocks = frmDetailStock.stocks;
                foreach (DetailedStock stock in detailedStocks)
                {
                    aux += stock.Stock;
                }
                TxtStock.Text = aux.ToString();
            }
        }

        private bool ValidateAll()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;

                if (ValidateAll())
                {
                    //TODO: Se registra el producto, metodo de registro retorna el id generado y se le asigna a i

                    if (detailedStocks != null && i != 1)
                    {
                        foreach (DetailedStock stock in detailedStocks)
                        {
                            stock.IDProduct = i;
                            //TODO: Registrar los detalles de stock
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private bool IsKeyAChar(Keys key)
        {
            return key >= Keys.A && key <= Keys.Z;
        }

        private bool IsKeyADigit(Keys key)
        {
            return (key >= Keys.D0 && key <= Keys.D9) || (key >= Keys.NumPad0 && key <= Keys.NumPad9);
        }

        private void TxtProductName_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void TxtUnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsKeyAChar(e.KeyData))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TxtTax_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsKeyAChar(e.KeyData))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TxtStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsKeyAChar(e.KeyData))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void CbStockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbStockType.SelectedIndex == 1)
            {
                BtnDetail.Enabled = false;
                if(detailedStocks.Count > 0)
                {
                    detailedStocks.Clear();
                    TxtStock.Text = "";
                }
            }
            else
            {
                BtnDetail.Enabled = true;
            }
        }
    }
}
