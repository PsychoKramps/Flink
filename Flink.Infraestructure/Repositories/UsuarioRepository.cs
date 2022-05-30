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
            return _context.Usuario;

        }

        public IEnumerable<Usuario> GetUsuarios(int id)
        {
            _context.Usuario .FirstOrDefault(x => x.IdUsuario ==  id);
            return _context.Usuario;
        }

        public void InsertUsuario (Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
  
        }
    }
}
 