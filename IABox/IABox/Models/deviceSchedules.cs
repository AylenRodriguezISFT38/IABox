using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class DeviceSchedules
    {
        public long Id { get; set; }
        public long? IdCamera { get; set; }
        public long? IdSensor { get; set; }
        public string DayOfWeek { get; set; }
        public string TimeIni { get; set; }
        public string TimeEnd { get; set; }

        public virtual Cameras IdCameraNavigation { get; set; }
        public virtual Sensors IdSensorNavigation { get; set; }
    }
}
