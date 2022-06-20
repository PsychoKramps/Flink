using Flink.Infraestructure.Persistance;

namespace Flink.Domain.Inferfaces
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
