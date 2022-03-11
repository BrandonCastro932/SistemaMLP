﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMLP.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            Utilities.Utilities.main = this;
        }
        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilities.Utilities.frmBilling.Visible)
            {
                Utilities.Utilities.frmBilling = new BillingForms.FrmBilling();
                Utilities.Utilities.frmBilling.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilities.Utilities.frmCustomers.Visible)
            {
                Utilities.Utilities.frmCustomers = new CustomerForms.FrmCustomers();
                Utilities.Utilities.frmCustomers.Show();
            }
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilities.Utilities.frmProduct.Visible)
            {
                Utilities.Utilities.frmProduct = new CustomerForms.FrmProduct();
                Utilities.Utilities.frmProduct.Show();
            }
        }
    }
}