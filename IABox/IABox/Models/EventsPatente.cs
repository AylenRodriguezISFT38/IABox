using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class EventsPatente
    {
        public long Id { get; set; }
        public long IdEvent { get; set; }
        public string Patente { get; set; }

        public virtual Events IdEventNavigation { get; set; }
    }
}
