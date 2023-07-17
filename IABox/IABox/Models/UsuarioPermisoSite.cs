using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class UsuarioPermisoSite
    {
        public long Id { get; set; }
        public long IdUsuario { get; set; }
        public long IdPermiso { get; set; }
        public long IdSite { get; set; }
        public bool? Enable { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual Permiso IdPermisoNavigation { get; set; }
        public virtual Site IdSiteNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
