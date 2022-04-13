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
    public partial class FrmCutTypesInputDialog : Form
    {
        public new string Name { get; set; }

        public FrmCutTypesInputDialog()
        {
            InitializeComponent();
        }

        private void FrmCutTypesInputDialog_Load(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtCutName.Text))
            {
                Name = TxtCutName.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void TxtCutName_TextChanged(object sender, EventArgs e)
        {
            if(TxtCutName.Text.Length > 2)
            {
                BtnOk.Enabled = true;
            }
            else
            {
                BtnOk.Enabled = false;
            }
        }
    }
}
