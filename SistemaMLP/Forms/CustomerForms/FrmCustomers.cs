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
            DGVCustomers.ClearSelection();
        }

        private void CustomerSelectedLayout()
        {
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
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
            frm.customer = customer;
            DialogResult dialogResult = frm.ShowDialog();
            

            if (dialogResult == DialogResult.OK)
            {
                FillDGV();
            }
        }

        private void DGVCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerSelectedLayout();
            if (e.RowIndex == -1 || e.ColumnIndex != 3)
                return;
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

        private void DGVCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataRow = DGVCustomers.SelectedRows[0];
            customer = new Customer
            {
                PersonalID = Convert.ToString(dataRow.Cells["PersonalID"].Value)
            };

            DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar ese cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                int result = customer.DeleteCustomer();
                if (result == 1)
                {
                    MessageBox.Show("Se ha eliminado el cliente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
