namespace PlusAndComment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DDD : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FilterEntity", "Unit", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FilterEntity", "Unit", c => c.Double(nullable: false));
        }
    }
}
