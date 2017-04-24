namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberInStockToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false, defaultValue:5));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberInStock");
        }
    }
}
