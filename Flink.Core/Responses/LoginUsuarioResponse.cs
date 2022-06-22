using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Application.Responses
{
    public class LoginUsuarioResponse
    {
        public int IdAdmin { get; set; }
        public string User { get; set; } = null!;
        public string Password { get; set; }
        public bool Activo { get; set; }
    }
}
