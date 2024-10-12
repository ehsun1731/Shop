using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistence.EF.Customers
{
    public class CustomerEntityMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.ToTable("Customers");

            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id)
                .UseIdentityColumn();
            builder
                .Property(_ => _.Name)
                .IsRequired();
            builder
              .Property(_ => _.PhoneNumber)
              .IsRequired();

        }
    }
}
