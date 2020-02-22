namespace DC.Sofi.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables_ArticuloBodegaGrupoLinea : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Inventario.Articulo",
                c => new
                    {
                        IdArticulo = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        GrupoId = c.Int(),
                        LineaId = c.Int(),
                        TipoProducto = c.String(nullable: false, maxLength: 1),
                        Status = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.IdArticulo)
                .ForeignKey("Inventario.Grupo", t => t.GrupoId)
                .ForeignKey("Inventario.Linea", t => t.LineaId)
                .Index(t => t.GrupoId)
                .Index(t => t.LineaId);
            
            CreateTable(
                "Inventario.Grupo",
                c => new
                    {
                        IdGrupo = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Status = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.IdGrupo);
            
            CreateTable(
                "Inventario.Linea",
                c => new
                    {
                        IdLinea = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 6),
                        TienePadre = c.Boolean(nullable: false),
                        PadreId = c.Int(),
                        Status = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.IdLinea)
                .ForeignKey("Inventario.Linea", t => t.PadreId)
                .Index(t => t.PadreId);
            
            CreateTable(
                "Inventario.Bodega",
                c => new
                    {
                        IdBodega = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        TieneReserva = c.Boolean(nullable: false),
                        EsRerserva = c.Boolean(nullable: false),
                        BodegaReserva = c.Int(nullable: false),
                        Status = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.IdBodega);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Inventario.Articulo", "LineaId", "Inventario.Linea");
            DropForeignKey("Inventario.Linea", "PadreId", "Inventario.Linea");
            DropForeignKey("Inventario.Articulo", "GrupoId", "Inventario.Grupo");
            DropIndex("Inventario.Linea", new[] { "PadreId" });
            DropIndex("Inventario.Articulo", new[] { "LineaId" });
            DropIndex("Inventario.Articulo", new[] { "GrupoId" });
            DropTable("Inventario.Bodega");
            DropTable("Inventario.Linea");
            DropTable("Inventario.Grupo");
            DropTable("Inventario.Articulo");
        }
    }
}
