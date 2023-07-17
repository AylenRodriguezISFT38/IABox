using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Cameras
    {
        public Cameras()
        {
            CamerasEventTypes = new HashSet<CamerasEventTypes>();
            Configs = new HashSet<Configs>();
            DeviceSchedules = new HashSet<DeviceSchedules>();
            Events = new HashSet<Events>();
            Layout = new HashSet<Layout>();
            Ocupation = new HashSet<Ocupation>();
        }

        public long IdCamera { get; set; }
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public bool Enabled { get; set; }
        public int? MaxOcupation { get; set; }
        public int? Area { get; set; }
        public long? IdIabox { get; set; }

        public virtual IaBox IdIaboxNavigation { get; set; }
        public virtual ICollection<CamerasEventTypes> CamerasEventTypes { get; set; }
        public virtual ICollection<Configs> Configs { get; set; }
        public virtual ICollection<DeviceSchedules> DeviceSchedules { get; set; }
        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<Layout> Layout { get; set; }
        public virtual ICollection<Ocupation> Ocupation { get; set; }
    }
}
