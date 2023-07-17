using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Images
    {
        public Images()
        {
            Events = new HashSet<Events>();
        }

        public int IdImage { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<Events> Events { get; set; }
    }
}
