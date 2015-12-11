namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fdhfhsd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Opis", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Opis");
        }
    }
}
