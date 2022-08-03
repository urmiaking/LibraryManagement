namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateTime : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Borrows");
            AlterColumn("dbo.Borrows", "BorrowDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddPrimaryKey("dbo.Borrows", new[] { "MemberId", "BookId", "BorrowDate" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Borrows");
            AlterColumn("dbo.Borrows", "BorrowDate", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.Borrows", new[] { "MemberId", "BookId", "BorrowDate" });
        }
    }
}
