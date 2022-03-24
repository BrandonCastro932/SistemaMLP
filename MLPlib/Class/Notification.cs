using System;
using System.Data;

namespace MLPlib.Class
{
    public class Notification
    {
        public int IDNotification { get; set; }
        public string NotificationMsg { get; set; }
        public DateTime RegDate { get; set; }
        public bool Seen { get; set; }
        public DateTime SeenDate { get; set; }

        public Notification()
        {
            Seen = false;
        }

        public int NotificationsSeen()
        {
            SistemaMLPDataSetTableAdapters.NotificationTableAdapter notificationAdapter = new SistemaMLPDataSetTableAdapters.NotificationTableAdapter();

            int result = (int)notificationAdapter.SPNotificationsSeen();

            return result;
        }

        public DataTable GetNotifications()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.NotificationTableAdapter notificationTableAdapter = new SistemaMLPDataSetTableAdapters.NotificationTableAdapter();


            notificationTableAdapter.Fill(sistemaMLPDataSet.Notification);
            return sistemaMLPDataSet.Notification;

        }

    }
}