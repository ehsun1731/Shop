using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistence.EF.Orders
{
    public class OrderEntityMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id)
                .UseIdentityColumn();
            builder
                .Property(_ => _.CustomerId)
                .IsRequired();
            builder.Property(_ => _.TotalPrice)
                .IsRequired(false);

        }
    }
}
