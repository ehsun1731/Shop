using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(202410110943)]
    public class _202410110943_AddOrderTable : Migration
    {

        public override void Up()
        {
            Create.Table("Orders")
                  .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                  .WithColumn("CustomerId").AsInt32().NotNullable()
                  .WithColumn("TotalPrice").AsInt32().Nullable();
        }
        public override void Down()
        {
            Delete.Table("Orders");
        }
    }
}
