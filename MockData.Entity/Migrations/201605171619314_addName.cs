namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Name");
        }
    }
}
