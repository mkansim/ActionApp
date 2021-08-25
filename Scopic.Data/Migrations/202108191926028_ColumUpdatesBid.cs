namespace Scopic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumUpdatesBid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bids", "BidAccepted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bids", "BidAccepted");
        }
    }
}
