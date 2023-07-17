using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entity
{
    public class SubModule
    {
        public SubModule()
        {
            EventSubModulos = new HashSet<EventSubModulos>();
        }
        public long Id { get; set; }
        public string Item { get; set; }

        public virtual ICollection<EventSubModulos> EventSubModulos { get; set; }
    }

    public class SubModuleType
    {
        public SubModuleType()
        {
            EventSubModulos = new HashSet<EventSubModulos>();
        } 

        public long Id { get; set; }
        public string Categoria { get; set; }

        public virtual ICollection<EventSubModulos> EventSubModulos { get; set; }
    }
}
