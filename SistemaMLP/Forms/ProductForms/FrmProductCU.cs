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
        public Product product1 = new Product();
        public DetailedStock detailedStock = new DetailedStock();
        public bool isCreating = true;
        public bool isEditing = false;

        public FrmProductCU()
        {
            InitializeComponent();
            stockType = new StockType();
            detailedStocks = new List<DetailedStock>();
        }

        private void FrmProductCU_Load(object sender, EventArgs e)
        {
            FillCB();
            if (isCreating)
            {
                LblTitle.Text = "Registrar Producto";
                BtnAccept.Text = "Registrar";
            }
            else if (isEditing)
            {
                LblTitle.Text = "Editar Producto";
                BtnAccept.Text = "Editar";
                FillTxt();
                GetProductDetailedStock();
            }
            LockStockTxt();

        }

        private void FillTxt()
        {
            TxtProductName.Text = product1.ProductName;
            TxtBarCode.Text = product1.BarCode;
            TxtUnitPrice.Text = product1.UnitPrice.ToString();
            TxtTax.Text = product1.Tax.ToString();
            TxtStock.Text = product1.GeneralStock.ToString();
            CbStockType.SelectedItem = product1.StockType;
        }

        private void LockStockTxt()
        {
            if (detailedStocks.Count > 0)
            {
                TxtStock.Enabled = false;
            }
            else
            {
                TxtStock.Enabled = true;
            }
        }

        private void FillCB()
        {
            CbStockType.DisplayMember = "StockTypeName";
            CbStockType.ValueMember = "IDStockType";

            CbStockType.DataSource = stockType.GetStockTypes();
        }

        private void GetProductDetailedStock()
        {
            //Convertir datatable en lista con linq
            DataView dv = new DataView(product1.GetProductDetailedStock());
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

            LockStockTxt();
        }

        private bool ValidateAll()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        if (c.Name != "TxtBarCode")
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (isCreating)
                {
                    CreateProduct();
                }
                else if (isEditing)
                {
                    UpdateProduct();
                }

            }
            catch
            {

            }
        }

        private void CreateProduct()
        {
            try
            {
                int i = 0;

                if (ValidateAll())
                {
                    //TODO: Se registra el producto, metodo de registro retorna el id generado y se le asigna a i
                    Product product = new Product
                    {
                        ProductName = TxtProductName.Text,
                        BarCode = TxtBarCode.Text,
                        UnitPrice = Convert.ToDecimal(TxtUnitPrice.Text),
                        Tax = Convert.ToDecimal(TxtTax.Text),
                        StockType = Convert.ToInt32(CbStockType.SelectedValue),
                        GeneralStock = Convert.ToDecimal(TxtStock.Text),
                        RegDate = DateTime.Now,
                        LastUpdate = DateTime.Now,
                        Active = true
                    };
                    i = product.CreateProduct();

                    if (i != 0 && i != -1)
                    {
                        if (detailedStocks != null && i > 0)
                        {
                            foreach (DetailedStock stock in detailedStocks)
                            {
                                stock.IDProduct = i;

                                if (stock.CreateDetailedStock() != 1)
                                {
                                    MessageBox.Show("Error, no se ha podido registrar uno de los inventarios detallados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }

                        }
                        MessageBox.Show("Se ha registrado el producto", "Producto registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Utilities.Utilities.CreateLog("Ha registrado un nuevo producto: " + product.ProductName);
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (i == -1)
                    {
                        //Duplicado
                        MessageBox.Show("Error, producto duplicado, verifique que el nombre y el código de barras", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (i == 0)
                    {
                        //Desconocido
                        MessageBox.Show("Error desconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, complete todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch
            {
                MessageBox.Show("Error desconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void UpdateProduct()
        {
            try
            {
                int i = 0;
                int j = 0;

                if (ValidateAll())
                {
                    //TODO: Se registra el producto, metodo de registro retorna el id generado y se le asigna a i
                    Product product = new Product
                    {
                        IDProduct = product1.IDProduct,
                        ProductName = TxtProductName.Text,
                        BarCode = TxtBarCode.Text,
                        UnitPrice = Convert.ToDecimal(TxtUnitPrice.Text),
                        Tax = Convert.ToDecimal(TxtTax.Text),
                        StockType = Convert.ToInt32(CbStockType.SelectedValue),
                        GeneralStock = Convert.ToDecimal(TxtStock.Text),
                        RegDate = DateTime.Now,
                        LastUpdate = DateTime.Now,
                        Active = true
                    };

                    i = product.UpdateProduct();

                    if (i != 0 && i != -1)
                    {
                        //Si se esta editando se borra el stock anterior y se crea uno nuevo 

                        detailedStock.IDProduct = product1.IDProduct;
                        j = detailedStock.DeleteDetailedStock();

                        if (detailedStocks != null && i > 0)
                        {
                            foreach (DetailedStock stock in detailedStocks)
                            {

                                stock.IDProduct = product1.IDProduct;

                                if (stock.CreateDetailedStock() != 1)
                                {
                                    MessageBox.Show("Error, no se ha podido registrar uno de los inventarios detallados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }

                        }
                        MessageBox.Show("Se ha actualizado el producto", "Producto actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Analizar si se hace una bitacora mas especifica
                        Utilities.Utilities.CreateLog("Ha actualizado un producto: " + product.ProductName);
                    }
                    else if (i == -1)
                    {
                        //Duplicado
                        MessageBox.Show("Error, datos del producto duplicados, verifique que el nombre y el código de barras", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (i == 0)
                    {
                        //Desconocido
                        MessageBox.Show("Error desconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Error desconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void CbStockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbStockType.SelectedIndex == 1)
            {
                BtnDetail.Enabled = false;
                if (detailedStocks.Count > 0)
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

        //TODO: Investigar como hacer esto en una sola funcion reutilizable
        private void TxtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            //Asi solo se permite una coma para los decimales
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtTax_KeyPress(object sender, KeyPressEventArgs e)
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
