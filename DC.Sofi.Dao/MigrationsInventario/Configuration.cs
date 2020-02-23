namespace DC.Sofi.Dao.MigrationsInventario
{
    using DC.Sofi.Domain;
    using DC.Sofi.Domain.Inventario;
    using DC.Sofi.Domain.Seguridad;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DC.Sofi.Dao.DbContextInventario>
    {
        private string _customExceptionMessage = "";
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MigrationsInventario";
        }

        protected override void Seed(DC.Sofi.Dao.DbContextInventario context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            _customExceptionMessage = "Running Seed methods in Configuration from Seguridad ... \n";
            //seeding menu 22/02/2020
            SeedInventarioInSeguridad();

            _customExceptionMessage = "Data Seed Inventario in Seguridad Saved OK!";
            Console.WriteLine(_customExceptionMessage);
        }

        private void SeedInventarioInSeguridad()
        {
            try
            {
                using (DbContextSeguridad DbSeguridad = new DbContextSeguridad())
                {
                    //add menu
                    Menu[] menus =
                    {
                        new Menu()
                        {
                            IdMenu=5,
                            IdMenuPadre = 0,
                            Descripcion = "Inventario",
                            TieneFormulario = false,
                            Status = GlobalChars.Status.Activo
                        },
                        new Menu()
                        {
                            IdMenu=6,
                            IdMenuPadre = 5,
                            Descripcion = "Bodega",
                            TieneFormulario = true,
                            NombreFormulario = "Inventario.FrmBodega",
                            NombreAsembly = "DC.Sofi.UI.WinForm.dll",
                            Status = GlobalChars.Status.Activo
                        },
                        new Menu()
                        {
                            IdMenu=7,
                            IdMenuPadre = 5,
                            Descripcion = "Grupo",
                            TieneFormulario = true,
                            NombreFormulario = "Inventario.FrmGrupo",
                            NombreAsembly = "DC.Sofi.UI.WinForm.dll",
                            Status = GlobalChars.Status.Activo
                        },
                        new Menu()
                        {
                            IdMenu=8,
                            IdMenuPadre = 5,
                            Descripcion = "Linea",
                            TieneFormulario = true,
                            NombreFormulario = "Inventario.FrmLinea",
                            NombreAsembly = "DC.Sofi.UI.WinForm.dll",
                            Status = GlobalChars.Status.Activo
                        },
                        new Menu()
                        {
                            IdMenu=9,
                            IdMenuPadre = 5,
                            Descripcion = "Articulo",
                            TieneFormulario = true,
                            NombreFormulario = "Inventario.FrmArticulo",
                            NombreAsembly = "DC.Sofi.UI.WinForm.dll",
                            Status = GlobalChars.Status.Activo
                        }
                    };
                    DbSeguridad.Menu.AddOrUpdate(menus);
                    
                    // add relacion usuario - menu
                    var permisossys = menus.Select(x => new MenuByUser()
                    {
                        IdMenu = x.IdMenu,
                        UserName = "sys",
                        Status = GlobalChars.Status.Activo
                    }).ToArray();
                    DbSeguridad.MenuByUser.AddOrUpdate(permisossys);
                    var permisosandy = menus.Select(x => new MenuByUser()
                    {
                        IdMenu = x.IdMenu,
                        UserName = "andy",
                        Status = GlobalChars.Status.Activo
                    }).ToArray();
                    DbSeguridad.MenuByUser.AddOrUpdate(permisosandy);
                    DbSeguridad.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Exception ex2 = new Exception(_customExceptionMessage, ex);
                throw ex2;
            }
        }
    }
}
