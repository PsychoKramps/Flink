using Flink.Infraestructure.Persistance;

namespace Flink.Domain.Inferfaces
{
    public interface IUserLoginRepository
    {
        IEnumerable<LoginUsuario> GetUsuarios();
        LoginUsuario GetUsuariosById(int id);
        void InsertUsuario(LoginUsuario usuario);
        void UpdateUsuario(LoginUsuario usuario);
        void DeleteUsuario(int idUsuario);
    }
}
