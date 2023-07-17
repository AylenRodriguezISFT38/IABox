using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class EventType
    {
        public EventType()
        {
            CamerasEventTypes = new HashSet<CamerasEventTypes>();
            EventSubModulos = new HashSet<EventSubModulos>();
            Events = new HashSet<Events>();
            EventsSensors = new HashSet<EventsSensors>();
            NotificationConfig = new HashSet<NotificationConfig>();
            PermisoEvent = new HashSet<PermisoEvent>();
        }

        public long IdEventType { get; set; }
        public string Code { get; set; }
        public string Desc { get; set; }
        public bool? Enable { get; set; }

        public virtual ICollection<CamerasEventTypes> CamerasEventTypes { get; set; }
        public virtual ICollection<EventSubModulos> EventSubModulos { get; set; }
        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<EventsSensors> EventsSensors { get; set; }
        public virtual ICollection<NotificationConfig> NotificationConfig { get; set; }
        public virtual ICollection<PermisoEvent> PermisoEvent { get; set; }
    }
}
