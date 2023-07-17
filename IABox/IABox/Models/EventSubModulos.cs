using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class EventSubModulos
    {
        public long Id { get; set; }
        public long? IdEvent { get; set; }
        public long? IdSubModulo { get; set; }
        public long? IdSubModuloType { get; set; }

        public virtual EventType IdEventNavigation { get; set; }
        public virtual SubModulos IdSubModuloNavigation { get; set; }
        public virtual SubModulosTypes IdSubModuloTypeNavigation { get; set; }
    }
}
