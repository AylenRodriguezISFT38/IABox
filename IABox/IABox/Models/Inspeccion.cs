using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Inspeccion
    {
        public Inspeccion()
        {
            EventCheckMulta = new HashSet<EventCheckMulta>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EventCheckMulta> EventCheckMulta { get; set; }
    }
}
