using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class SubModulos
    {
        public SubModulos()
        {
            EventSubModulos = new HashSet<EventSubModulos>();
        }

        public long Id { get; set; }
        public string Item { get; set; }

        public virtual ICollection<EventSubModulos> EventSubModulos { get; set; }
    }
}
