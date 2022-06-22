using Flink.Infraestructure.Persistance;

namespace Flink.Domain.Inferfaces
{
    public interface IUserLoginRepository
    {
        IEnumerable<LoginUsuario> GetUsuarios();
        LoginUsuario GetUsuariosById(int id);
        void InsertUsuario(LoginUsuario loginusuario);
        void UpdateUsuario(LoginUsuario loginusuario);
        void DeleteUsuario(int idAdmin);
    }
}
