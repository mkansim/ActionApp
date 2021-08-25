namespace Scopic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bids", "BidderUserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bids", "BidderUserId");
        }
    }
}
