using DC.Sofi.Dao;
using DC.Sofi.Domain.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DC.Sofi.Bo.Seguridad
{
    public class MenuBo
    {
        private DbContextSeguridad _context;
        private BaseRepository<MenuByUser> menuByUserDao;

        public MenuBo()
        {
            _context = new DbContextSeguridad(Param.DefaultConnectionString);
            menuByUserDao = new BaseRepository<MenuByUser>(_context);
        }

        public List<Menu> MenuOfUser(string userName)
        {
            var query = menuByUserDao.Find(x => x.UserName.Equals(userName));
            var list = query.Select(x=>x.Menu).ToList();
            return list;
        }

    }
}
