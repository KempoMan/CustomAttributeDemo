namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDobToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Dob", c => c.DateTime(nullable: false));

            Sql("UPDATE Customers set Dob = '1/20/1973' where Id = 1");
            Sql("UPDATE Customers set Dob = '5/25/1975' where Id = 2");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Dob");
        }
    }
}
