using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class ConfigParams
    {
        public ConfigParams()
        {
            ConfigSensors = new HashSet<ConfigSensors>();
            Configs = new HashSet<Configs>();
        }

        public long Id { get; set; }
        public string Label { get; set; }
        public int EventType { get; set; }
        public string Unit { get; set; }
        public bool? IsFloat { get; set; }

        public virtual ICollection<ConfigSensors> ConfigSensors { get; set; }
        public virtual ICollection<Configs> Configs { get; set; }
    }
}
