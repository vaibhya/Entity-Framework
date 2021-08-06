namespace ConsoleEmpApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4_Type_update_cus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Type");
        }
    }
}
