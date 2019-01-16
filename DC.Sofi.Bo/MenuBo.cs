using DC.Sofi.Dao;
using DC.Sofi.Domain;
using DC.Sofi.Domain.Seguridad;
using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace DC.Sofi.Bo
{
    public class MenuBo
    {
        private DbContextSeguridad _context;
        private BaseRepository<Menu> menuDao;
        private BaseRepository<MenuByUser> menuByUserDao;
        private BaseRepository<Usuario> usuarioDao;

        public MenuBo()
        {
            _context = new DbContextSeguridad();
            menuDao = new BaseRepository<Menu>(_context);
            menuByUserDao = new BaseRepository<MenuByUser>(_context);
            usuarioDao = new BaseRepository<Usuario>(_context);

        }

        public List<MenuByUser> MenuOfUser(string userName)
        {
            var query = menuByUserDao.Find(x => x.UserName.Equals(userName));
            var list = query.ToList();
            return list;
        }
        
    }
}
