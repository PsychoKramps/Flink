using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Persistance;

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

        public Usuario GetUsuariosById(int idUsuario)
        {
            return _context.Usuario.FirstOrDefault(x => x.IdUsuario == idUsuario);
        }

        public void InsertUsuario(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();

        }

        public void UpdateUsuario(Usuario usuario)
        {
            var DataUsuario = _context.Usuario.FirstOrDefault(x => x.IdUsuario == usuario.IdUsuario);
            DataUsuario.IdUsuario = usuario.IdUsuario;
            DataUsuario.Nombre1 = usuario.Nombre1;
            DataUsuario.Nombre2 = usuario.Nombre2;
            DataUsuario.Apellido1 = usuario.Apellido1;
            DataUsuario.Apellido2 = usuario.Apellido2;
            DataUsuario.Correo = usuario.Correo;
            DataUsuario.NombreUsuario = usuario.NombreUsuario;
            DataUsuario.Contraseña = usuario.Contraseña;

            _context.SaveChanges();
        }

        public void DeleteUsuario(int idUsuario)
        {
            var usuario = _context.Usuario.FirstOrDefault(x => x.IdUsuario == idUsuario);
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();
        }
    }
}