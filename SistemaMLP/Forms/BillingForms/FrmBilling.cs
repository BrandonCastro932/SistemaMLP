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
        public Product product = new Product();
        public Customer customer = new Customer();
        public PaymentMethods paymentMethods = new PaymentMethods();

        public FrmBilling()
        {
            InitializeComponent();
            DGVProducts.AutoGenerateColumns = true;
        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            FillDGV();
            FillCB();
            
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
            DGVProducts.ClearSelection();
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
            DGVProducts.Columns["Tax"].HeaderText = "Impuesto";;
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
            switch (CbPaymentMethod.SelectedIndex)
            {
                //TODO
                case 0:
                    //Cuando se factura en efectivo se establece el pago confirmado automaticamente
                    break;
                case 1:
                    //Cuando se factura en sinpe aparece el check para confirmar el pago, en caso de que no, igual se registra, luego se unas horas se notifica
                    break;
                case 2:
                    //Cuando se factura con metodo de pago en credito, se abre una ventana para seleccionar un credito del cliente, si no hay ninguno, aparece una opcion para crear
                    break;
                default:
                    //Default aparece algo, igual el boton no va a estar activo
                    break;
            }
        }
    }
}
