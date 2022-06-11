using Flink.Infraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Domain.Inferfaces
{
    public interface ICursoService
    {
        IEnumerable<Curso> GetCursos();
        Curso GetCursosId(int id);
        void InsertCurso(Curso curso);
        void UpdateCursos(Curso curso);
        void DeleteCursos(int id);
    }
}
