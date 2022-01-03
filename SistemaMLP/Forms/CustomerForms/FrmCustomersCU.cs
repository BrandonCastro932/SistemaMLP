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
    public partial class FrmCustomersCU : Form
    {
        public bool isEditing = false;
        public bool isCreating = false;
        public Customer customer = new Customer();

        public FrmCustomersCU()
        {
            InitializeComponent();
        }

        private void FrmCustomersCU_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            if (isCreating)
            {
                LblTitle.Text = "Crear usuario";
                BtnAccept.Text = "Crear usuario";
            }
            else if (isEditing)
            {
                LblTitle.Text = "Editar usuario";
                BtnAccept.Text = "Editar usuario";
                FillForm();
            }
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (isCreating)
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (isEditing)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void FillForm()
        {
            TxtPersonalID.Text = customer.PersonalID;
            TxtFullname.Text = customer.Fullname;
            TxtBusinessName.Text = customer.BusinessName;
            TxtEmail.Text = customer.Email;
        }
        private void TxtPersonalID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                TxtFullname.Focus();
            }
            if(e.KeyData == Keys.Down)
            {
                TxtFullname.Focus();
            }
        }

        private void TxtFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TxtBusinessName.Focus();
            }
            if (e.KeyData == Keys.Down)
            {
                TxtBusinessName.Focus();
            }
            if (e.KeyData == Keys.Up)
            {
                TxtPersonalID.Focus();
            }
        }

        private void TxtBusinessName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TxtEmail.Focus();
            }
            if (e.KeyData == Keys.Down)
            {
                TxtEmail.Focus();
            }
            if (e.KeyData == Keys.Up)
            {
                TxtFullname.Focus();
            }
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BtnAccept.Focus();
            }
            if (e.KeyData == Keys.Down)
            {
                BtnAccept.Focus();
            }
            if (e.KeyData == Keys.Up)
            {
                TxtBusinessName.Focus();
            }
        }

        private void BtnAccept_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BtnAccept.Select();
            }
            if (e.KeyData == Keys.Down)
            {
                TxtPersonalID.Focus();
            }
            if (e.KeyData == Keys.Up)
            {
                TxtEmail.Focus();
            }

        }

        private void BtnCancel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BtnCancel.Select();
            }
            if (e.KeyData == Keys.Down)
            {
                TxtPersonalID.Focus();
            }
            if (e.KeyData == Keys.Up)
            {
                TxtEmail.Focus();
            }


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
