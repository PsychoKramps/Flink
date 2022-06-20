using Flink.Application.Requests;
using Flink.Application.Responses;

namespace Flink.Application.Interfaces
{
    public interface ICursoUsuarioService
    {
        IEnumerable<UsuarioCursoResponse> GetUsuarioCursos();
        UsuarioCursoResponse GetUsuariosCursoById(int id);
        void InsertUsuarioCurso(PostUsuarioCursoRequest usuarioCurso);
        void UpdateUsuarioCurso(UpdateUsuarioCursoRequest usuarioCurso);
        void DeleteUsuarioCurso(DeleteUsuarioCursoRequest UsuarioCursoId);
    }
}
