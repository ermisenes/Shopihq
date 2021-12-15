using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework
{
    public class OrderContext : DbContext
    {
      

        //public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.("Server=localhost;Database=kutuphanedb;Uid=root;Pwd=12345;");
            optionsBuilder.UseInMemoryDatabase(databaseName: "OrderDB");
        }
        public DbSet<Order> Orders { get; set; }
    }
}
