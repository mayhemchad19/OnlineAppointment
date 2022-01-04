namespace OnlineAppointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reason3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Reason", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "Reason");
        }
    }
}
