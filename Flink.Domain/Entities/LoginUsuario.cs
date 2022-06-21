using System;
using System.Collections.Generic;

namespace Flink.Infraestructure.Persistance
{
    public partial class LoginUsuario
    {


        public int IdAdmin { get; set; }
        public string User { get; set; } = null!;
        public string Password { get; set; }
        public bool Activo { get; set; }


    }
}
