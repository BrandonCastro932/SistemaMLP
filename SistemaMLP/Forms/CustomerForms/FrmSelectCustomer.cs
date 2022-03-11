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
    public partial class FrmSelectCustomer : Form
    {
        public Customer customer = new Customer();
        public FrmSelectCustomer()
        {
            InitializeComponent();
        }

        private void FrmSelectCustomer_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void FillDGV(string filter = "")
        {
            DGVCustomers.DataSource = customer.GetCustomers(filter);
            SetDGV();
            DGVCustomers.ClearSelection();
        }

        private void SetDGV()
        {
            DGVCustomers.Columns["IDCustomer"].Visible = false;
            DGVCustomers.Columns["RegDate"].Visible = false;
            DGVCustomers.Columns["Active"].Visible = false;
            DGVCustomers.Columns["PersonalID"].HeaderText = "Cédula";
            DGVCustomers.Columns["Fullname"].HeaderText = "Nombre completo";
            DGVCustomers.Columns["Fullname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVCustomers.Columns["BusinessName"].HeaderText = "Empresa";
            DGVCustomers.Columns["Email"].HeaderText = "Correo";
            
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataRow = DGVCustomers.SelectedRows[0];
            customer = new Customer
            {
                IDCustomer = Convert.ToInt32(dataRow.Cells["IDCustomer"].Value),
                PersonalID = Convert.ToString(dataRow.Cells["PersonalID"].Value),
                Fullname = Convert.ToString(dataRow.Cells["Fullname"].Value),
                BusinessName = Convert.ToString(dataRow.Cells["BusinessName"].Value),
                Email = Convert.ToString(dataRow.Cells["Email"].Value),
                RegDate = Convert.ToDateTime(dataRow.Cells["RegDate"].Value),
                Active = Convert.ToBoolean(dataRow.Cells["Active"].Value)
            };

            this.DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void DGVCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 3) 
                return;
        }

        private void DGVCustomers_DoubleClick(object sender, EventArgs e)
        {
            BtnSelect_Click(sender, e);
        }
    }
}
