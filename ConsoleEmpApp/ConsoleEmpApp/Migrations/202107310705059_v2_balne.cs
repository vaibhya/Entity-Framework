namespace ConsoleEmpApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2_balne : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Balance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Balance");
        }
    }
}
