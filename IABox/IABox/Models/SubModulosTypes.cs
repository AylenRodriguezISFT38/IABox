using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class SubModulosTypes
    {
        public SubModulosTypes()
        {
            EventSubModulos = new HashSet<EventSubModulos>();
        }

        public long Id { get; set; }
        public string Categoria { get; set; }

        public virtual ICollection<EventSubModulos> EventSubModulos { get; set; }
    }
}
