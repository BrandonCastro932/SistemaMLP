using System;

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

    }
}