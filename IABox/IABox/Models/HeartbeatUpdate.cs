using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class HeartbeatUpdate
    {
        public long Id { get; set; }
        public long IdIabox { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool Enabled { get; set; }

        public virtual IaBox IdIaboxNavigation { get; set; }
    }
}
