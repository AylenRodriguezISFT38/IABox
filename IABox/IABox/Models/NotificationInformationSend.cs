using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class NotificationInformationSend
    {
        public NotificationInformationSend()
        {
            NotificationInformationSendConfig = new HashSet<NotificationInformationSendConfig>();
        }

        public long Id { get; set; }
        public long? NroTelefonoEmpresa { get; set; }
        public long? InstanceId { get; set; }
        public string EmailEmpresa { get; set; }
        public string EmailPass { get; set; }
        public string ServerMail { get; set; }
        public int? PortMail { get; set; }

        public virtual ICollection<NotificationInformationSendConfig> NotificationInformationSendConfig { get; set; }
    }
}
