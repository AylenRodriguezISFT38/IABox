using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class NotificationInformationSendConfig
    {
        public long Id { get; set; }
        public long IdEmpresa { get; set; }
        public long IdInfoSend { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual NotificationInformationSend IdInfoSendNavigation { get; set; }
    }
}
