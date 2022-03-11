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

        public FrmProductCU()
        {
            InitializeComponent();
        }

        private void FrmProductCU_Load(object sender, EventArgs e)
        {

        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            FrmDetailStock frmDetailStock = new FrmDetailStock();
            if(detailedStocks != null)
            {
                frmDetailStock.stocks = detailedStocks;
            }

            if(frmDetailStock.ShowDialog() == DialogResult.OK)
            {
                decimal aux = 0;
                detailedStocks = frmDetailStock.stocks;
                foreach(DetailedStock stock in detailedStocks)
                {
                    aux += stock.Stock;
                }
                TxtStock.Text = aux.ToString();
            }
        }
        
        private bool ValidateAll()
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
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
            int i = 0;

            if (ValidateAll())
            {
                //TODO: Se registra el producto, metodo de registro retorna el id generado y se le asigna a i

                if(detailedStocks != null && i != 1)
                {
                    foreach (DetailedStock stock in detailedStocks)
                    {
                        stock.IDProduct = i;
                        //TODO: Registrar los detalles de stock
                    }
                }
            }
        }
    }
}
