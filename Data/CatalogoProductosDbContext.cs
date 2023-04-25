using CatalogoProductos.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CatalogoProductos.Data
{
    public class CatalogoProductosDbContext : DbContext
    {
        public CatalogoProductosDbContext(DbContextOptions<CatalogoProductosDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.HasDefaultSchema("");
            modelBuilder.Entity<Producto>().ToTable("PRODUCTOS");
            modelBuilder.Entity<Producto>().Property(p => p.Id).HasColumnName("ID");
            modelBuilder.Entity<Producto>().Property(p => p.Nombre).HasColumnName("NOMBRE");
            modelBuilder.Entity<Producto>().Property(p => p.Descripcion).HasColumnName("DESCRIPCION");
            modelBuilder.Entity<Producto>().Property(p => p.Precio).HasColumnName("PRECIO");
            modelBuilder.Entity<Producto>().HasKey(p => p.Id);
       

           

            base.OnModelCreating(modelBuilder);
        }
    }

}


