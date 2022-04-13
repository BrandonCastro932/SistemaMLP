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

namespace SistemaMLP.Forms.CutTypesForms
{
    public partial class FrmCutTypes : Form
    {
        public CutTypes cutTypes = new CutTypes();

        public FrmCutTypes()
        {
            InitializeComponent();
            MdiParent = Utilities.Utilities.main;
        }

        private void CutTypesForm_Load(object sender, EventArgs e)
        {
            FillDGV();
            IdleLayout();
        }

        private void FillDGV()
        {
            DGVCuts.DataSource = cutTypes.GetCutTypes();

            DGVCuts.Columns["IDCutType"].Visible = false;
            DGVCuts.Columns["CutName"].HeaderText = "Corte";
            DGVCuts.Columns["RegDate"].HeaderText = "Fecha de registro";

            DGVCuts.Columns["CutName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVCuts.Columns["RegDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        #region Control Layouts
        private void IdleLayout()
        {
            BtnAdd.Enabled = true;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            DGVCuts.ClearSelection();
        }

        private void Selected()
        {
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
        }
        #endregion

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CutTypes cut = new CutTypes();

                FrmCutTypesInputDialog InputDialog = new FrmCutTypesInputDialog();
                DialogResult dialogResult = InputDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    cut.CutName = InputDialog.Name.ToString();
                    int i = cut.CreateCutType();

                    if(i == 1)
                    {
                        MessageBox.Show("Se ha creado el corte", "Corte creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDGV();
                        IdleLayout();
                    }
                    else if(i == 2)
                    {
                        MessageBox.Show("No se ha podido crear el corte, nombre duplicado", "Nombre de corte duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido crear el corte, error desconocido", "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se ha podido crear el corte, error desconocido", "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVCuts.SelectedRows.Count > 0)
                {
                    DataGridViewRow dataRow = DGVCuts.SelectedRows[0];
                    cutTypes = new CutTypes
                    {
                        IDCutType = Convert.ToInt32(dataRow.Cells["IDCutType"].Value)
                    };

                    FrmCutTypesInputDialog InputDialog = new FrmCutTypesInputDialog();
                    InputDialog.BtnOk.Text = "Editar";
                    InputDialog.LblTitle.Text = "Escriba el nuevo nombre del corte:";
                    InputDialog.Text = "Editar corte";

                    DialogResult dialogResult = InputDialog.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        cutTypes.CutName = InputDialog.Name.ToString();
                        int i = cutTypes.UpdateCutType();

                        if (i == 1)
                        {
                            MessageBox.Show("Se ha editado el corte", "Corte editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillDGV();
                            IdleLayout();
                        }
                        else if (i == 2)
                        {
                            MessageBox.Show("No se ha podido editar el corte, nombre duplicado", "Nombre de corte duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido editar el corte, error desconocido", "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("No se ha podido crear el corte, error desconocido", "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DGVCuts.SelectedRows.Count > 0)
            {
                DataGridViewRow dataRow = DGVCuts.SelectedRows[0];
                cutTypes = new CutTypes
                {
                    IDCutType = Convert.ToInt32(dataRow.Cells["IDCutType"].Value)
                };

            
                DialogResult dialogResult = MessageBox.Show("Desea eliminar el corte seleccionado?","Eliminar corte",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                   
                    int i = cutTypes.DeleteCutType();

                    if (i == 1)
                    {
                        MessageBox.Show("Se ha eliminado el corte", "Corte eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDGV();
                        IdleLayout();
                    }
                    else if (i == 2)
                    {
                        MessageBox.Show("El corte tiene inventario regisrado, no es posible eliminarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el corte, error desconocido", "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void DGVCuts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected();
        }

        private void FrmCutTypes_Click(object sender, EventArgs e)
        {
            IdleLayout();
        }
    }
}
