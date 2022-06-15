using Flink.Application.Requests;
using Flink.Application.Responses;

namespace Flink.Application.Inferfaces
{
    public interface ICursoService
    {
        IEnumerable<CursoResponse> GetCursos();
        CursoResponse GetCursosId(int id);
        void InsertCurso(PostCursoRequest curso);
        void UpdateCursos(PutCursoRequest curso);
        void DeleteCursos(DeleteCursoRequest id);
    }
}
