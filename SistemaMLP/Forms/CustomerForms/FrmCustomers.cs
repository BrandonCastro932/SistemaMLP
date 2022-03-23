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

namespace SistemaMLP.Forms.CustomerForms
{
    public partial class FrmCustomers : Form
    {
        private Customer customer = new Customer();
        private bool DeletedMode = false;

        public FrmCustomers()
        {
            InitializeComponent();
            FillDGV();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            MdiParent = Utilities.Utilities.main;
        }
        private void FrmCustomers_Shown(object sender, EventArgs e)
        {
            IdleLayout();
        }

        private void IdleLayout()
        {
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnCreate.Enabled = true;
            DGVCustomers.ClearSelection();
            BtnDelete.Text = "Eliminar cliente";
        }

        private void DeletedModeLayout()
        {
            BtnCreate.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled= true;
            BtnDelete.Text = "Restaurar cliente";
        }

        private void CustomerSelectedLayout()
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

        private void FillDGV(string Filter = "")
        {
            //Llamada de datos
            DGVCustomers.DataSource = customer.GetCustomers(Filter);

            //Visual
            DGVCustomers.Columns["Active"].Visible = false;
            DGVCustomers.Columns["IDCustomer"].Visible = false;
            DGVCustomers.Columns["Fullname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVCustomers.Columns["PhoneNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVCustomers.Columns["BusinessPhoneNum"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVCustomers.Columns["Fullname"].HeaderText = "Nombre Completo";
            DGVCustomers.Columns["BusinessName"].HeaderText = "Empresa";
            DGVCustomers.Columns["PersonalID"].HeaderText = "Cédula";
            DGVCustomers.Columns["PhoneNumber"].HeaderText = "Número de teléfono";
            DGVCustomers.Columns["BusinessPhoneNum"].HeaderText = "Teléfono de empresa";
            DGVCustomers.Columns["RegDate"].HeaderText = "Fecha de registro";
            DGVCustomers.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVCustomers.Columns["Email"].HeaderText = "Correo electrónico";
            DGVCustomers.RowHeadersVisible = false;

        }
        private void FillDeletedDGV(string Filter = "")
        {
            //Llamada de datos
            DGVCustomers.DataSource = customer.GetDeletedCustomers(Filter);

            //Visual
            DGVCustomers.Columns["Active"].Visible = false;
            DGVCustomers.Columns["IDCustomer"].Visible = false;
            DGVCustomers.Columns["Fullname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVCustomers.Columns["PhoneNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVCustomers.Columns["BusinessPhoneNum"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVCustomers.Columns["Fullname"].HeaderText = "Nombre Completo";
            DGVCustomers.Columns["BusinessName"].HeaderText = "Empresa";
            DGVCustomers.Columns["PersonalID"].HeaderText = "Cédula";
            DGVCustomers.Columns["PhoneNumber"].HeaderText = "Número de teléfono";
            DGVCustomers.Columns["BusinessPhoneNum"].HeaderText = "Teléfono de empresa";
            DGVCustomers.Columns["RegDate"].HeaderText = "Fecha de registro";
            DGVCustomers.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVCustomers.Columns["Email"].HeaderText = "Correo electrónico";
            DGVCustomers.RowHeadersVisible = false;

        }

        private void FrmCustomers_Click(object sender, EventArgs e)
        {
            IdleLayout();
            customer = new Customer();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FrmCustomersCU frm = new FrmCustomersCU();
            frm.isCreating = true;
            frm.isEditing = false;
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                FillDGV();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmCustomersCU frm = new FrmCustomersCU();
            frm.isCreating = false;
            frm.isEditing = true;


            DataGridViewRow dataRow = DGVCustomers.SelectedRows[0];
            customer = new Customer
            {
                IDCustomer = Convert.ToInt32(dataRow.Cells["IDCustomer"].Value),
                PersonalID = Convert.ToString(dataRow.Cells["PersonalID"].Value),
                Fullname = Convert.ToString(dataRow.Cells["Fullname"].Value),
                PhoneNumber = Convert.ToString(dataRow.Cells["PhoneNumber"].Value),
                BusinessName = Convert.ToString(dataRow.Cells["BusinessName"].Value),
                Email = Convert.ToString(dataRow.Cells["Email"].Value),
                BusinessPhoneNum = Convert.ToString(dataRow.Cells["BusinessPhoneNum"].Value),
                RegDate = Convert.ToDateTime(dataRow.Cells["RegDate"].Value),
                Active = Convert.ToBoolean(dataRow.Cells["Active"].Value)
            };
            if(customer.IDCustomer != 1)
            {
                frm.customer = customer;
                DialogResult dialogResult = frm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    FillDGV();
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar el cliente general", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGVCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow dataRow = DGVCustomers.SelectedRows[0];
            if (Convert.ToInt32(dataRow.Cells["IDCustomer"].Value) == 1)
            {
                DGVCustomers.ClearSelection();
                IdleLayout();
            }
            else
            {
                CustomerSelectedLayout();
            }
            
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!DeletedMode)
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
            else
            {
                if (!string.IsNullOrEmpty(TxtSearch.Text.Trim()) && TxtSearch.Text.Count() >= 2)
                {
                    FillDeletedDGV(TxtSearch.Text.Trim());
                }
                else
                {
                    FillDeletedDGV();
                }
            }
        }

        private void DGVCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!DeletedMode)
            {
                DataGridViewRow dataRow = DGVCustomers.SelectedRows[0];
                customer = new Customer
                {
                    PersonalID = Convert.ToString(dataRow.Cells["PersonalID"].Value)
                };

                if(customer.PersonalID != "1")
                {
                    DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar ese cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        int result = customer.DeleteCustomer();
                        if (result == 1)
                        {
                            MessageBox.Show("Se ha eliminado el cliente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Utilities.Utilities.CreateLog("Ha desactivado un cliente: " + customer.Fullname);
                            this.DialogResult = DialogResult.OK;
                        }
                        else if (result == 2)
                        {
                            MessageBox.Show("No se ha encontrado ese cliente en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (result == 0)
                        {
                            MessageBox.Show("Error desconocido.", "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.DialogResult = DialogResult.Cancel;
                        }
                        FillDGV();
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el cliente general", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DataGridViewRow dataRow = DGVCustomers.SelectedRows[0];
                customer = new Customer
                {
                    PersonalID = Convert.ToString(dataRow.Cells["PersonalID"].Value)
                };

                DialogResult dialogResult = MessageBox.Show("Está seguro que desea restaurar ese cliente?", "Restaurar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    int result = customer.RestoreCustomer();
                    if (result == 1)
                    {
                        MessageBox.Show("Se ha restaurado el cliente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (result == 2)
                    {
                        MessageBox.Show("No se ha encontrado ese cliente en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DGVCustomers.DataSource = null;
                DGVCustomers.Rows.Clear();
                DGVCustomers.Refresh();
                FillDeletedDGV();
            }
            else
            {
                DeletedMode = false;
                IdleLayout();
                FillDGV();
            }
        }
    }
}
