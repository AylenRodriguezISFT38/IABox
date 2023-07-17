﻿using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class ConfigSensors
    {
        public long Id { get; set; }
        public long IdSensor { get; set; }
        public long IdParam { get; set; }
        public string Value { get; set; }

        public virtual ConfigParams IdParamNavigation { get; set; }
        public virtual Sensors IdSensorNavigation { get; set; }
    }
}
