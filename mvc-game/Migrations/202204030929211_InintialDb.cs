namespace mvc_game.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InintialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TotalGamePlayed = c.Int(nullable: false),
                        TotalScores = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
