using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Infraestructure.Repositories
{
    public class UserLoginRepository 
    {
        private FlinkContext _context;
        public void DeleteUsuario(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoginUsuario> GetUsuarios()
        {
            throw new NotImplementedException();
        }

        public Usuario GetUsuariosById(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void UpdateUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
