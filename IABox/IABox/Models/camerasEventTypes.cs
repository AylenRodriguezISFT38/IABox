using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class CamerasEventTypes
    {
        public long Id { get; set; }
        public long IdCamera { get; set; }
        public long IdEventType { get; set; }
        public bool Enable { get; set; }
        public DateTime? InsertDate { get; set; }

        public virtual Cameras IdCameraNavigation { get; set; }
        public virtual EventType IdEventTypeNavigation { get; set; }
    }
}
