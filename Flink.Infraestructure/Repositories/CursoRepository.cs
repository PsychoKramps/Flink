using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
