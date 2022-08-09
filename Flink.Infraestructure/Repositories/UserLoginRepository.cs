﻿using Flink.Domain.Interfaces;
using Flink.Infraestructure.Persistance;

namespace Flink.Infraestructure.Repositories
{
    public class UserLoginRepository : IUserLoginRepository
    {
        private FlinkContext _context;

        public UserLoginRepository(FlinkContext context)
        {
            _context = context;
        }

        public IEnumerable<LoginUsuario> GetLoginUsuario()
        {
            return _context.LoginUsuario;
        }

        public LoginUsuario GetLoginUsuarioById(int id)
        {
            return _context.LoginUsuario.FirstOrDefault(x => x.IdAdmin == id);
        }

        public LoginUsuario GetLoginUsuarioByName(string name)
        {
            return _context.LoginUsuario.FirstOrDefault(x => x.User == name);
        }

        public void InsertLoginUsuario(LoginUsuario loginusuario)
        {
            _context.LoginUsuario.Add(loginusuario);
            _context.SaveChanges();
        }

    }
}
