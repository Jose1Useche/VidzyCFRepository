namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (3, 'Horror')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (4, 'Thriller')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (5, 'Family')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (6, 'Romance')");
        }
        
        public override void Down()
        {
            Sql("DELETE dbo.Genres WHERE Id IN (1,2,3,4,5,6)");
        }
    }
}
