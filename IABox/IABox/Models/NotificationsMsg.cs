using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class NotificationsMsg
    {
        public long Id { get; set; }
        public long? IdEventCameras { get; set; }
        public long? IdEventSensors { get; set; }
        public bool Read { get; set; }

        public virtual Events IdEventCamerasNavigation { get; set; }
        public virtual EventsSensors IdEventSensorsNavigation { get; set; }
    }
}
