namespace Application_Echange_Livre_ASP_Net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abonnements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalPoints = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        TypeOfAbo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Adresse = c.String(nullable: false, maxLength: 50),
                        TypeOfUser = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ISBN = c.String(nullable: false, maxLength: 13),
                        Price = c.Double(nullable: false),
                        EditionDate = c.DateTime(nullable: false),
                        PointValue = c.Int(nullable: false),
                        BookState = c.Int(nullable: false),
                        Collection = c.String(),
                        Editeur = c.String(),
                        SubTitle = c.String(),
                        Description = c.String(),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WishLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.CategorieBooks",
                c => new
                    {
                        Categorie_Id = c.Int(nullable: false),
                        Book_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Categorie_Id, t.Book_Id })
                .ForeignKey("dbo.Categories", t => t.Categorie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .Index(t => t.Categorie_Id)
                .Index(t => t.Book_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WishLists", "UserId", "dbo.Users");
            DropForeignKey("dbo.WishLists", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.CategorieBooks", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.CategorieBooks", "Categorie_Id", "dbo.Categories");
            DropForeignKey("dbo.Abonnements", "UserId", "dbo.Users");
            DropIndex("dbo.CategorieBooks", new[] { "Book_Id" });
            DropIndex("dbo.CategorieBooks", new[] { "Categorie_Id" });
            DropIndex("dbo.WishLists", new[] { "BookId" });
            DropIndex("dbo.WishLists", new[] { "UserId" });
            DropIndex("dbo.Books", new[] { "Author_Id" });
            DropIndex("dbo.Abonnements", new[] { "UserId" });
            DropTable("dbo.CategorieBooks");
            DropTable("dbo.WishLists");
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
            DropTable("dbo.Users");
            DropTable("dbo.Abonnements");
        }
    }
}
