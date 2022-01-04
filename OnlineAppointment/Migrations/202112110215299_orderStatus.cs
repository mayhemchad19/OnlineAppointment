namespace OnlineAppointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderStatus", c => c.Boolean());
            AddColumn("dbo.Sales", "SaleStatus", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sales", "SaleStatus");
            DropColumn("dbo.Orders", "OrderStatus");
        }
    }
}
