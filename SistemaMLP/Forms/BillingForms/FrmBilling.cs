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

namespace SistemaMLP.Forms.BillingForms
{
    public partial class FrmBilling : Form
    {
        //TODO:
        //Decidir que hacer con el detalle de la factura, necesita llevar si se compro general, en filet o picado
        public Product product = new Product();
        public Customer customer = new Customer {
            IDCustomer = 1,
            Fullname = "Cliente particular"
        };
        public PaymentMethods paymentMethods = new PaymentMethods();
        public List<Product> products = new List<Product>();
        public DataTable lines = new DataTable();

        public FrmBilling()
        {
            InitializeComponent();
            DGVProducts.AutoGenerateColumns = true;
            DGVProducts.RowHeadersVisible = false;
            DGVLines.RowHeadersVisible = false;

        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            InitDT();
            FillDGV();
            FillCB();
            MdiParent = Utilities.Utilities.main;
        }

        private void FrmBilling_Shown(object sender, EventArgs e)
        {
            DGVProducts.ClearSelection();
        }


        private void KeyNavigation(object sender, KeyEventArgs e)
        {
            BtnSelectCustomer.Focus();
            if(e.KeyCode == Keys.Enter)
            {
                BtnSelectCustomer.Select();
            }
        }

        private void FillCB()
        {
            CbPaymentMethod.DisplayMember = "Name";
            CbPaymentMethod.ValueMember = "IDPaymentMethod";
            CbPaymentMethod.DataSource = paymentMethods.GetPaymentMethods();
        }
        private void FillDGV(string filter = "")
        {
            DGVProducts.DataSource = product.GetProducts(filter);
            SetDGV();

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSearch.Text.Trim()) && TxtSearch.Text.Count() >= 2)
            {
                FillDGV(TxtSearch.Text.Trim());
            }
            else
            {
                FillDGV();
            }

        }

        private void SetDGV()
        {
            DGVProducts.Columns["IDProduct"].Visible = false;
            DGVProducts.Columns["RegDate"].Visible = false;
            DGVProducts.Columns["LastUpdate"].Visible = false;
            DGVProducts.Columns["StockType"].Visible = false;
            DGVProducts.Columns["Active"].Visible = false;
            DGVProducts.Columns["StockTypeName"].DisplayIndex = 5;
            DGVProducts.Columns["BarCode"].DisplayIndex = 1;
            DGVProducts.Columns["StockTypeName"].HeaderText = "Tipo de stock";
            DGVProducts.Columns["StockTypeName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVProducts.Columns["GeneralStock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVProducts.Columns["ProductName"].HeaderText = "Producto";
            DGVProducts.Columns["GeneralStock"].HeaderText = "Stock en bodega";
            DGVProducts.Columns["BarCode"].HeaderText = "Código barras";
            DGVProducts.Columns["UnitPrice"].HeaderText = "Precio por unidad";
            DGVProducts.Columns["Tax"].HeaderText = "Impuesto";

            DGVLines.Columns["IDProduct"].Visible = false;
            DGVLines.Columns["RegDate"].Visible = false;
            DGVLines.Columns["LastUpdate"].Visible = false;
            DGVLines.Columns["StockType"].Visible = false;
            DGVLines.Columns["GeneralStock"].Visible = false;
            DGVLines.Columns["Active"].Visible = false;
            DGVLines.Columns["StockTypeName"].DisplayIndex = 5;
            DGVLines.Columns["BarCode"].DisplayIndex = 1;
            DGVLines.Columns["StockTypeName"].HeaderText = "Tipo de stock";
            DGVLines.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVLines.Columns["ProductName"].HeaderText = "Producto";
            DGVLines.Columns["LineType"].HeaderText = "Tipo de compra";
            DGVLines.Columns["StockTypeName"].Visible = false;
            DGVLines.Columns["GeneralStock"].HeaderText = "Stock en bodega";
            DGVLines.Columns["BarCode"].HeaderText = "Código barras";
            DGVLines.Columns["UnitPrice"].HeaderText = "Precio por unidad";
            DGVLines.Columns["Tax"].HeaderText = "Impuesto";
            DGVLines.Columns["Quantity"].HeaderText = "Cantidad Comprada";
        }

        private void InitDT()
        {
            lines.Columns.Add("IDProduct", typeof(int));
            lines.Columns.Add("ProductName", typeof(string));
            lines.Columns.Add("BarCode", typeof(string));
            lines.Columns.Add("UnitPrice", typeof(decimal));
            lines.Columns.Add("Tax", typeof(decimal));
            lines.Columns.Add("StockType", typeof(int));
            lines.Columns.Add("GeneralStock", typeof(decimal));
            lines.Columns.Add("RegDate", typeof(DateTime));
            lines.Columns.Add("LastUpdate", typeof(DateTime));
            lines.Columns.Add("Active", typeof(bool));
            lines.Columns.Add("StockTypeName", typeof(string));
            lines.Columns.Add("LineType", typeof(string));
            lines.Columns.Add("Quantity",typeof(decimal));
            DGVLines.DataSource = lines;
        }

        private void BtnSelectCustomer_Click(object sender, EventArgs e)
        {
            CustomerForms.FrmSelectCustomer frmSelectCustomer = new CustomerForms.FrmSelectCustomer();
            DialogResult dialogResult = frmSelectCustomer.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                customer = frmSelectCustomer.customer;
            }
            LblCustomerName.Text = customer.Fullname;
        }

        private void CbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbPaymentMethod.SelectedIndex == 1)
            {
                CkbConfirmed.Visible = true;
            }
            else
            {
                CkbConfirmed.Visible = false;
                CkbConfirmed.Checked = false;
            }
        }

        private void BtnBilling_Click(object sender, EventArgs e)
        {
            //TODO:
            //Cuando se vaya a validar la venta, validar que todos los campos necesarios esten, que los botones respectivos se activen y se desactiven
            //Validar que la cantidad selecionada no sea mayor al stock en bodega
            switch (CbPaymentMethod.SelectedIndex)
            {
                case 0:
                    //Cuando se factura en efectivo se establece el pago confirmado automaticamente
                    break;
                case 1:
                    //Cuando se factura en sinpe aparece el check para confirmar el pago, en caso de que no, igual se registra, luego se unas horas se notifica
                    //En caso de que sea por sinpe y con cliente particular, recomendar escribir una nota con el nombre del cliente
                    break;
                case 2:
                    //Validar que no este el cliente por defecto
                    //Cuando se factura con metodo de pago en credito, si no hay ninguno, aparece una opcion para crear
                    if(customer.IDCustomer != 1)
                    {
                        Credit credit = new Credit();
                        credit.Customer.IDCustomer = customer.IDCustomer;

                        if (credit.CustomerHasCredit())
                        {                            
                            credit.GetCustomerCredit();
                            if (credit.Total > 0)
                            {
                                CreditForms.FrmCreditConfirmation frmCreditConfirmation = new CreditForms.FrmCreditConfirmation();

                                frmCreditConfirmation.credit = credit;
                                frmCreditConfirmation.customer = customer;

                                DialogResult dialogResult = frmCreditConfirmation.ShowDialog();

                                if (dialogResult == DialogResult.OK)
                                {
                                    //Facturar()
                                }
                            }
                        }
                        else
                        {
                            //Se abre el dialog que dice que el cliente no tiene creditos, si desea crear uno
                            DialogResult dialogResult = MessageBox.Show("El cliente no tiene ningún crédito, ¿Crear uno nuevo?", "Cliente sin crédito", MessageBoxButtons.YesNo);

                            if (dialogResult == DialogResult.Yes)
                            {
                                //Facturar()
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error, no se puede registrar un crédito para un cliente particular", "Error", MessageBoxButtons.OK);
                    }
                    break;
                default:
                    //Default aparece algo, igual el boton no va a estar activo pero por si acaso
                    MessageBox.Show("Error del sistema", "Error", MessageBoxButtons.OK);
                    break;
            }
        }

        private void BtnAddLine_Click(object sender, EventArgs e)
        {
            //TODO:
            //Validar que no se agreguen lineas si no hay seleccionadas
            DataRow dr1 = lines.NewRow();
            
            if(DGVProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DGVProducts.SelectedRows[0];
                dr1["IDProduct"] = Convert.ToInt32(row.Cells["IDProduct"].Value);
                dr1["ProductName"] = Convert.ToString(row.Cells["ProductName"].Value);
                dr1["BarCode"] = Convert.ToString(row.Cells["BarCode"].Value);
                dr1["UnitPrice"] = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                dr1["Tax"] = Convert.ToDecimal(row.Cells["Tax"].Value);
                dr1["GeneralStock"] = Convert.ToInt32(row.Cells["GeneralStock"].Value);
                dr1["RegDate"] = Convert.ToDateTime(row.Cells["RegDate"].Value);
                dr1["LastUpdate"] = Convert.ToDateTime(row.Cells["LastUpdate"].Value);
                dr1["Active"] = Convert.ToBoolean(row.Cells["Active"].Value);
                dr1["StockTypeName"] = Convert.ToString(row.Cells["StockTypeName"].Value);
                dr1["Quantity"] = Convert.ToDecimal(UDQuantity.Value);

                if (!GbStockType.Visible)
                {
                    //Ver que hacer al registrar el tipo de corte en la linea, ver si se hace una tabla o que
                }

                lines.Rows.Add(dr1);
            }
        }

        private void DGVProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGVProducts.SelectedRows[0];
            DetailedStock detailedStock = new DetailedStock();
            detailedStock.GetProductDetailedStock(Convert.ToInt32(row.Cells["IDProduct"].Value));
            if(detailedStock.IDDetailedStock > 0)
            {
                GbStockType.Visible = true;
            }
            else
            {
                GbStockType.Visible = false;
            }

            if (e.RowIndex == -1 || e.ColumnIndex != 3)
            {
                return;
            }
                
        }
    }
}
