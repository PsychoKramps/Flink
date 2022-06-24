using Flink.Infraestructure.Persistance;

namespace Flink.Domain.Interfaces
{
    public interface IUserLoginRepository
    {
        IEnumerable<LoginUsuario> GetLoginUsuario();
        LoginUsuario GetLoginUsuarioById(int id);
        void InsertLoginUsuario(LoginUsuario loginusuario);
        // void UpdateLoginUsuario(LoginUsuario loginusuario);
        // void DeleteLoginUsuario(int idAdmin);
    }
}
