namespace DC.Sofi.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescripcionUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("Seguridad.Usuario", "Descripcion", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("Seguridad.Usuario", "Descripcion");
        }
    }
}
