namespace DC.Sofi.Dao.MigrationsSeguridad
{
    using DC.Sofi.Domain;
    using DC.Sofi.Domain.Seguridad;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DC.Sofi.Dao.DbContextSeguridad>
    {
        private string _customExceptionMessage = "";
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MigrationsSeguridad";
        }

        protected override void Seed(DC.Sofi.Dao.DbContextSeguridad context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            _customExceptionMessage = "Running Seed methods in Configuration from Seguridad ... \n";
            // seeding data seguridad 22/02/2020
            SeedSeguridadMenuUsuario(context);

            _customExceptionMessage += "Data Seed Seguridad Saved OK!";
        }

        private void SeedSeguridadMenuUsuario(DbContextSeguridad context)
        {
            try
            {
                //add menu
                Menu[] menus =
                {
                    new Menu()
                    {
                        IdMenu=1,
                        IdMenuPadre = 0,
                        Descripcion = "Seguridad",
                        TieneFormulario = false,
                        Status = GlobalChars.Status.Activo
                    },
                    new Menu()
                    {
                        IdMenu = 2,
                        IdMenuPadre = 1,
                        Descripcion = "Menu",
                        TieneFormulario = true,
                        NombreFormulario = "Seguridad.FrmMenu",
                        NombreAsembly="DC.Sofi.UI.WinForm.dll",
                        Status = GlobalChars.Status.Activo
                    },
                    new Menu()
                    {
                        IdMenu = 3,
                        IdMenuPadre = 1,
                        Descripcion = "Usuarios",
                        TieneFormulario = true,
                        NombreFormulario = "Seguridad.FrmUsuarios",
                        NombreAsembly="DC.Sofi.UI.WinForm.dll",
                        Status = GlobalChars.Status.Activo
                    },
                    new Menu()
                    {
                        IdMenu = 4,
                        IdMenuPadre = 1,
                        Descripcion = "Permisos",
                        TieneFormulario = true,
                        NombreFormulario = "Seguridad.FrmPermisos",
                        NombreAsembly="DC.Sofi.UI.WinForm.dll",
                        Status = GlobalChars.Status.Activo
                    }
                };
                context.Menu.AddOrUpdate(menus);
                //add user
                Usuario[] usuarios = new Usuario[] {
                    new Usuario()
                    {
                        UserName = "sys", Descripcion = "Usuario system", Password = "@sterisco2020",
                        Status = GlobalChars.Status.Activo
                    },
                    new Usuario()
                    {
                        UserName = "andy",
                        Descripcion = "Andy Johnson",
                        Password = "@rroba64",
                        Status = GlobalChars.Status.Activo
                    }
                };
                context.Usuario.AddOrUpdate(usuarios);
                // add relacion usuario - menu
                var permisossys = menus.Select(x => new MenuByUser()
                {
                    IdMenu = x.IdMenu,
                    UserName = "sys",
                    Status = GlobalChars.Status.Activo
                });
                context.MenuByUser.AddRange(permisossys);
                var permisosandy = menus.Select(x => new MenuByUser()
                {
                    IdMenu = x.IdMenu,
                    UserName = "andy",
                    Status = GlobalChars.Status.Activo
                });
                context.MenuByUser.AddRange(permisosandy);
            }
            catch (Exception ex)
            {
                Exception ex2 = new Exception(_customExceptionMessage, ex);
                throw ex2;
            }
        }

    }
}
