using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Application.Requests
{
     public class UpdateUsuarioCursoRequest
    {
        public int UsuarioCursoId { get; set; }

        public int? IdUsuario { get; set; }
        public int? CodigoCurso { get; set; }
    }
}
