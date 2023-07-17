using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class NotificationType1
    {
        public long Id { get; set; }
        public long IdUsuario { get; set; }
        public long IdNotificationType { get; set; }
        public long IdEventType { get; set; }
        public long IdCamera { get; set; }
        public bool Enable { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
