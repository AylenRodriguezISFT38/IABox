using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class ConfigsHistory
    {
        public long Id { get; set; }
        public long IdUsuario { get; set; }
        public long IdParam { get; set; }
        public long IdCamera { get; set; }
        public long IdSensor { get; set; }
        public string Value { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
