using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Site
    {
        public Site()
        {
            IaBox = new HashSet<IaBox>();
            Layout = new HashSet<Layout>();
            PersonelSiteListType = new HashSet<PersonelSiteListType>();
            SiteSchedules = new HashSet<SiteSchedules>();
            UsuarioPermisoSite = new HashSet<UsuarioPermisoSite>();
        }

        public long Id { get; set; }
        public string AccNum { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public long IdEmpresa { get; set; }
        public bool? Enable { get; set; }
        public DateTime? InsertDate { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<IaBox> IaBox { get; set; }
        public virtual ICollection<Layout> Layout { get; set; }
        public virtual ICollection<PersonelSiteListType> PersonelSiteListType { get; set; }
        public virtual ICollection<SiteSchedules> SiteSchedules { get; set; }
        public virtual ICollection<UsuarioPermisoSite> UsuarioPermisoSite { get; set; }
    }
}
