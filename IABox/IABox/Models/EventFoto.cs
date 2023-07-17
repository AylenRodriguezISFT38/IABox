using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class EventFoto
    {
        public long Id { get; set; }
        public long IdEvent { get; set; }
        public string NroFoto { get; set; }
        public string IdImage { get; set; }

        public virtual Events IdEventNavigation { get; set; }
    }
}
