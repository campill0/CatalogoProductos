using CatalogoProductos.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CatalogoProductos.Data
{
    public class CatalogoProductosDbContext : DbContext
    {
        public CatalogoProductosDbContext(DbContextOptions<CatalogoProductosDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }

}
