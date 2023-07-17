using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class EventsIabox
    {
        public long Id { get; set; }
        public long IdIabox { get; set; }
        public DateTime DateEvent { get; set; }
        public int? Value { get; set; }
        public long IdEventType { get; set; }

        public virtual IaBox IdIaboxNavigation { get; set; }
    }
}
