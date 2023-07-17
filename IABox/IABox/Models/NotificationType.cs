using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class NotificationType
    {
        public NotificationType()
        {
            NotificationConfig = new HashSet<NotificationConfig>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Enable { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual ICollection<NotificationConfig> NotificationConfig { get; set; }
    }
}
