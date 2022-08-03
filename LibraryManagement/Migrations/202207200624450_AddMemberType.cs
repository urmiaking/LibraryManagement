namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "MemberType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "MemberType");
        }
    }
}
