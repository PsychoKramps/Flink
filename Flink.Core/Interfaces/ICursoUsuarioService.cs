using Flink.Application.Requests;
using Flink.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
