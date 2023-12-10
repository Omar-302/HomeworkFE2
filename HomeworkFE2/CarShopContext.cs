using Classes;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class CarShopContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //  الاتصال بقاعدة البيانات
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Car;");
            }


        }


    }
}
