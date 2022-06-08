using System;
using System.Collections.Generic;

namespace Flink.Infraestructure.Persistance
{
    public partial class UsuarioCurso
    {
        public int UsuarioCursoId { get; set; }
        public int? IdUsuario { get; set; }
        public int? CodigoCurso { get; set; }

        public virtual Curso? Curso { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}
