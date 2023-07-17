using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Personnel
    {
        public Personnel()
        {
            EventPersonnel = new HashSet<EventPersonnel>();
            PersonelSiteListType = new HashSet<PersonelSiteListType>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public int? Dni { get; set; }
        public string MacAddress { get; set; }
        public string AccNum { get; set; }
        public byte[] Photo1 { get; set; }
        public byte[] Photo2 { get; set; }
        public byte[] Photo3 { get; set; }

        public virtual ICollection<EventPersonnel> EventPersonnel { get; set; }
        public virtual ICollection<PersonelSiteListType> PersonelSiteListType { get; set; }
    }
}
