namespace Application_Echange_Livre_ASP_Net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificationAbonnement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abonnements", "IsAbo", c => c.Boolean(nullable: false));
            DropColumn("dbo.Abonnements", "TypeOfAbo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abonnements", "TypeOfAbo", c => c.Int(nullable: false));
            DropColumn("dbo.Abonnements", "IsAbo");
        }
    }
}
