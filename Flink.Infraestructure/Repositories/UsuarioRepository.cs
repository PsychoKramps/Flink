using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Infraestructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private FlinkContext _context;
        public UsuarioRepository(FlinkContext context)
        {
            _context = context;
        }
        public IEnumerable<Usuario> GetUsuarios()
        {
            return _context.Usuarios;

        }
    }
}
