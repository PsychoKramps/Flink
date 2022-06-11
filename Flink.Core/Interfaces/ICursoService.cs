using Flink.Application.Requests;
using Flink.Infraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Application.Inferfaces
{
    public interface ICursoService
    {
        IEnumerable<ResponseCursoRequest> GetCursos();
        ResponseCursoRequest GetCursosId(int id);
        void InsertCurso(PostCursoRequest curso);
        void UpdateCursos(PutCursoRequest curso);
        void DeleteCursos(int id);
    }
}
