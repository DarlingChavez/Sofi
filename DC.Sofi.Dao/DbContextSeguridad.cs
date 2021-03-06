﻿using DC.Sofi.Domain.Seguridad;
using System;
using System.Data.Entity;
using System.Linq;

namespace DC.Sofi.Dao
{
    public class DbContextSeguridad : DbContext
    {
        public DbContextSeguridad() : base("name=DefaultConnectionString")
        {
            
        }
        public DbContextSeguridad(string connectionString) : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<MenuByUser> MenuByUser { get; set; }
        

    }
}
