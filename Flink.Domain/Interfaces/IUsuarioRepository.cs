using Flink.Infraestructure.Persistance;

namespace Flink.Domain.Interfaces
{
    public interface IUsuarioRepository
   {
     IEnumerable<Usuario> GetUsuarios();
     Usuario GetUsuariosById(int id);
     void InsertUsuario(Usuario usuario);
     void UpdateUsuario(Usuario usuario);
     void DeleteUsuario(int idUsuario);
   }
}
