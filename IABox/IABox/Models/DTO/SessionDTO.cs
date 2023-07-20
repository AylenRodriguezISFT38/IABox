using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IABox.Models.DTO
{
    public class SessionDTO
    {
        public string Token { get; set; }
        public DateTime Fechaexpiracion { get; set; }

        public UsuarioDTO Usuario { get; set; }

    }
    public class PermissionModules
    {
        public string Url { get; set; }
        public string Codigo { get; set; }
        public List<long> IdEvent { get; set; }
    }

}
