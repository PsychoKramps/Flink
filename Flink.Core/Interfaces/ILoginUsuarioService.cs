using Flink.Application.Requests;
using Flink.Application.Responses;

namespace Flink.Application.Interfaces
{
    public interface ILoginUsuarioService
    {
        IEnumerable<LoginUsuarioResponse> GetLoginUsuario();
        LoginUsuarioResponse GetLoginUsuarioById(int id);
        void InsertLoginUsuario(PostUserLoginRequest loginUsuariopost);
        // void UpdateUsuario(UpdateLoginUserRequest loginusuario);
        // void DeleteUsuario(int idAdmin);
    }
}
