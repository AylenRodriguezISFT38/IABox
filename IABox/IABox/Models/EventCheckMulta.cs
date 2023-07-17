using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class EventCheckMulta
    {
        public long Id { get; set; }
        public long? IdEvent { get; set; }
        public int? IdInspeccion { get; set; }

        public virtual Events IdEventNavigation { get; set; }
        public virtual Inspeccion IdInspeccionNavigation { get; set; }
    }
}
