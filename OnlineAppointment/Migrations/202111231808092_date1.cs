namespace OnlineAppointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class date1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Date_of_Birth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Date_of_Birth", c => c.DateTime());
        }
    }
}
