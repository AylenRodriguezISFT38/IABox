using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class SensorsType
    {
        public SensorsType()
        {
            Sensors = new HashSet<Sensors>();
        }

        public long Id { get; set; }
        public string Description { get; set; }
        public bool Enable { get; set; }

        public virtual ICollection<Sensors> Sensors { get; set; }
    }
}
