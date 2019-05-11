namespace PortalPizza.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dodanie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Imie", c => c.String());
            AddColumn("dbo.AspNetUsers", "Nazwisko", c => c.String());
            AddColumn("dbo.AspNetUsers", "Adres", c => c.String());
            AddColumn("dbo.AspNetUsers", "Telefon", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Telefon");
            DropColumn("dbo.AspNetUsers", "Adres");
            DropColumn("dbo.AspNetUsers", "Nazwisko");
            DropColumn("dbo.AspNetUsers", "Imie");
        }
    }
}
