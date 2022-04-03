namespace mvc_game.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Country", c => c.String());
            AddColumn("dbo.Players", "GameType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "GameType");
            DropColumn("dbo.Players", "Country");
        }
    }
}
