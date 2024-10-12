using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(202410110955)]
    public class _202410110955_AddOrderDetailsTable : Migration
    {

        public override void Up()
        {
            Create.Table("OrderDetails")
             .WithColumn("Id").AsInt32().Identity().PrimaryKey()
             .WithColumn("ProductId").AsInt32().NotNullable()
             .WithColumn("OrderId").AsInt32().NotNullable()
             .WithColumn("ProductCount").AsInt32().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("OrderDetails");
        }
    }
}
