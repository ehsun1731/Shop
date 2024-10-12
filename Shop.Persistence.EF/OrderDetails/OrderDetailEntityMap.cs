using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Entities.OrderDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistence.EF.OrderDetails
{
    public class OrderDetailEntityMap : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");

            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id)
                .UseIdentityColumn();
            builder
                .Property(_ => _.OrderId)
                .IsRequired();
            builder.Property(_ => _.ProductId)
                .IsRequired();
            builder.Property(_ => _.ProductCount)
                .IsRequired();
        }
    }
}
