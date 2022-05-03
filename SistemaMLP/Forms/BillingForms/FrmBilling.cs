using CrystalDecisions.CrystalReports.Engine;
using MLPlib.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaMLP.Forms.BillingForms
{
    public partial class FrmBilling : Form
    {
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
            TxtNotes.Text = "";
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
            TxtNotes.Text = "";
            CbPaymentMethod.SelectedValue = 1;
            LblCustomerName.Text = customer.Fullname;
            BtnBilling.Enabled = false;
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
            DGVProducts.Columns["StockTypeName"].Width = 100;
            DGVProducts.Columns["GeneralStock"].Width = 150;
            DGVProducts.Columns["ProductName"].HeaderText = "Producto";
            DGVProducts.Columns["GeneralStock"].HeaderText = "Stock en bodega";
            DGVProducts.Columns["BarCode"].HeaderText = "Código barras";
            DGVProducts.Columns["UnitPrice"].HeaderText = "Precio por unidad";
            DGVProducts.Columns["Tax"].HeaderText = "Impuesto";
            DGVProducts.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
            DGVLines.Columns["DetailPrice"].HeaderText = "Precio detalle";
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
            lines.Columns.Add("DetailPrice", typeof(decimal));

            
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

        /// <summary>
        /// Al hacer click en el botón "Facturar" se realiza lo siguiente.
        /// 1. Se crea el código de la factura combinando: Número de día, mes, año, hora, minuto y segundo junto con la identificación del cliente.
        /// 2. Se crea la factura, determinando si es en efectivo, crédito o sinpe.
        /// 3. Se registra la factura y se registran las líneas de detalle.
        /// 4. Si todo se registra correctamente, se procede a imprimir la factura en la impresora por defecto del sistema.
        /// </summary>
        private void BtnBilling_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea registrar la factura?", "Registrar factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //Se crea el código de la factura generando un número sumando el año, mes, dia, hora, minuto, segundo y numero de cédula del cliente.
                    //De esta forma nunca se duplicará el código de las facturas y siempre será de la misma longitud.
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
                    //Se crea la factura y se retorna el id generado, en caso de error, la base de datos retorna 0.
                    int i = receipt.CreateReceipt();
                    if (i != 0)
                    {
                        receipt.IDReceipt = i;
                        //Se usa un foreach para registrar cada linea de detalle
                        foreach (DataRow dr in lines.Rows)
                        {
                            ReceiptDetails receiptDetails = new ReceiptDetails
                            {
                                IDReceipt = i,
                                IDProduct = Convert.ToInt32(dr["IDProduct"].ToString()),
                                Quantity = Convert.ToDecimal(dr["Quantity"].ToString()),
                                DetailPrice = Convert.ToDecimal(dr["DetailPrice"].ToString())
                            };

                            if (dr["IDCutType"].ToString() != String.Empty)
                            {
                                receiptDetails.IDCutType = Convert.ToInt32(dr["IDCutType"].ToString());
                            }
                            else if (dr["IDCutType"].ToString() == String.Empty && Convert.ToInt32(dr["StockType"]) == 1)
                            {
                                //Acá se produce el error en que marca el tipo de corte de las cajas y unidades como "Filet" cuando debería ser nulo
                                receiptDetails.IDCutType = 1;
                            }

                            //Al registrar la linea, la base de datos retorna un 1 si se realizo correctamente, en caso de que no, se retorna un 0.
                            int j = receiptDetails.CreateReceiptDetail();

                            if (j != 1)
                            {
                                MessageBox.Show("Error, no se ha podido registrar una de las líneas.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        //Si la factura es a crédito, este se registra.
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

                        //Para imprimir la factura, se usa crystal reports y se imprime en la impresora por defecto del sistema operativo.
                        DialogResult dialogResult1 = MessageBox.Show("¿Desea imprimir la factura?", "Imprimir factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult1 == DialogResult.Yes)
                        {
                            ReportDocument report = new ReportDocument();
                            report = new Report.Receipt();
                            report = receipt.Print(report);
                         
                            PrinterSettings settings = new PrinterSettings();

                            try
                            {
                                report.PrintOptions.PrinterName = settings.PrinterName;
                                report.PrintToPrinter(1, false, 0, 0);
                            }
                            catch
                            {
                                MessageBox.Show("Error, no se ha podido imprimir la factura", "Error de impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

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
                throw;
            }

        }

        /// <summary>
        /// Al hacer click en el botón, se valida:
        /// 1. Que si el producto tiene el inventario detallado en cortes, la cantidad a comprar seleccionada no sea mayor al stock del corte.
        /// 2. Si el producto tiene el inventario normal, que la cantidad a comprar no sobrepase el límite de stock.
        /// 3. Que si se agrega el mismo producto con diferente corte, se agregue como una nueva línea.
        /// 4. Que si el stock son cajas o paquetes no se puede agregar en decimales.
        /// Se presentaron ciertos problemas. Por los que ciertas validaciones tuvieron que escribirse 2 veces, pero al ser dependiente del caso, solo se ejecutan una vez en el código.
        /// Se planea mejorar este apartado del código.
        /// </summary>
        private void BtnAddLine_Click(object sender, EventArgs e)
        {
            DataRow dr1 = lines.NewRow();
            bool aux = false;

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
                    dr1["StockType"] = Convert.ToInt32(row.Cells["StockType"].Value);
                    dr1["Quantity"] = Convert.ToDecimal(UDQuantity.Value);
                 
                    if (CBTax.Checked == false)
                    {
                        //Si el checkbox de impuesto está sin checkear no incluye impuesto
                        dr1["DetailPrice"] = Convert.ToDecimal(dr1["UnitPrice"]) * Convert.ToDecimal(dr1["Quantity"]);
                    }
                    else
                    {
                        //Si el checkbox de impuesto si esta chekeado, incluye el impuesto
                        dr1["DetailPrice"] = (Convert.ToDecimal(dr1["UnitPrice"].ToString()) *
                        Convert.ToDecimal(dr1["Quantity"].ToString()) + (
                        Convert.ToDecimal(dr1["UnitPrice"]) *
                        Convert.ToDecimal(dr1["Quantity"]) *
                        (Convert.ToDecimal(dr1["Tax"]) / 100))).ToString("#,#");
                    }

                    if (CbCuts.Visible)
                    {
                        //Si tiene cortes detallados, se checkean que esten disponibles
                        dr1["LineType"] = Convert.ToString(CbCuts.Text);
                        dr1["IDCutType"] = CbCuts.SelectedValue;
                        if (!CheckDetailedStock())
                        {
                            return;
                        }
                    }
                    //Ojo el visible de este if
                    else if (!CbCuts.Visible && dr1["StockTypeName"].ToString() == "Kilos")
                    {
                        //Si no hay inventario en cortes, se establece la linea en kilos
                        dr1["LineType"] = "Kilos";
                        dr1["IDCutType"] = 1;
                    }
                    else
                    {
                        //Si no, la linea va a ser del tipo de stock que sea, nombre del corte, caja, paquete o unidad 
                        dr1["LineType"] = dr1["StockTypeName"].ToString();
                   }

                    if (lines.Rows.Count == 0 && ValidateStock(Convert.ToDecimal(dr1["GeneralStock"].ToString())))
                    {
                        //Valida que si la linea se compra en caja, paquete o unidad, no permita decimales.
                        if (dr1["StockTypeName"].ToString() == "Cajas" && !int.TryParse(dr1["Quantity"].ToString(), out int n) || dr1["StockTypeName"].ToString() == "Paquetes" && !int.TryParse(dr1["Quantity"].ToString(), out int k) || dr1["StockTypeName"].ToString() == "Unidad" && !int.TryParse(dr1["Quantity"].ToString(), out int x))
                        {
                            MessageBox.Show("No se permite agregar el número de cajas o paquetes en decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            UDQuantity.Value = 1;
                            aux = false;
                            return;
                        }
                        lines.Rows.Add(dr1);
                        BillingLayout();
                    }
                    else if (lines.Rows.Count == 0 && !ValidateStock(Convert.ToDecimal(dr1["GeneralStock"].ToString())))
                    {
                        //Valida que si el stock de lo que se va a agregar no es sufuiciente, aparezca el error.
                        aux = true;
                        MessageBox.Show("No se permite agregar más del stock existente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (dr1["StockTypeName"].ToString() != "Cajas" && dr1["StockTypeName"].ToString() != "Paquetes" && ValidateStock(Convert.ToDecimal(dr1["GeneralStock"].ToString())))
                        {
                            //Se recorre con un foreach para validar la existencia de lineas iguales, en caso de existir, se suma a la linea existente.
                            foreach (DataRow dr in lines.Rows)
                            {
                                if (dr["IDProduct"].ToString() == dr1["IDProduct"].ToString())
                                {
                                    if (detailedStocks.Count == 0)
                                    {
                                        if (Convert.ToDecimal(dr["Quantity"].ToString()) + Convert.ToDecimal(dr1["Quantity"].ToString()) <= Convert.ToDecimal(dr1["GeneralStock"].ToString()) && ValidateStock(Convert.ToDecimal(dr1["GeneralStock"].ToString())))
                                        {
                                            //Ahora valida que si la linea agregada tiene stock detallado, esta no pase de lo registrado

                                            dr["Quantity"] = Convert.ToDecimal(dr["Quantity"]) + Convert.ToDecimal(dr1["Quantity"]);
                                            dr["DetailPrice"] = Convert.ToDecimal(dr["DetailPrice"]) + Convert.ToDecimal(dr1["DetailPrice"]);
                                            lines.AcceptChanges();
                                            aux = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se permite agregar más del stock existente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            aux = true;
                                        }
                                    }
                                    else
                                    {
                                        DetailedStock detailed = new DetailedStock();
                                        detailed = detailedStocks.FirstOrDefault(x => x.IDCutType.Equals(Convert.ToInt32(CbCuts.SelectedValue)));
                                        //Si se agrega un corte distinto de un mismo producto, se agrega como una nueva linea

                                        if (dr["LineType"].ToString() == CbCuts.Text.ToString() && UDQuantity.Value <= detailed.Stock && ValidateStock(detailed.Stock))
                                        {
                                            //Se agrega a la linea existente la cantidad de la linea igual que se iba a agregar y se valida que la suma de ambas no exceda del stock. 
                                            if (Convert.ToDecimal(dr["Quantity"].ToString()) + Convert.ToDecimal(dr1["Quantity"].ToString()) <= Convert.ToDecimal(detailed.Stock))
                                            {
                                                dr["Quantity"] = Convert.ToDecimal(dr["Quantity"]) + Convert.ToDecimal(dr1["Quantity"]);
                                                lines.AcceptChanges();
                                                aux = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("No se permite agregar más del stock existente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                aux = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (dr1["StockTypeName"].ToString() != "Cajas" && dr1["StockTypeName"].ToString() != "Paquetes" && !ValidateStock(Convert.ToDecimal(dr1["GeneralStock"].ToString())))
                        {
                            //Se valida el error del stock.
                            MessageBox.Show("No se permite agregar más del stock existente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            aux = true;
                        }
                        else
                        {
                            //Se vuelva a validar los decimales en las cajas, paquetes o unidades.
                            if (dr1["StockTypeName"].ToString() == "Cajas" && !int.TryParse(dr1["Quantity"].ToString(), out int n) || dr1["StockTypeName"].ToString() == "Paquetes" && !int.TryParse(dr1["Quantity"].ToString(), out int k) || dr1["StockTypeName"].ToString() == "Unidades" && !int.TryParse(dr1["Quantity"].ToString(), out int x))
                            {
                                MessageBox.Show("No se permite agregar el número de cajas o paquetes en decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                aux = true;
                                UDQuantity.Value = 1;
                            }
                        }
                        //Si la variable auxiliar llego en false, se agrega la nueva linea
                        if (!aux)
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
                        tax += Convert.ToDecimal(dr1.Cells["UnitPrice"].Value) * Convert.ToDecimal(dr1.Cells["Quantity"].Value) * (Convert.ToDecimal(dr1.Cells["Tax"].Value) / 100);
                    }


                    subtotal = total + tax;

                }
                LblTotal.Text = "Total: ₡" + total.ToString("#,##");
                if (CBTax.Checked)
                {
                    LblTax.Text = "Impuestos: ₡" + tax.ToString("#,##");
                }
                else
                {
                    LblTax.Text = "Impuestos: ₡0";
                }
                LblAmount.Text = "Subtotal: ₡" + subtotal.ToString("#,##");
            }
            else
            {
                LblTotal.Text = "Subtotal: ₡0";
                LblTax.Text = "Impuestos: ₡0";
                LblAmount.Text = "Total: ₡0";
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
            DetailsTaxRemover();
        }

        private void DetailsTaxRemover()
        {
            if(lines.Rows.Count > 0)
            {
                foreach (DataRow dr in lines.Rows)
                {

                    if (CBTax.Checked == false)
                    {
                        dr["DetailPrice"] = Convert.ToDecimal(dr["UnitPrice"]) * Convert.ToDecimal(dr["Quantity"]);
                    }
                    else
                    {
                        dr["DetailPrice"] = (Convert.ToDecimal(dr["UnitPrice"].ToString()) *
                        Convert.ToDecimal(dr["Quantity"].ToString()) + (
                        Convert.ToDecimal(dr["UnitPrice"]) *
                        Convert.ToDecimal(dr["Quantity"]) *
                        (Convert.ToDecimal(dr["Tax"]) / 100))).ToString("#,#");
                    }

                }
            }
        }

        private bool CheckDetailedStock()
        {
            if(CbCuts.Visible == true && CbCuts.SelectedItem != null)
            {
                foreach(DetailedStock detailedStock in detailedStocks)
                {
                    if(detailedStock.IDCutType == Convert.ToInt32(CbCuts.SelectedValue) && UDQuantity.Value <= detailedStock.Stock)
                    {
                        return true;
                    }
                    
                }
            }
            MessageBox.Show("El valor de venta excede las existencias del corte", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
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

        private void Gb_Products_Enter(object sender, EventArgs e)
        {

        }

        private void CbCuts_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
