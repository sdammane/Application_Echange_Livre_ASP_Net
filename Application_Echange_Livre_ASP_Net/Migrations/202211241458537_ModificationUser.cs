namespace Application_Echange_Livre_ASP_Net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificationUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_Id" });
            CreateTable(
                "dbo.BookExchanges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        BookId = c.Int(nullable: false),
                        OldOwnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.OldOwnerId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.OldOwnerId);
            
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Book_Id = c.Int(nullable: false),
                        Author_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_Id, t.Author_Id })
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .ForeignKey("dbo.Authors", t => t.Author_Id, cascadeDelete: true)
                .Index(t => t.Book_Id)
                .Index(t => t.Author_Id);
            
            AddColumn("dbo.Users", "IsAdmin", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Photo", c => c.String());
            AddColumn("dbo.Users", "MyProperty", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "TotalPoints", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Photo", c => c.String());
            DropColumn("dbo.Users", "TypeOfUser");
            DropColumn("dbo.Books", "EditionDate");
            DropColumn("dbo.Books", "PointValue");
            DropColumn("dbo.Books", "Collection");
            DropColumn("dbo.Books", "Editeur");
            DropColumn("dbo.Books", "SubTitle");
            DropColumn("dbo.Books", "Description");
            DropColumn("dbo.Books", "Author_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Author_Id", c => c.Int());
            AddColumn("dbo.Books", "Description", c => c.String());
            AddColumn("dbo.Books", "SubTitle", c => c.String());
            AddColumn("dbo.Books", "Editeur", c => c.String());
            AddColumn("dbo.Books", "Collection", c => c.String());
            AddColumn("dbo.Books", "PointValue", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "EditionDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "TypeOfUser", c => c.Int(nullable: false));
            DropForeignKey("dbo.BookExchanges", "OldOwnerId", "dbo.Users");
            DropForeignKey("dbo.BookExchanges", "BookId", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.BookAuthors", "Book_Id", "dbo.Books");
            DropIndex("dbo.BookAuthors", new[] { "Author_Id" });
            DropIndex("dbo.BookAuthors", new[] { "Book_Id" });
            DropIndex("dbo.BookExchanges", new[] { "OldOwnerId" });
            DropIndex("dbo.BookExchanges", new[] { "BookId" });
            DropColumn("dbo.Books", "Photo");
            DropColumn("dbo.Users", "TotalPoints");
            DropColumn("dbo.Users", "MyProperty");
            DropColumn("dbo.Users", "Photo");
            DropColumn("dbo.Users", "IsAdmin");
            DropTable("dbo.BookAuthors");
            DropTable("dbo.BookExchanges");
            CreateIndex("dbo.Books", "Author_Id");
            AddForeignKey("dbo.Books", "Author_Id", "dbo.Authors", "Id");
        }
    }
}
