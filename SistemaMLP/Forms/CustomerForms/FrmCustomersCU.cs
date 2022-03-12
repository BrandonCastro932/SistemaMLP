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
                LblTitle.Text = "Registrar cliente";
                this.Text = "Registrar cliente";
                TxtPersonalID.Enabled = true;
                BtnAccept.Text = "Registrar";
                BtnAccept.Enabled = false;
                
            }
            else if (isEditing)
            {
                LblTitle.Text = "Editar cliente";
                TxtPersonalID.Enabled = false;
                this.Text = "Editar cliente";
                BtnAccept.Text = "Editar";
                FillForm();
            }
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            //TODO: Crear las respectivas validaciones para que no se inserten datos en blanco, ademas de comprobar correos, etc
            if (ValidateTextbox())
            {
                Customer customer = new Customer
                {
                    PersonalID = TxtPersonalID.Text,
                    Fullname = TxtFullname.Text,
                    BusinessName = TxtBusinessName.Text,
                    Email = TxtEmail.Text,
                    PhoneNumber = TxtPhoneNumber.Text,
                    BusinessPhoneNum = TxtBusinessPhoneNum.Text
                };

                if(!string.IsNullOrWhiteSpace(TxtEmail.Text))
                {
                    if (!IsValidEmail(TxtEmail.Text))
                    {
                        MessageBox.Show("El correo electrónico no es válido", "Error de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (isCreating)
                {
                    int result = customer.CreateCustomer();
                    if (result == 1)
                    {
                        MessageBox.Show("Se ha registrado el cliente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Utilities.Utilities.CreateLog("Ha registrado un cliente: " + customer.Fullname);

                        this.DialogResult = DialogResult.OK;
                    }
                    else if (result == 2)
                    {
                        MessageBox.Show("Cédula, correo electrónico o teléfono duplicados en el sistema.", "Datos duplicados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("Error desconocido.", "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Cancel;
                    }

                }
                else if (isEditing)
                {
                    int result = customer.UpdateCustomer();
                    if (result == 1)
                    {
                        MessageBox.Show("Se ha modificado el cliente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Utilities.Utilities.CreateLog("Ha actualizado un cliente: " + customer.Fullname);

                        this.DialogResult = DialogResult.OK;
                    }
                    else if (result == 2)
                    {
                        MessageBox.Show("Cédula o correo electrónico duplicados en el sistema.", "Datos duplicados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("Error desconocido.", "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
            else
            {
                MessageBox.Show("Atención, existen campos en blanco o erróneos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillForm()
        {
            TxtPersonalID.Text = customer.PersonalID;
            TxtFullname.Text = customer.Fullname;
            TxtBusinessName.Text = customer.BusinessName;
            TxtEmail.Text = customer.Email;
            TxtPhoneNumber.Text = customer.PhoneNumber;
            TxtBusinessPhoneNum.Text = customer.BusinessPhoneNum;
        }

        private bool ValidateTextbox()
        {
            if (!string.IsNullOrWhiteSpace(TxtPersonalID.Text) && !string.IsNullOrWhiteSpace(TxtFullname.Text) && !string.IsNullOrWhiteSpace(TxtPhoneNumber.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ActivateBtn()
        {
            if (TxtPersonalID.Text.Length > 1 && TxtFullname.Text.Length > 1 && TxtPhoneNumber.Text.Length > 1)
            {
                BtnAccept.Enabled = true;
            }
            else
            {
                BtnAccept.Enabled = false;
            }
        }
        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
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

        private void TxtPersonalID_KeyDown(object sender, KeyEventArgs e)
        {
            ActivateBtn();
            if (e.KeyData == Keys.Enter)
            {
                TxtFullname.Focus();
            }
            if(e.KeyData == Keys.Down)
            {
                TxtFullname.Focus();
            }
            ActivateBtn();
        }

        private void TxtFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TxtPhoneNumber.Focus();
            }
            if (e.KeyData == Keys.Down)
            {
                TxtPhoneNumber.Focus();
            }
            if (e.KeyData == Keys.Up)
            {
                TxtPersonalID.Focus();
            }
            if (IsKeyADigit(e.KeyData))
            {
                e.SuppressKeyPress = true;
            }
            ActivateBtn();
        }

        private void TxtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
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
            if (IsKeyAChar(e.KeyData))
            {
                e.SuppressKeyPress = true;
            }
            ActivateBtn();
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
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
                TxtPhoneNumber.Focus();
            }
        }

        private void TxtBusinessName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TxtBusinessPhoneNum.Focus();
            }
            if (e.KeyData == Keys.Down)
            {
                TxtBusinessPhoneNum.Focus();
            }
            if (e.KeyData == Keys.Up)
            {
                TxtEmail.Focus();
            }
        }

        private void TxtBusinessPhoneNum_KeyDown(object sender, KeyEventArgs e)
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
            if (IsKeyAChar(e.KeyData))
            {
                e.SuppressKeyPress = true;
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
                TxtBusinessPhoneNum.Focus();
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
