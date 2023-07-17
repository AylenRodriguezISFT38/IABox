using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class MacAddressPersonnel
    {
        public int Id { get; set; }
        public int IdMacAddress { get; set; }
        public int IdPersonnel { get; set; }

        public virtual MacAddress IdMacAddressNavigation { get; set; }
        //public virtual Personnel IdPersonnelNavigation { get; set; }
    }
}
