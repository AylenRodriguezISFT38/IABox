using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IABox.Models.DTO
{
    public partial class SessionDTO
    {
        public string Token { get; set; }
        public DateTime Fechaexpiracion { get; set; }

        public UsuarioDTO Usuario { get; set; }
    }
}
