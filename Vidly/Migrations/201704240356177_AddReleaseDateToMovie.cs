namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReleaseDateToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false, defaultValue: new DateTime(1901, 1, 1)));

        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
