namespace OnlineAppointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reason2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Appointments", "Reason");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "Reason", c => c.String());
        }
    }
}
