namespace Scopic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumUpdates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Sold", c => c.Boolean(nullable: false));
            AddColumn("dbo.Items", "ListPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "ListPrice");
            DropColumn("dbo.Items", "Sold");
        }
    }
}
