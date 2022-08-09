using System;
using System.Collections.Generic;

namespace Flink.Infraestructure.Persistance
{
    public partial class Curso
    {
        public Curso()
        {
            UsuarioCursos = new HashSet<UsuarioCurso>();
        }

        public int Codigo { get; set; }
        public string NombreCurso { get; set; } = null!;
        public string UrlCurso { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Duracion { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoCurso { get; set; }
        public string? Categoria { get; set; }
        public string Portada { get; set; } = null!;
        public virtual ICollection<UsuarioCurso> UsuarioCursos { get; set; }
    }
}
