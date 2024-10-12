using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(202410110950)]
    public class _202410110950_AddProductsTable : Migration
    {

        public override void Up()
        {
            Create.Table("Products")
          .WithColumn("Id").AsInt32().Identity().PrimaryKey()
           .WithColumn("Title").AsString().NotNullable()
           .WithColumn("Count").AsInt32().NotNullable()
           .WithColumn("Price").AsInt32().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("Products");
        }
    }
}
