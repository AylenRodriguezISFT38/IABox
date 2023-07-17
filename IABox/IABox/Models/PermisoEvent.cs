using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class PermisoEvent
    {
        public long Id { get; set; }
        public long? IdPermiso { get; set; }
        public long? IdEvent { get; set; }

        public virtual EventType IdEventNavigation { get; set; }
        public virtual Permiso IdPermisoNavigation { get; set; }
    }
}
