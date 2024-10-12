using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(202410101534)]
    public class _202410101534_AddCustomerTable : Migration
    {

        public override void Up()
        {

            Create.Table("Customers")
             .WithColumn("Id").AsInt32().Identity().PrimaryKey()
             .WithColumn("Name").AsString().NotNullable()
             .WithColumn("PhoneNumber").AsString().NotNullable()
             ;
        }
        public override void Down()
        {
            Delete.Table("Customers");
        }
    }
}
