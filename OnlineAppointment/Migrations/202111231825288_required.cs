namespace OnlineAppointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "FirstName", c => c.String(maxLength: 20));
            AlterColumn("dbo.Users", "Username", c => c.String(maxLength: 10));
        }
    }
}
