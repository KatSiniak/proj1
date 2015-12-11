namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addimage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Nameimage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Nameimage");
        }
    }
}
