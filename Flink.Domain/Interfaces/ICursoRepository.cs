using Flink.Infraestructure.Persistance;

namespace Flink.Domain.Interfaces
{
    public interface ICursoRepository
    {
        IEnumerable<Curso> GetCursos();
        Curso GetCursosId(int id);
        void InsertCurso(Curso curso);
        void UpdateCursos(Curso curso);
        void DeleteCursos(int id);
    }
}
