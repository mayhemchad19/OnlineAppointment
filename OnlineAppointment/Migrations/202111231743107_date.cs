namespace OnlineAppointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class date : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Date_of_Birth", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Date_of_Birth");
        }
    }
}
