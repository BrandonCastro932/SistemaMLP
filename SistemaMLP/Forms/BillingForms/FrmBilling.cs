using MLPlib.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaMLP.Forms.BillingForms
{
    public partial class FrmBilling : Form
    {
        //TODO:
        //Decidir que hacer con el detalle de la factura, necesita llevar si se compro general, en filet o picado
        public Product product = new Product();
        public List<DetailedStock> detailedStocks = new List<DetailedStock>();
        public List<CutTypes> cutTypes = new List<CutTypes>();

        decimal total = 0;
        decimal tax = 0;
        decimal subtotal = 0;

        public Customer customer = new Customer
        {
            IDCustomer = 1,
            Fullname = "Cliente particular",
            PersonalID = "1"
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
            IdleLayout();
            MdiParent = Utilities.Utilities.main;
        }

        private void IdleLayout()
        {
            BtnDelLine.Enabled = false;
            DGVLines.ClearSelection();
            DGVProducts.ClearSelection();
        }

        private void CleanForm()
        {
            IdleLayout();
            customer = new Customer
            {
                IDCustomer = 1,
                Fullname = "Cliente particular",
                PersonalID = "1"
            };
            CbPaymentMethod.SelectedValue = 1;
            LblCustomerName.Text = customer.Fullname;
            lines.Clear();
            FillDGV();
            SetTxtTotal();
        }

        private void FrmBilling_Shown(object sender, EventArgs e)
        {
            DGVProducts.ClearSelection();
        }

        private void GetProductDetailedStock()
        {
            //Convertir datatable en lista con linq
            DataView dv = new DataView(product.GetProductDetailedStock());
            DataTable dt = dv.ToTable(true, "IDDetailedStock", "IDProduct", "IDCutType", "Stock", "RegDate", "CutName");

            cutTypes = (from DataRow dr in dt.Rows
                        select new CutTypes()
                        {
                            IDCutType = Convert.ToInt32(dr["IDCutType"]),
                            CutName = Convert.ToString(dr["CutName"]),

                        }).ToList();

            detailedStocks = (from DataRow dr in dt.Rows
                              select new DetailedStock()
                              {
                                  IDDetailedStock = Convert.ToInt32(dr["IDDetailedStock"]),
                                  IDProduct = Convert.ToInt32(dr["IDProduct"]),
                                  IDCutType = Convert.ToInt32(dr["IDCutType"]),
                                  Stock = Convert.ToDecimal(dr["Stock"]),
                                  RegDate = Convert.ToDateTime(dr["RegDate"].ToString())
                              }).ToList();


            if (cutTypes.Count > 0)
            {
                CbCuts.Visible = true;
                LblCuts.Visible = true;
                CbCuts.DataSource = cutTypes;
            }
            else
            {
                CbCuts.Visible = false;
                LblCuts.Visible = false;
                CbCuts.DataSource = null;
                CbCuts.Items.Clear();
            }
        }


        private void FillCB()
        {
            CbPaymentMethod.DisplayMember = "PaymentMethod";
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
            if (!string.IsNullOrEmpty(TxtSearch.Text.Trim()) && TxtSearch.Text.Count() >= 1)
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
            DGVProducts.Columns["StockTypeDetail"].Visible = false;
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
            DGVLines.Columns["IDCutType"].Visible = false;
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
            lines.Columns.Add("IDCutType", typeof(int));
            lines.Columns.Add("LineType", typeof(string));
            lines.Columns.Add("Quantity", typeof(decimal));

            DGVLines.DataSource = lines;
        }

        private void BtnSelectCustomer_Click(object sender, EventArgs e)
        {
            CustomerForms.FrmSelectCustomer frmSelectCustomer = new CustomerForms.FrmSelectCustomer();
            DialogResult dialogResult = frmSelectCustomer.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                customer = frmSelectCustomer.customer;
            }
            LblCustomerName.Text = customer.Fullname;
        }

        private void CbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbPaymentMethod.SelectedIndex == 1)
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
            try
            {
                DialogResult dialogResult = MessageBox.Show("Está seguro que desea registrar la factura?", "Registrar factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //TODO:
                    //Cuando se vaya a validar la venta, validar que todos los campos necesarios esten, que los botones respectivos se activen y se desactiven
                    //Validar que la cantidad selecionada no sea mayor al stock en bodega
                    DateTime dt = DateTime.Now;
                    int year = dt.Year;
                    int month = dt.Month;
                    int date = dt.Day;
                    int hour = dt.Hour;
                    int min = dt.Minute;
                    int sec = dt.Second;


                    Receipt receipt = new Receipt
                    {
                        ReceiptCode = year.ToString() + month.ToString() + date.ToString() + hour.ToString() + min.ToString() + sec.ToString() + customer.PersonalID.ToString(),
                        IDCustomer = customer.IDCustomer,
                        IDUser = Utilities.Utilities.user.IDUser,
                        IDPaymentMethod = Convert.ToInt32(CbPaymentMethod.SelectedValue),
                        Date = dt,
                        Notes = TxtNotes.Text,
                        Total = total,
                        TotalTax = tax
                    };
                    

                    switch (CbPaymentMethod.SelectedIndex)
                    {
                        case 0:
                            //Cuando se factura en efectivo se establece el pago confirmado automaticamente
                            receipt.PaymentConfirmed = true;

                            break;
                        case 1:
                            //Cuando se factura en sinpe aparece el check para confirmar el pago, en caso de que no, igual se registra, luego se unas horas se notifica
                            //En caso de que sea por sinpe y con cliente particular, recomendar escribir una nota con el nombre del cliente
                            receipt.PaymentConfirmed = CkbConfirmed.Checked;
                            break;
                        case 2:
                            if (customer.IDCustomer == 1)
                            {
                                MessageBox.Show("Error, no se puede registrar una factura a crédito sin seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        default:
                            //Default aparece algo, igual el boton no va a estar activo pero por si acaso
                            MessageBox.Show("Error del sistema", "Error", MessageBoxButtons.OK);
                            break;
                    }

                    //TODO: Validar lo necesario
                    int i = receipt.CreateReceipt();
                    if (i != 0)
                    {
                        receipt.IDReceipt = i;
                        foreach (DataRow dr in lines.Rows)
                        {
                            ReceiptDetails receiptDetails = new ReceiptDetails
                            {
                                IDReceipt = i,
                                IDProduct = Convert.ToInt32(dr["IDProduct"].ToString()),

                                Quantity = Convert.ToDecimal(dr["Quantity"].ToString()),
                                DetailPrice = (Convert.ToDecimal(dr["Quantity"].ToString()) * Convert.ToDecimal(dr["UnitPrice"].ToString()) * (Convert.ToDecimal(dr["Tax"].ToString()) / 100))

                            };

                            if (dr["IDCutType"].ToString() != String.Empty)
                            {
                                receiptDetails.IDCutType = Convert.ToInt32(dr["IDCutType"].ToString());
                            }
                            else if(dr["IDCutType"].ToString() == String.Empty && product.StockType == 1)
                            {
                                receiptDetails.IDCutType = 1;
                            }

                            int j = receiptDetails.CreateReceiptDetail();
                            if (j != 1)
                            {
                                MessageBox.Show("Error, no se ha podido registrar una de las líneas.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        if (Convert.ToInt32(CbPaymentMethod.SelectedValue) == 3)
                        {
                            CreditDetails creditDetails = new CreditDetails
                            {
                                IDReceipt = i,
                                PreviousAmount = subtotal,
                                ActualAmount = subtotal,
                                NextAmount = subtotal
                            };
                            int k = creditDetails.CreateCreditDetail();
                            if (k != 1)
                            {
                                MessageBox.Show("Error, no se ha podido registrar la factura a crédito", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        MessageBox.Show("Se ha registrado la factura de manera exitosa", "Factura registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        

                        Utilities.Utilities.CreateLog("ha registrado la factura número: " + receipt.ReceiptCode);
                        CleanForm();
                    }
                    else if (i == 2)
                    {
                        MessageBox.Show("Error, no se ha podido registrar la factura, código duplicado", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (i == 0)
                    {
                        MessageBox.Show("Error desconocido", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }

        }

        private void BtnAddLine_Click(object sender, EventArgs e)
        {
            //TODO:
            //VALIDAR QUE SI SON CAJAS O PAQUETES NO SE PUEDA AGREGAR CON DECIMALES

            DataRow dr1 = lines.NewRow();
            bool exists = false;

            if (DGVProducts.SelectedRows.Count > 0)
            {
                if(UDQuantity.Value > 0)
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

                    if (CbCuts.Visible)
                    {
                        dr1["LineType"] = Convert.ToString(CbCuts.Text);
                        dr1["IDCutType"] = CbCuts.SelectedValue;
                    }
                    //Ojo el visible de este if
                    else if (!CbCuts.Visible && dr1["StockTypeName"].ToString() == "Kilos")
                    {
                        dr1["LineType"] = "Kilos";
                        dr1["IDCutType"] = 1;
                    }
                    else
                    {
                        dr1["LineType"] = dr1["StockTypeName"].ToString();
                    }

                    if (lines.Rows.Count == 0 && ValidateStock(Convert.ToDecimal(dr1["GeneralStock"].ToString())))
                    {
                        if (dr1["StockTypeName"].ToString() == "Cajas" && !int.TryParse(dr1["Quantity"].ToString(), out int n) || dr1["StockTypeName"].ToString() == "Paquetes" && !int.TryParse(dr1["Quantity"].ToString(), out int k))
                        {
                            MessageBox.Show("No se permite agregar el número de cajas o paquetes en decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UDQuantity.Value = 1;
                            exists = false;
                            return;
                        }
                        lines.Rows.Add(dr1);
                        BillingLayout();
                    }
                    else if (lines.Rows.Count == 0 && !ValidateStock(Convert.ToDecimal(dr1["GeneralStock"].ToString())))
                    {
                        exists = true;
                        MessageBox.Show("No se permite agregar más del stock existente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (dr1["StockTypeName"].ToString() != "Cajas" && dr1["StockTypeName"].ToString() != "Paquetes")
                        {
                            foreach (DataRow dr in lines.Rows)
                            {
                                if (dr["IDProduct"].ToString() == dr1["IDProduct"].ToString())
                                {
                                    if (detailedStocks.Count == 0)
                                    {
                                        if (Convert.ToDecimal(dr["Quantity"].ToString()) + Convert.ToDecimal(dr1["Quantity"].ToString()) <= Convert.ToDecimal(dr1["GeneralStock"].ToString()) && ValidateStock(Convert.ToDecimal(dr1["GeneralStock"].ToString())))
                                        {
                                            //Ahora validar que si la linea agregada tiene stock detallado, esta no pase de lo registrado

                                            dr["Quantity"] = Convert.ToDecimal(dr["Quantity"]) + Convert.ToDecimal(dr1["Quantity"]);
                                            lines.AcceptChanges();
                                            exists = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se permite agregar más del stock existente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            exists = true;
                                        }
                                    }
                                    else
                                    {
                                        DetailedStock detailed = new DetailedStock();
                                        detailed = detailedStocks.FirstOrDefault(x => x.IDCutType.Equals(Convert.ToInt32(CbCuts.SelectedValue)));
                                        //Que si se agrega un corte distinto se agrege como una nueva linea

                                        if (dr["LineType"].ToString() == CbCuts.Text.ToString() && UDQuantity.Value <= detailed.Stock && ValidateStock(detailed.Stock))
                                        {
                                            if (Convert.ToDecimal(dr["Quantity"].ToString()) + Convert.ToDecimal(dr1["Quantity"].ToString()) <= Convert.ToDecimal(detailed.Stock))
                                            {
                                                dr["Quantity"] = Convert.ToDecimal(dr["Quantity"]) + Convert.ToDecimal(dr1["Quantity"]);
                                                lines.AcceptChanges();
                                                exists = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("No se permite agregar más del stock existente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                exists = true;
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        else
                        {
                            if (dr1["StockTypeName"].ToString() == "Cajas" && !int.TryParse(dr1["Quantity"].ToString(), out int n) || dr1["StockTypeName"].ToString() == "Paquetes" && !int.TryParse(dr1["Quantity"].ToString(), out int k))
                            {
                                MessageBox.Show("No se permite agregar el número de cajas o paquetes en decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                exists = true;
                                UDQuantity.Value = 1;
                            }
                        }
                        if (!exists)
                        {
                            lines.Rows.Add(dr1);
                            BillingLayout();
                            UDQuantity.Value = 1;
                        }



                    }
                }
                else
                {
                    MessageBox.Show("Solo se permite agregar 1 o más", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            lines.AcceptChanges();
            DGVProducts.ClearSelection();
            CbCuts.Visible = false;
            LblCuts.Visible = false;
            CbCuts.DataSource = null;
            CbCuts.Items.Clear();
            UDQuantity.Value = 1;
            SetTxtTotal();
        }

        private void BillingLayout()
        {
            if (lines.Rows.Count > 0)
            {
                BtnBilling.Enabled = true;
            }
            else
            {
                BtnBilling.Enabled = false;
            }
        }

        private bool ValidateStock(decimal Stock)
        {
            //TODO: Si un producto tiene stock detallado
            if (UDQuantity.Value <= Stock)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetTxtTotal()
        {
            total = 0;
            tax = 0;
            subtotal = 0;
            if (DGVLines.Rows.Count > 0)
            {
                foreach (DataGridViewRow dr1 in DGVLines.Rows)
                {

                    total += Convert.ToDecimal(dr1.Cells["UnitPrice"].Value) * Convert.ToDecimal(dr1.Cells["Quantity"].Value);
                    if (CBTax.Checked)
                    {
                        tax += Convert.ToDecimal(dr1.Cells["UnitPrice"].Value) * (Convert.ToDecimal(dr1.Cells["Tax"].Value) / 100);
                    }
                    subtotal = total + tax;

                }
                LblTotal.Text = "Total: ₡" + total.ToString("#,##");
                LblTax.Text = "Impuestos: ₡" + tax.ToString("#,##");
                LblAmount.Text = "Subtotal: ₡" + subtotal.ToString("#,##");
            }
            else
            {
                LblTotal.Text = "Total: ₡0";
                LblTax.Text = "Impuestos: ₡0";
                LblAmount.Text = "Subtotal: ₡0";
            }

        }

        private void DGVProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow dataRow = DGVProducts.SelectedRows[0];
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
            CbCuts.DisplayMember = "CutName";
            CbCuts.ValueMember = "IDCutType";

            GetProductDetailedStock();

            DGVLines.ClearSelection();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DGVLines_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DGVProducts.ClearSelection();

            if (DGVLines.Rows.Count > 0)
            {
                BtnDelLine.Enabled = true;
            }
            else
            {
                BtnDelLine.Enabled = false;
            }

            if (e.RowIndex == -1 || e.ColumnIndex != 3)
            {
                return;
            }

        }

        private void BtnDelLine_Click(object sender, EventArgs e)
        {
            DataRow dr1 = lines.NewRow();
            if (DGVLines.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DGVLines.SelectedRows[0];
                dr1["IDProduct"] = Convert.ToInt32(row.Cells["IDProduct"].Value);



                for (int i = lines.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = lines.Rows[i];
                    if (dr["IDProduct"].ToString() == dr1["IDProduct"].ToString())
                        dr.Delete();
                }

                lines.AcceptChanges();
                DGVLines.ClearSelection();
                BtnDelLine.Enabled = false;
                SetTxtTotal();
            }
            BillingLayout();
        }

        private void FrmBilling_Click(object sender, EventArgs e)
        {
            IdleLayout();
        }

        private void CBTax_CheckedChanged(object sender, EventArgs e)
        {
            SetTxtTotal();
        }

        private void CbCuts_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void UDQuantity_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
