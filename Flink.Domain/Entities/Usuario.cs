using System;
using System.Collections.Generic;

namespace Flink.Infraestructure.Persistance
{
    public partial class Usuario
    {
        public Usuario()
        {
            UsuarioCursos = new HashSet<UsuarioCurso>();
        }

        public int IdUsuario { get; set; }
        public string Nombre1 { get; set; } = null!;
        public string? Nombre2 { get; set; }
        public string Apellido1 { get; set; } = null!;
        public string? Apellido2 { get; set; }
        public string Correo { get; set; } = null!;
        public string NombreUsuario { get; set; } = null!;
        public string Contraseña { get; set; } = null!;

        public virtual ICollection<UsuarioCurso> UsuarioCursos { get; set; }
    }
}
