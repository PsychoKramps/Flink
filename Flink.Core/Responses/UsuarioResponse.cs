using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Application.Responses
{
    public class UsuarioResponse
    {
        public int IdUsuario { get; set; }
        public string Nombre1 { get; set; } = null!;
        public string? Nombre2 { get; set; }
        public string Apellido1 { get; set; } = null!;
        public string? Apellido2 { get; set; }
        public string Correo { get; set; } = null!;
        public string NombreUsuario { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
    }
}
