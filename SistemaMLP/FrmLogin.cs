using MLPlib.Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaMLP
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Método que se encarga de loguear el usuario si el pin coincide.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.Pin = TxtPin.Text.Trim();

                DataTable dataTable = user.LoginUser();
                if (dataTable.Rows.Count > 0)
                {
                    Forms.WaitingForm.FrmWaitingFunc frmWaitingFunc = new Forms.WaitingForm.FrmWaitingFunc();

                    frmWaitingFunc.Show(this);

                    DataRow dt = dataTable.Rows[0];

                    Utilities.Utilities.user.IDUser = Convert.ToInt32(dt["IDUser"].ToString());
                    Utilities.Utilities.user.Username = dt["Username"].ToString();
                    Utilities.Utilities.user.RegDate = Convert.ToDateTime(dt["RegDate"].ToString());
                    Utilities.Utilities.user.Active = Convert.ToBoolean(dt["Active"].ToString());

                    
                    Utilities.Utilities.main = new Forms.FrmMain();
                    Utilities.Utilities.main.Show();
                    frmWaitingFunc.Close();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Pin incorrecto", "Error de pin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error del sistema "+ ex, "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtPin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1_Click(this, e);
            }
        }
    }
}
