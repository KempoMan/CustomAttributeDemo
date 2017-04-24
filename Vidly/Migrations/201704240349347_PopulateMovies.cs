namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, GenreId) VALUES (1, 'Hangover', 1)");
            Sql("INSERT INTO Movies (Id, Name, GenreId) VALUES (2, 'Die Hard', 2)");
            Sql("INSERT INTO Movies (Id, Name, GenreId) VALUES (3, 'The Terminator', 3)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
