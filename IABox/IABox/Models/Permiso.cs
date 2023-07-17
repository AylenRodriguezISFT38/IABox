using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Permiso
    {
        public Permiso()
        {
            PermisoEvent = new HashSet<PermisoEvent>();
            UsuarioPermisoSite = new HashSet<UsuarioPermisoSite>();
        }

        public long Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool? Enable { get; set; }

        public virtual ICollection<PermisoEvent> PermisoEvent { get; set; }
        public virtual ICollection<UsuarioPermisoSite> UsuarioPermisoSite { get; set; }
    }
}
