using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Usuario
    {
        public Usuario()
        {
            NotificationConfig = new HashSet<NotificationConfig>();
            Session = new HashSet<Session>();
            UsuarioPermisoSite = new HashSet<UsuarioPermisoSite>();
        }

        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public byte[] Salt { get; set; }
        public long? IdEmpresa { get; set; }
        public string PantallaDefault { get; set; }
        public long? TelegramId { get; set; }
        public string Email { get; set; }
        public bool? Enable { get; set; }
        public DateTime InserDate { get; set; }
        public long? Telefono { get; set; }
        public bool IsUserIa { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<NotificationConfig> NotificationConfig { get; set; }
        public virtual ICollection<Session> Session { get; set; }
        public virtual ICollection<UsuarioPermisoSite> UsuarioPermisoSite { get; set; }
    }
}
