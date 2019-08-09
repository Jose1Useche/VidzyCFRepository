namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateVideosTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VideoGenres", "Video_Id", "dbo.Videos");
            DropForeignKey("dbo.VideoGenres", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.VideoGenres", new[] { "Video_Id" });
            DropIndex("dbo.VideoGenres", new[] { "Genre_Id" });
            AddColumn("dbo.Videos", "Genres_Id", c => c.Byte());
            CreateIndex("dbo.Videos", "Genres_Id");
            AddForeignKey("dbo.Videos", "Genres_Id", "dbo.Genres", "Id");
            DropTable("dbo.VideoGenres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VideoGenres",
                c => new
                    {
                        Video_Id = c.Int(nullable: false),
                        Genre_Id = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.Video_Id, t.Genre_Id });
            
            DropForeignKey("dbo.Videos", "Genres_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genres_Id" });
            DropColumn("dbo.Videos", "Genres_Id");
            CreateIndex("dbo.VideoGenres", "Genre_Id");
            CreateIndex("dbo.VideoGenres", "Video_Id");
            AddForeignKey("dbo.VideoGenres", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.VideoGenres", "Video_Id", "dbo.Videos", "Id", cascadeDelete: true);
        }
    }
}
