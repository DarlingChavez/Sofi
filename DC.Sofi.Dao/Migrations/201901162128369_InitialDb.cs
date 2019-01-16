namespace DC.Sofi.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Seguridad.Menu",
                c => new
                    {
                        IdMenu = c.Int(nullable: false, identity: true),
                        IdMenuPadre = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 50),
                        TieneFormulario = c.Boolean(nullable: false),
                        NombreFormulario = c.String(maxLength: 50),
                        NombreAsembly = c.String(maxLength: 150),
                        Status = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.IdMenu);
            
            CreateTable(
                "Seguridad.MenuByUser",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 15),
                        IdMenu = c.Int(nullable: false),
                        Insert = c.Boolean(nullable: false),
                        Update = c.Boolean(nullable: false),
                        Destroy = c.Boolean(nullable: false),
                        Permisos = c.String(),
                        Status = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => new { t.UserName, t.IdMenu })
                .ForeignKey("Seguridad.Menu", t => t.IdMenu, cascadeDelete: true)
                .ForeignKey("Seguridad.Usuario", t => t.UserName, cascadeDelete: true)
                .Index(t => t.UserName)
                .Index(t => t.IdMenu);
            
            CreateTable(
                "Seguridad.Usuario",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false, maxLength: 50),
                        Status = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Seguridad.MenuByUser", "UserName", "Seguridad.Usuario");
            DropForeignKey("Seguridad.MenuByUser", "IdMenu", "Seguridad.Menu");
            DropIndex("Seguridad.MenuByUser", new[] { "IdMenu" });
            DropIndex("Seguridad.MenuByUser", new[] { "UserName" });
            DropTable("Seguridad.Usuario");
            DropTable("Seguridad.MenuByUser");
            DropTable("Seguridad.Menu");
        }
    }
}
