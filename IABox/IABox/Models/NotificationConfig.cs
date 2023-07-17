using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class NotificationConfig
    {
        public long Id { get; set; }
        public long IdUsuario { get; set; }
        public long IdNotificationType { get; set; }
        public long IdEventType { get; set; }
        public long IdIabox { get; set; }
        public bool? Enable { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual EventType IdEventTypeNavigation { get; set; }
        public virtual IaBox IdIaboxNavigation { get; set; }
        public virtual NotificationType IdNotificationTypeNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
