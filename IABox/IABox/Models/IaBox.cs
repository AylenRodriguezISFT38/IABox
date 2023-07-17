using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class IaBox
    {
        public IaBox()
        {
            Cameras = new HashSet<Cameras>();
            EventsIabox = new HashSet<EventsIabox>();
            HeartbeatUpdate = new HashSet<HeartbeatUpdate>();
            IaboxTags = new HashSet<IaboxTags>();
            NotificationConfig = new HashSet<NotificationConfig>();
            Sensors = new HashSet<Sensors>();
            WeatherInfo = new HashSet<WeatherInfo>();
        }

        public long Id { get; set; }
        public string AccNum { get; set; }
        public string Descripcion { get; set; }
        public long? IdEmpresa { get; set; }
        public long? IdSite { get; set; }
        public string Ip { get; set; }
        public string License { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual Site IdSiteNavigation { get; set; }
        public virtual ICollection<Cameras> Cameras { get; set; }
        public virtual ICollection<EventsIabox> EventsIabox { get; set; }
        public virtual ICollection<HeartbeatUpdate> HeartbeatUpdate { get; set; }
        public virtual ICollection<IaboxTags> IaboxTags { get; set; }
        public virtual ICollection<NotificationConfig> NotificationConfig { get; set; }
        public virtual ICollection<Sensors> Sensors { get; set; }
        public virtual ICollection<WeatherInfo> WeatherInfo { get; set; }
    }
}
