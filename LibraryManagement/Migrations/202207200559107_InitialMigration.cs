namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ISBN = c.String(),
                        Price = c.Single(nullable: false),
                        Publisher = c.String(),
                        AvailableCount = c.Int(nullable: false),
                        LibraryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Libraries", t => t.LibraryId, cascadeDelete: false)
                .Index(t => t.LibraryId);
            
            CreateTable(
                "dbo.Borrows",
                c => new
                    {
                        MemberId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        BorrowDate = c.DateTime(nullable: false),
                        SpecifiedReturnDate = c.DateTime(nullable: false),
                        ActualReturnDate = c.DateTime(),
                        Penalty = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.MemberId, t.BookId, t.BorrowDate })
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: false)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: false)
                .Index(t => t.MemberId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RegisterDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        Username = c.String(),
                        Password = c.String(),
                        LibraryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Libraries", t => t.LibraryId, cascadeDelete: false)
                .Index(t => t.LibraryId);
            
            CreateTable(
                "dbo.Libraries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        MemberCount = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "LibraryId", "dbo.Libraries");
            DropForeignKey("dbo.Books", "LibraryId", "dbo.Libraries");
            DropForeignKey("dbo.Borrows", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Borrows", "BookId", "dbo.Books");
            DropIndex("dbo.Members", new[] { "LibraryId" });
            DropIndex("dbo.Borrows", new[] { "BookId" });
            DropIndex("dbo.Borrows", new[] { "MemberId" });
            DropIndex("dbo.Books", new[] { "LibraryId" });
            DropTable("dbo.Libraries");
            DropTable("dbo.Members");
            DropTable("dbo.Borrows");
            DropTable("dbo.Books");
        }
    }
}
