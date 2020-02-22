namespace DC.Sofi.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BodegaReserva_Nullable : DbMigration
    {
        public override void Up()
        {
            AddColumn("Inventario.Bodega", "IdReserva", c => c.Int());
            CreateIndex("Inventario.Bodega", "IdReserva");
            AddForeignKey("Inventario.Bodega", "IdReserva", "Inventario.Bodega", "IdBodega");
            DropColumn("Inventario.Bodega", "BodegaReserva");
        }
        
        public override void Down()
        {
            AddColumn("Inventario.Bodega", "BodegaReserva", c => c.Int(nullable: false));
            DropForeignKey("Inventario.Bodega", "IdReserva", "Inventario.Bodega");
            DropIndex("Inventario.Bodega", new[] { "IdReserva" });
            DropColumn("Inventario.Bodega", "IdReserva");
        }
    }
}
