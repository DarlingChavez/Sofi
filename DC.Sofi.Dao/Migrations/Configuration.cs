namespace DC.Sofi.Dao.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using DC.Sofi.Domain.Seguridad;

    internal sealed class Configuration : DbMigrationsConfiguration<DbContextSeguridad>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DbContextSeguridad context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //aplicada
            SeguridadSeed(context);

            
        }

        private void SeguridadSeed(DbContextSeguridad context)
        {
            var administrador = new Usuario()
            {
                UserName = "sys",
                Password = "@rroba",
                Descripcion = "Usuario de sistemas",
                Status = Domain.GlobalChars.Status.Activo,
                MenuByUser = new List<MenuByUser>()
            };
            IList<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(administrador);
            context.Usuario.AddRange(usuarios);

            var seguridad = new Menu()
            {
                Descripcion = "Seguridad",
                IdMenuPadre = 0,
                TieneFormulario = false,
                NombreFormulario = string.Empty,
                NombreAsembly = string.Empty,
                Status = Domain.GlobalChars.Status.Activo,
                MenuByUser = new List<MenuByUser>()
            };
            IList<Menu> menus = new List<Menu>();
            menus.Add(seguridad);
            var menu = new Menu()
            {
                Descripcion = "Menu",
                IdMenuPadre = 1,
                TieneFormulario = true,
                NombreFormulario = "Seguridad.FrmMenu",
                NombreAsembly = "DC.Sofi.UI.WinForm.dll",
                Status = Domain.GlobalChars.Status.Activo,
                MenuByUser = new List<MenuByUser>()
            };
            menus.Add(menu);
            var usuario = new Menu()
            {
                Descripcion = "Usuarios",
                IdMenuPadre = 1,
                TieneFormulario = true,
                NombreFormulario = "Seguridad.FrmUsuarios",
                NombreAsembly = "DC.Sofi.UI.WinForm.dll",
                Status = Domain.GlobalChars.Status.Activo,
                MenuByUser = new List<MenuByUser>()
            };
            menus.Add(usuario);
            var permisos = new Menu()
            {
                Descripcion = "Permisos",
                IdMenuPadre = 1,
                TieneFormulario = true,
                NombreFormulario = "Seguridad.FrmPermisos",
                NombreAsembly = "DC.Sofi.UI.WinForm.dll",
                Status = Domain.GlobalChars.Status.Activo
            };
            menus.Add(permisos);
            context.Menu.AddRange(menus);

            IList<MenuByUser> menuByUsers = new List<MenuByUser>();
            menuByUsers.Add(new MenuByUser()
            {
                UserName = "sys",
                IdMenu = 1,
                Insert = false,
                Update = false,
                Destroy = false,
                Permisos = string.Empty,
                Status = Domain.GlobalChars.Status.Activo
            });
            menuByUsers.Add(new MenuByUser()
            {
                UserName = "sys",
                IdMenu = 2,
                Insert = false,
                Update = false,
                Destroy = false,
                Permisos = string.Empty,
                Status = Domain.GlobalChars.Status.Activo
            });
            menuByUsers.Add(new MenuByUser()
            {
                UserName = "sys",
                IdMenu = 3,
                Insert = false,
                Update = false,
                Destroy = false,
                Permisos = string.Empty,
                Status = Domain.GlobalChars.Status.Activo
            });
            menuByUsers.Add(new MenuByUser()
            {
                UserName = "sys",
                IdMenu = 4,
                Insert = false,
                Update = false,
                Destroy = false,
                Permisos = string.Empty,
                Status = Domain.GlobalChars.Status.Activo
            });
            context.MenuByUser.AddRange(menuByUsers);

            base.Seed(context);
        }

    }
}
