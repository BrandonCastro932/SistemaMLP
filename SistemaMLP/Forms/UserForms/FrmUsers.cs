using MLPlib.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMLP.Forms.UserForms
{
    public partial class FrmUsers : Form
    {
        public User user = new User();
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            MdiParent = Utilities.Utilities.main;
            FillDGV();
        }

        private void FillDGV(string filter = "")
        {
            DGVUsers.DataSource = user.GetUsers();

            DGVUsers.Columns["IDUser"].Visible = false;
            DGVUsers.Columns["Active"].Visible = false;

            DGVUsers.Columns["Username"].HeaderText = "Nombre de usuario";
            DGVUsers.Columns["RegDate"].HeaderText = "Fecha de registro";

            DGVUsers.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVUsers.Columns["RegDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void CleanForm()
        {
            TxtSearch.Text = "";
            DGVUsers.ClearSelection();
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void TxtSearch_MouseHover(object sender, EventArgs e)
        {
            TtSearch.SetToolTip(TxtSearch, "Búsqueda disponible por: Nombre de usuario");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmUsersCU frm = new FrmUsersCU();
            frm.isCreating = true;
            frm.isEditing = false;
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                FillDGV();
                CleanForm();
            }
        }

        private void DGVUsers_DoubleClick(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void EditUser()
        {
            if(DGVUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = DGVUsers.SelectedRows[0];

                user = new User
                {
                    IDUser = Convert.ToInt32(dataRow.Cells["IDUser"].Value),
                    Username = dataRow.Cells["Username"].Value.ToString()
                 };

                FrmUsersCU frm = new FrmUsersCU();
                frm.isCreating = false;
                frm.isEditing = true;
                frm.user = user;
                DialogResult dialogResult = frm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    FillDGV();
                }
            }
        }

        private void DGVUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DGVUsers.SelectedRows.Count > 0)
            {
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
            }
        }

        private void FrmUsers_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DGVUsers.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar ese usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewRow dataRow = DGVUsers.SelectedRows[0];

                    user = new User
                    {
                        IDUser = Convert.ToInt32(dataRow.Cells["IDUser"].Value),

                    };
                    if(user.DeleteUser() == 1)
                    {
                        MessageBox.Show("Se ha eliminado el usuario", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanForm();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al intentar eliminar el usuario", "Error de eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }
    }
}
