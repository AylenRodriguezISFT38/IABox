using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Sensors
    {
        public Sensors()
        {
            ConfigSensors = new HashSet<ConfigSensors>();
            DeviceSchedules = new HashSet<DeviceSchedules>();
            EventsSensors = new HashSet<EventsSensors>();
            Layout = new HashSet<Layout>();
        }

        public long IdSensor { get; set; }
        public long IdType { get; set; }
        public string Name { get; set; }
        public bool? Enable { get; set; }
        public long IdIabox { get; set; }

        public virtual IaBox IdIaboxNavigation { get; set; }
        public virtual SensorsType IdTypeNavigation { get; set; }
        public virtual ICollection<ConfigSensors> ConfigSensors { get; set; }
        public virtual ICollection<DeviceSchedules> DeviceSchedules { get; set; }
        public virtual ICollection<EventsSensors> EventsSensors { get; set; }
        public virtual ICollection<Layout> Layout { get; set; }
    }
}
