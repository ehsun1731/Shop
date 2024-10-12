using Microsoft.EntityFrameworkCore;
using Shop.Entities.Customers;
using Shop.Entities.OrderDetails;
using Shop.Entities.Orders;
using Shop.Entities.Products;
using Shop.Persistence.EF.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistence.EF
{




    public class EFDataContext : DbContext
    {
        public EFDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Users { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }






        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(
                    typeof(OrderEntityMap).Assembly);
        }
    }
}
