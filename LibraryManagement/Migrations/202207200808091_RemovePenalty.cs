namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePenalty : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Borrows", "Penalty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Borrows", "Penalty", c => c.Single(nullable: false));
        }
    }
}
