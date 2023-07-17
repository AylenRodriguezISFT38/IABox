using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class Tags
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public long IdEmpresa { get; set; }
        public bool Enable { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
    }
}
