using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class IaboxTags
    {
        public long Id { get; set; }
        public long IdIabox { get; set; }
        public int IdTag { get; set; }
        public bool Enable { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual IaBox IdIaboxNavigation { get; set; }
    }
}
