using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Session
    {
        public long Id { get; set; }
        public long IdUsuario { get; set; }
        public string Token { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? FechaExpiracion { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
