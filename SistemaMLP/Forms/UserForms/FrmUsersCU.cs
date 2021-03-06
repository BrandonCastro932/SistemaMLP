using MLPlib.Class;
using System;
using System.Windows.Forms;

namespace SistemaMLP.Forms.UserForms
{
    public partial class FrmUsersCU : Form
    {
        public bool isCreating = true;
        public bool isEditing = false;
        public User user = new User();

        public FrmUsersCU()
        {
            InitializeComponent();
        }

        private void FrmUsersCU_Load(object sender, EventArgs e)
        {
            if (isCreating)
            {
                LblTitle.Text = "Registro de usuario";
                BtnRegister.Text = "Registrar";
                LblPin.Text = "Pin:";
                LblPin2.Text = "Confirmar pin:";
                TxtUsername.Enabled = true;
            }
            else if (isEditing)
            {
                LblTitle.Text = "Cambio de pin";
                LblPin.Text = "Actual:";
                LblPin2.Text = "Nuevo pin:";
                TxtUsername.Enabled = false;
                BtnRegister.Text = "Editar";
                
                FillInfo();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FillInfo()
        {
            TxtUsername.Text = user.Username;
        }

        private bool ValidateAll()
        {
            if (!string.IsNullOrWhiteSpace(TxtUsername.Text) && !string.IsNullOrWhiteSpace(TxtPin.Text) && !string.IsNullOrWhiteSpace(TxtPin2.Text))
            {
                if (TxtPin.Text == TxtPin2.Text)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error, el pin no coincide, verificar que ambos pin coincidan", "Error de verificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (isCreating)
                {
                    if (ValidateAll())
                    {
                        User user1 = new User
                        {
                            Username = TxtUsername.Text,
                            Pin = TxtPin.Text
                        };

                        if (user1.CreateUser() == 1)
                        {
                            MessageBox.Show("El usuario ha sido registrado correctamente", "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Utilities.Utilities.CreateLog("ha registrado un nuevo usuario: " + user1.Username);
                            this.DialogResult = DialogResult.OK;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido registrar el usuario", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }

                if (isEditing)
                {
                    if (!string.IsNullOrWhiteSpace(TxtPin.Text) && !string.IsNullOrWhiteSpace(TxtPin2.Text))
                    {
                        User user1 = new User
                        {
                            IDUser = user.IDUser,
                            Username = TxtUsername.Text,
                            Pin = TxtPin.Text
                        };

                        if(user.IDUser != Utilities.Utilities.user.IDUser)
                        {
                            DialogResult dialog = MessageBox.Show("Cambiar pin de este usuario?", "Cambiar pin", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                            if(dialog == DialogResult.Yes)
                            {
                                if (user1.UpdateUser(TxtPin2.Text) == 1)
                                {
                                    MessageBox.Show("El pin del usuario ha sido cambiado correctamente", "Usuario editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Utilities.Utilities.CreateLog("ha cambiado el pin del usuario: " + user1.Username);
                                    this.DialogResult = DialogResult.OK;
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido modificar el pin del usuario, verifique que el pin actual sea el correcto", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            DialogResult dialog = MessageBox.Show("Si cambia el pin del usuario en sesión tendrá que volver a iniciar sesión en el sistema, desea cambiarlo?", "Cambiar pin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dialog == DialogResult.Yes)
                            {
                                if (user1.UpdateUser(TxtPin2.Text) == 1)
                                {
                                    MessageBox.Show("El pin del usuario ha sido cambiado correctamente", "Usuario editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Utilities.Utilities.CreateLog("ha cambiado el pin del usuario: " + user1.Username);
                                    this.DialogResult = DialogResult.OK;
                                    Application.Restart();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido modificar el pin del usuario, verifique que el pin actual sea el correcto", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                    }
                }

            }
            catch
            {

            }
        }

        private void TxtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtPin2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
