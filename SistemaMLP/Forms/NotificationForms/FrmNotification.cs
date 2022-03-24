using MLPlib.Class;
using System;
using System.ComponentModel;
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
            DGVNotifications.Sort(DGVNotifications.Columns["RegDate"], ListSortDirection.Descending);
        }

        private void BtnSeen_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Marcar notificaciones como vistas?", "Marcar visto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (notification.NotificationsSeen() == 1)
                    {
                        MessageBox.Show("Se han marcado las notificaciones como vistas", "Notificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDGV();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al marcar las notificaciones como vistas", "Notificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
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
