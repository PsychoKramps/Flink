using Flink.Application.Requests;
using Flink.Application.Responses;
using Flink.Infraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
