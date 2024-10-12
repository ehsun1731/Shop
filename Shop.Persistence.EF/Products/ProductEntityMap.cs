using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistence.EF.Products
{
    public class ProductEntityMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id)
                .UseIdentityColumn();
            builder
                .Property(_ => _.Count)
                .IsRequired();
            builder
                .Property(_ => _.Price)
                .IsRequired()
                ;
            builder.Property(_ => _.Title)
                .IsRequired();
        }
    }
}
