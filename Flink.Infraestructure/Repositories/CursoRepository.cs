using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Persistance;

namespace Flink.Infraestructure.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private FlinkContext _context;
        public CursoRepository(FlinkContext context)
        {
            _context = context;
        }
        public IEnumerable<Curso> GetCursos()
        {
            return _context.Cursos;
        }

        public Curso GetCursosId(int id)
        {
            var returnCurso = _context.Cursos.FirstOrDefault(x => x.Codigo == id);
            return returnCurso;
        }

        public void InsertCurso(Curso curso)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();
        }

        public void UpdateCursos(Curso curso)
        {
            var DataCursos = _context.Cursos.FirstOrDefault(x => x.Codigo == curso.Codigo);
            DataCursos.Codigo = curso.Codigo;
            DataCursos.NombreCurso = curso.NombreCurso;
            DataCursos.UrlCurso = curso.UrlCurso;
            DataCursos.Fecha = curso.Fecha;
            DataCursos.Duracion = curso.Duracion;
            DataCursos.Descripcion = curso.Descripcion;
            DataCursos.TipoCurso = curso.TipoCurso;
            DataCursos.Categoria = curso.Categoria;
            _context.SaveChanges();
        }
        public void DeleteCursos(int id)
        {
            var returnCurso = _context.Cursos.FirstOrDefault(x => x.Codigo == id);
            _context.Cursos.Remove(returnCurso);
            _context.SaveChanges();
        }
    }
}
