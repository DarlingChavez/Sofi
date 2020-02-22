namespace DC.Sofi.Dao.Migrations
{
    using DC.Sofi.Domain.Seguridad;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DbContextSeguridad>
    {
        private string _customExceptionMessage = "";

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// Metodo Seed - actualiza la data 
        /// </summary>
        /// <param name="context">Contexto que será usado para insertar o actualizar la data</param>
        protected override void Seed(DbContextSeguridad context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            _customExceptionMessage += "Running Seed method in Configuration.cs ... \n";
            //aplicada
            SeguridadSeed(context);

            InventarioSeed(context);

            _customExceptionMessage += "Data seed saved ok!";

        }

        /// <summary>
        /// Seed schema Inventario
        /// </summary>
        /// <param name="context">default context</param>
        private void InventarioSeed(DbContextSeguridad context)
        {
            try
            {
                var inventario = new Menu()
                {
                    IdMenu = 5,
                    Descripcion = "Inventario",
                    IdMenuPadre = 0,
                    TieneFormulario = false,
                    NombreFormulario = string.Empty,
                    NombreAsembly = string.Empty,
                    Status = Domain.GlobalChars.Status.Activo,
                    MenuByUser = new List<MenuByUser>()
                };
                IList<Menu> menus = new List<Menu>();
                menus.Add(inventario);

                context.Menu.AddOrUpdate(menus.ToArray());

                //context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exception ex2 = new Exception(_customExceptionMessage, ex);
                throw ex2;
            }
        }

        /// <summary>
        /// Seed schema Seguridad
        /// </summary>
        /// <param name="context">default context</param>
        private void SeguridadSeed(DbContextSeguridad context)
        {
            try
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
                context.Usuario.AddOrUpdate(usuarios.ToArray());

                var seguridad = new Menu()
                {
                    IdMenu = 1,
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
                    IdMenu = 2,
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
                    IdMenu = 3,
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
                    IdMenu = 4,
                    Descripcion = "Permisos",
                    IdMenuPadre = 1,
                    TieneFormulario = true,
                    NombreFormulario = "Seguridad.FrmPermisos",
                    NombreAsembly = "DC.Sofi.UI.WinForm.dll",
                    Status = Domain.GlobalChars.Status.Activo
                };
                menus.Add(permisos);
                context.Menu.AddOrUpdate(menus.ToArray());

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
                context.MenuByUser.AddOrUpdate(menuByUsers.ToArray());
                
                //context.SaveChanges();
                //base.Seed(context);
            }
            catch (Exception ex)
            {
                Exception ex2 = new Exception(_customExceptionMessage, ex);
                throw ex2;
            }
        }

    }
}
