using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class EventPersonnel
    {
        public long Id { get; set; }
        public long IdEvent { get; set; }
        public long IdPerssonel { get; set; }

        public virtual Events IdEventNavigation { get; set; }
        public virtual Personnel IdPerssonelNavigation { get; set; }
    }
}
