namespace Ventas.Domain.Models
{
    using System.Data.Entity;
    using Common.Models;

    public class DataContext : DbContext
    {
        public DataContext() : base("VentasBackEndConnection")
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
