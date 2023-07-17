using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class EventsSensors
    {
        public EventsSensors()
        {
            NotificationsMsg = new HashSet<NotificationsMsg>();
        }

        public long Id { get; set; }
        public DateTime DateEventIni { get; set; }
        public DateTime DateEventEnd { get; set; }
        public int Value { get; set; }
        public long IdSensor { get; set; }
        public long IdEventType { get; set; }

        public virtual EventType IdEventTypeNavigation { get; set; }
        public virtual Sensors IdSensorNavigation { get; set; }
        public virtual ICollection<NotificationsMsg> NotificationsMsg { get; set; }
    }
}
