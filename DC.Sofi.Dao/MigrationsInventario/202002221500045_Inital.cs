namespace DC.Sofi.Dao.MigrationsInventario
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inital : DbMigration
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
                "Inventario.Existencia",
                c => new
                    {
                        IdArticulo = c.Int(nullable: false),
                        IdBodega = c.Int(nullable: false),
                        CantidadVirtual = c.Int(nullable: false),
                        TieneReserva = c.Int(nullable: false),
                        IdReserva = c.Int(),
                        CantidadReserva = c.Int(nullable: false),
                        Fisico = c.Int(nullable: false),
                        Status = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => new { t.IdArticulo, t.IdBodega })
                .ForeignKey("Inventario.Articulo", t => t.IdArticulo, cascadeDelete: true)
                .ForeignKey("Inventario.Bodega", t => t.IdBodega, cascadeDelete: true)
                .Index(t => t.IdArticulo)
                .Index(t => t.IdBodega);
            
            CreateTable(
                "Inventario.Bodega",
                c => new
                    {
                        IdBodega = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        TieneReserva = c.Boolean(nullable: false),
                        EsRerserva = c.Boolean(nullable: false),
                        IdReserva = c.Int(),
                        Status = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.IdBodega)
                .ForeignKey("Inventario.Bodega", t => t.IdReserva)
                .Index(t => t.IdReserva);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("Inventario.Articulo", "LineaId", "Inventario.Linea");
            DropForeignKey("Inventario.Linea", "PadreId", "Inventario.Linea");
            DropForeignKey("Inventario.Articulo", "GrupoId", "Inventario.Grupo");
            DropForeignKey("Inventario.Existencia", "IdBodega", "Inventario.Bodega");
            DropForeignKey("Inventario.Bodega", "IdReserva", "Inventario.Bodega");
            DropForeignKey("Inventario.Existencia", "IdArticulo", "Inventario.Articulo");
            DropIndex("Inventario.Linea", new[] { "PadreId" });
            DropIndex("Inventario.Bodega", new[] { "IdReserva" });
            DropIndex("Inventario.Existencia", new[] { "IdBodega" });
            DropIndex("Inventario.Existencia", new[] { "IdArticulo" });
            DropIndex("Inventario.Articulo", new[] { "LineaId" });
            DropIndex("Inventario.Articulo", new[] { "GrupoId" });
            DropTable("Inventario.Linea");
            DropTable("Inventario.Grupo");
            DropTable("Inventario.Bodega");
            DropTable("Inventario.Existencia");
            DropTable("Inventario.Articulo");
        }
    }
}
