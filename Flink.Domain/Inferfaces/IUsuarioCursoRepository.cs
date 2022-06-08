using Flink.Infraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Domain.Inferfaces
{
    public interface IUsuarioCursoRepository
    {
        IEnumerable<UsuarioCurso> GetUsuarioCursos();
        UsuarioCurso GetUsuariosCursoById(int id);
        void InsertUsuarioCurso(UsuarioCurso usuariocurso);
        void UpdateUsuarioCurso(UsuarioCurso usuariocurso);
        void DeleteUsuarioCurso(int usuarioCursoId);
    }
}
