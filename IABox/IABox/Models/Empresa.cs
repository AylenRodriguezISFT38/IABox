using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Empresa
    {
        public Empresa()
        {
            IaBox = new HashSet<IaBox>();
            NotificationInformationSendConfig = new HashSet<NotificationInformationSendConfig>();
            Site = new HashSet<Site>();
            Tags = new HashSet<Tags>();
            Usuario = new HashSet<Usuario>();
        }

        public long Id { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<IaBox> IaBox { get; set; }
        public virtual ICollection<NotificationInformationSendConfig> NotificationInformationSendConfig { get; set; }
        public virtual ICollection<Site> Site { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
