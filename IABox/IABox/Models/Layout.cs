using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Layout
    {
        public long Id { get; set; }
        public long IdSite { get; set; }
        public long? IdCamera { get; set; }
        public long? IdSensor { get; set; }
        public int? CoordX { get; set; }
        public int? CoordY { get; set; }
        public int? Degree { get; set; }
        public string Img { get; set; }
        public string Type { get; set; }

        public virtual Cameras IdCameraNavigation { get; set; }
        public virtual Sensors IdSensorNavigation { get; set; }
        public virtual Site IdSiteNavigation { get; set; }
    }
}
