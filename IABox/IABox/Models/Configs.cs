using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Configs
    {
        public long Id { get; set; }
        public long IdCamera { get; set; }
        public long IdParam { get; set; }
        public string Value { get; set; }

        public virtual Cameras IdCameraNavigation { get; set; }
        public virtual ConfigParams IdParamNavigation { get; set; }
    }
}
