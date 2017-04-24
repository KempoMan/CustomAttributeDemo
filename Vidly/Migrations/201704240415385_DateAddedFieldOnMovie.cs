namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateAddedFieldOnMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false, defaultValue: new DateTime(2000, 2, 2)));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "DateAdded");
        }
    }
}
