using MLPlib.Class;
using SistemaMLP.Forms.ProductForms;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;

namespace SistemaMLP.Forms.CustomerForms
{
    public partial class FrmProduct : Form
    {
        private SqlTableDependency<Product> productDependency = new SqlTableDependency<Product>(ConfigurationManager.ConnectionStrings["SistemaMLP.Properties.Settings.SistemaMLPConnectionString"].ToString());
        private Product product = new Product();
        private bool DeletedMode = false;
        public FrmProduct()
        {
            InitializeComponent();
            FillDGV();
            IdleLayout();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FrmProductCU frmProductCU = new FrmProductCU();
            frmProductCU.ShowDialog();
            FillDGV();

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            MdiParent = Utilities.Utilities.main;
            productDependency.OnChanged += ProductTableDependency_Changed;
            productDependency.Start();

            //Checkear esto con el profesor
            CheckForIllegalCrossThreadCalls = false;
        }

        public void ProductTableDependency_Changed(object sender, RecordChangedEventArgs<Product> e)
        {
            if (e.ChangeType != TableDependency.SqlClient.Base.Enums.ChangeType.None)
            {
                if (!DeletedMode)
                {
                    FillDGV();
                }
            }
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
            DGVProduct.Columns["StockTypeDetail"].Visible = false;

            DGVProduct.Columns["GeneralStock"].HeaderText = "Existencias";

            DGVProduct.Columns["RegDate"].Visible = false;

            DGVProduct.Columns["LastUpdate"].HeaderText = "Ultimo abastecimiento";

            DGVProduct.Columns["Active"].Visible = false;

            DGVProduct.Columns["StockTypeName"].HeaderText = "Tipo de inventario";
            DGVProduct.Columns["StockTypeName"].DisplayIndex = 4;

            DGVProduct.RowHeadersVisible = false;

        }

        private void FillDeletedDGV(string Filter = "")
        {
            //Llamada de datos
            DGVProduct.DataSource = product.GetDeletedProducts(Filter);

            //Visual
            DGVProduct.Columns["IDProduct"].Visible = false;

            DGVProduct.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVProduct.Columns["ProductName"].HeaderText = "Nombre del producto";

            DGVProduct.Columns["BarCode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVProduct.Columns["BarCode"].HeaderText = "Código de barras";

            DGVProduct.Columns["UnitPrice"].HeaderText = "Precio unitario";

            DGVProduct.Columns["Tax"].HeaderText = "Impuesto(%)";

            DGVProduct.Columns["StockType"].Visible = false;
            DGVProduct.Columns["StockTypeDetail"].Visible = false;

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
            BtnDelete.Text = "Eliminar producto";
        }

        private void DeletedModeLayout()
        {
            BtnCreate.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = true;
            BtnDelete.Text = "Restaurar producto";
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
            if (DGVProduct.SelectedRows.Count > 0)
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

                if (dataRow.Cells["StockTypeDetail"].Value != DBNull.Value)
                {
                    product.StockTypeDetail = Convert.ToDecimal(dataRow.Cells["StockTypeDetail"].Value);
                }
                else
                {
                    product.StockTypeDetail = null;
                }

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

        private void FrmProduct_Click(object sender, EventArgs e)
        {
            IdleLayout();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DGVProduct.SelectedRows.Count > 0)
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

                if (dataRow.Cells["StockTypeDetail"].Value != DBNull.Value)
                {
                    product.StockTypeDetail = Convert.ToDecimal(dataRow.Cells["StockTypeDetail"].Value);
                }
                else
                {
                    product.StockTypeDetail = null;
                }
                FrmProductCU frmProductCU = new FrmProductCU();
                frmProductCU.product1 = product;
                frmProductCU.isCreating = false;
                frmProductCU.isEditing = true;

                DialogResult dialogResult = frmProductCU.ShowDialog();
                FillDGV();

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!DeletedMode)
            {
                if (DGVProduct.SelectedRows.Count > 0)
                {
                    DataGridViewRow dataRow = DGVProduct.SelectedRows[0];
                    product = new Product
                    {
                        IDProduct = Convert.ToInt32(dataRow.Cells["IDProduct"].Value),

                    };

                    DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar ese producto?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        int result = product.DeleteProduct();
                        if (result == 1)
                        {
                            MessageBox.Show("Se ha eliminado el producto.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Utilities.Utilities.CreateLog("Ha eliminado un producto: " + product.ProductName);

                            this.DialogResult = DialogResult.OK;
                        }
                        else if (result == 2)
                        {
                            MessageBox.Show("No se ha encontrado ese producto en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (result == 0)
                        {
                            MessageBox.Show("Error desconocido.", "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.DialogResult = DialogResult.Cancel;
                        }
                        FillDGV();
                    }

                    FillDGV();

                }
            }
            else
            {
                DataGridViewRow dataRow = DGVProduct.SelectedRows[0];
                product = new Product
                {
                    IDProduct = Convert.ToInt32(dataRow.Cells["IDProduct"].Value)
                };

                DialogResult dialogResult = MessageBox.Show("Está seguro que desea restaurar ese producto?", "Restaurar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    int result = product.RestoreProduct();
                    if (result == 1)
                    {
                        MessageBox.Show("Se ha restaurado el producto.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (result == 2)
                    {
                        MessageBox.Show("No se ha encontrado ese producto en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("Error desconocido.", "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Cancel;
                    }
                    Cbx_Deleted.Checked = false;
                    FillDGV();
                }

            }
        }

        private void Cbx_Deleted_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx_Deleted.Checked)
            {
                DeletedMode = true;
                DeletedModeLayout();
                DGVProduct.DataSource = null;
                DGVProduct.Rows.Clear();
                DGVProduct.Refresh();
                FillDeletedDGV();
            }
            else
            {
                DeletedMode = false;
                IdleLayout();
                FillDGV();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!DeletedMode)
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
            else
            {
                if (!string.IsNullOrEmpty(TxtSearch.Text.Trim()) && TxtSearch.Text.Count() >= 1)
                {
                    FillDeletedDGV(TxtSearch.Text.Trim());
                }
                else
                {
                    FillDeletedDGV();
                }
            }
        }

        private void FrmProduct_Shown(object sender, EventArgs e)
        {
            if (Utilities.Utilities.frmWaiting.Visible)
            {
                Utilities.Utilities.frmWaiting.Close();
            }
        }

        private void FrmProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            productDependency.Stop();
        }
    }
}
