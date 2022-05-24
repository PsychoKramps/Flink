using System;
using System.Collections.Generic;

namespace Flink.Infraestructure.Persistance
{
    public partial class TblUsuario
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string NombreUsuario { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
    }
}
