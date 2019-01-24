using DC.Sofi.Dao;
using DC.Sofi.Domain.Seguridad;
using System;
using System.Linq;

namespace DC.Sofi.Bo.Seguridad
{
    public class UsuarioBo
    {
        private DbContextSeguridad _context;
        private BaseRepository<Usuario> usuarioDao;

        public UsuarioBo()
        {
            _context = new DbContextSeguridad(Param.DefaultConnectionString);
            usuarioDao = new BaseRepository<Usuario>(_context);
        }

        public bool Login(string userName, string password)
        {
            var entity = usuarioDao.Get(userName);
            if (entity == null) return false;
            if (entity.Password.Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public Usuario Get(string userName)
        {
            var entity = usuarioDao.Get(userName);
            return entity;
        }

    }
}
