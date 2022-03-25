using MLPlib.Class;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaMLP.Forms.UserForms
{
    public partial class FrmUsers : Form
    {
        public User user = new User();
        public bool DeletedMode = false;
        public FrmUsers()
        {
            InitializeComponent();
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

        private void FillDeletedDGV(string filter = "")
        {
            DGVUsers.DataSource = user.GetDeletedUsers();

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
            CbDeleted.Checked = false;
            BtnLayout();
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
            if (DGVUsers.SelectedRows.Count > 0)
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
            if (!DeletedMode)
            {
                if (DGVUsers.SelectedRows.Count > 0)
                {
                    BtnAdd.Enabled = true;
                    BtnEdit.Enabled = true;
                    BtnDelete.Enabled = true;
                }
            }
            else
            {
                if (DGVUsers.SelectedRows.Count > 0)
                {
                    BtnLayout();
                }
            }
        }

        private void BtnLayout()
        {
            if (!DeletedMode)
            {
                BtnAdd.Enabled = true;
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = false;
                BtnEdit.Enabled = false;
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
                if (!DeletedMode)
                {
                    DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar ese usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataGridViewRow dataRow = DGVUsers.SelectedRows[0];

                        user = new User
                        {
                            IDUser = Convert.ToInt32(dataRow.Cells["IDUser"].Value),
                            Username = Convert.ToString(dataRow.Cells["Username"].Value),

                        };
                        if(user.IDUser != Utilities.Utilities.user.IDUser)
                        {
                            if (user.DeleteUser() == 1)
                            {
                                MessageBox.Show("Se ha eliminado el usuario", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Utilities.Utilities.CreateLog("ha eliminado el usuario: " + user.Username);
                                CleanForm();
                                FillDGV();
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error al intentar eliminar el usuario", "Error de eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se permite eliminar el usuario en sesión", "Error de eliminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Está seguro que desea restaurar ese usuario?", "Restaurar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataGridViewRow dataRow = DGVUsers.SelectedRows[0];

                        user = new User
                        {
                            IDUser = Convert.ToInt32(dataRow.Cells["IDUser"].Value),
                            Username = Convert.ToString(dataRow.Cells["Username"].Value),

                        };
                        if (user.RestoreUser() == 1)
                        {
                            MessageBox.Show("Se ha restaurado el usuario", "Usuario restaurado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Utilities.Utilities.CreateLog("ha restaurado el usuario: " + user.Username);
                            CleanForm();
                            FillDGV();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar eliminar el usuario", "Error de eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        private void CbDeleted_CheckedChanged(object sender, EventArgs e)
        {
            if(CbDeleted.Checked == true)
            {
                DeletedMode = true;
                BtnDelete.Text = "Restaurar usuario";
                FillDeletedDGV();
                BtnLayout();
            }
            else
            {
                DeletedMode = false;
                BtnDelete.Text = "Eliminar usuario";
                FillDGV();
                BtnLayout();
            }
        }
    }
}
