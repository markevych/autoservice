namespace Auto_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CarName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "CarName");
        }
    }
}
