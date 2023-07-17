using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Ocupation
    {
        public long IdOcupation { get; set; }
        public long? IdCamera { get; set; }
        public DateTime? RegistDate { get; set; }
        public long? Ocupation1 { get; set; }

        public virtual Cameras IdCameraNavigation { get; set; }
    }
}
