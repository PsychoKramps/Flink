using Flink.Application.Requests;
using Flink.Application.Responses;

namespace Flink.Domain.Application
{
    public interface IUsuarioService
    {
        IEnumerable<UsuarioResponse> GetUsuarios();
        UsuarioResponse GetUsuariosById(int id);
        void InsertUsuario(CreateUsuarioRequest usuario);
        void UpdateUsuario(UpdateUsuarioRequest usuario);
        void DeleteUsuario(DeleteUsuarioRequest idUsuario);

    }
}
