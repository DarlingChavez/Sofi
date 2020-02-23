using DC.Sofi.Domain.Inventario;
using System;
using System.Data.Entity;
using System.Linq;

namespace DC.Sofi.Dao
{
    public class DbContextInventario : DbContext
    {
        public DbContextInventario() : base("name=DefaultConnectionString")
        {

        }
        public DbContextInventario(string connectionString) : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Bodega> Bodega { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Linea> Linea { get; set; }
        public virtual DbSet<Articulo> Articulo { get; set; }
        public virtual DbSet<Existencia> Existencia { get; set; }

    }
}
