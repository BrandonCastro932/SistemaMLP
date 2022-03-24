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

namespace SistemaMLP.Forms.NotificationForms
{
    public partial class FrmNotification : Form
    {
        public Notification notification = new Notification();
        public FrmNotification()
        {
            InitializeComponent();
            MdiParent = Utilities.Utilities.main;
        }

        private void FillDGV()
        {
            DGVNotifications.DataSource = notification.GetNotifications();

            DGVNotifications.Columns["NotificationMsg"].HeaderText = "Notificación";
            DGVNotifications.Columns["NotificationMsg"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVNotifications.Columns["RegDate"].HeaderText = "Fecha";

            DGVNotifications.Columns["IDNotification"].Visible = false;
            DGVNotifications.Columns["Seen"].Visible = false;
            DGVNotifications.Columns["SeenDate"].Visible = false;
        }

        private void BtnSeen_Click(object sender, EventArgs e)
        {

        }

        private void FrmNotification_Load(object sender, EventArgs e)
        {
            FillDGV();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
