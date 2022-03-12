using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLPlib.Class;

namespace SistemaMLP.Forms.ProductForms
{
    public partial class FrmDetailStock : Form
    {
        public List<DetailedStock> stocks = new List<DetailedStock>();
        public DataTable cutTypes = new DataTable();
        private CutTypes cutType = new CutTypes();
        public FrmDetailStock()
        {
            InitializeComponent();
        }

        private void FrmDetailStock_Load(object sender, EventArgs e)
        {
            FillCB();
            InitDGV();
        }

        private void FillCB()
        {
            CbType.DisplayMember = "CutName";
            CbType.ValueMember = "IDCutType";
            
            cutTypes = cutType.GetCutTypes();
            CbType.DataSource = cutTypes;
        }

        private bool ValidateAll()
        {
            if (CbType.SelectedIndex >= 0 && !string.IsNullOrWhiteSpace(TxtKg.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("No debe dejar espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void InitDGV()
        {
            DGVDetailedStock.Columns.Add("CutTypeDisplay", "Corte");
            DGVDetailedStock.Columns.Add("Stock", "KG");
            DGVDetailedStock.Columns.Add("IDCutType", "IDCutType");
            DGVDetailedStock.Columns.Add("RegDate", "RegDate");

            DGVDetailedStock.Columns["IDCutType"].Visible = false;
            DGVDetailedStock.Columns["RegDate"].Visible = false;

            //Aca si ya el producto tiene registrado kg detallado se inserta en el dgv y se quita del cb
            if (stocks.Count > 0)
            {
                foreach (DetailedStock stock in stocks)
                {
                    DGVDetailedStock.Rows.Add(CbType.GetItemText(CbType.Items[stock.IDCutType - 1]), stock.Stock, stock.IDCutType, stock.RegDate);                    
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateAll())
                {
                    DetailedStock stock = new DetailedStock
                    {
                        IDCutType = (int)CbType.SelectedValue,
                        Stock = Convert.ToDecimal(TxtKg.Text),
                        RegDate = DateTime.Now
                    };

                    if(stocks.Count > 0)
                    {
                        DetailedStock stock2 = new DetailedStock();
                        stock2 = stocks.Find(x => x.IDCutType.Equals(stock.IDCutType));
                        if (stock2 == null)
                        {
                            stocks.Add(stock);
                            DGVDetailedStock.Rows.Add(CbType.Text, stock.Stock, stock.IDCutType, stock.RegDate);
                        }
                        else
                        {
                            MessageBox.Show("No se permite ingresar datos duplicados","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }
                    else
                    {
                        stocks.Add(stock);
                        DGVDetailedStock.Rows.Add(CbType.Text, stock.Stock, stock.IDCutType, stock.RegDate);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al crear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVDetailedStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 3)
                return;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow dataRow = DGVDetailedStock.SelectedRows[0];


                stocks.Remove(stocks.Find(x => x.IDCutType.Equals(Convert.ToInt32(dataRow.Cells["IDCutType"].Value))));
                DGVDetailedStock.Rows.Remove(dataRow);

            }
            catch
            {
                MessageBox.Show("Ocurrió un error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TxtKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
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
