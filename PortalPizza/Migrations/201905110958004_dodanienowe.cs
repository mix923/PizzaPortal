namespace PortalPizza.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodanienowe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistoriaZamowienias",
                c => new
                    {
                        HistoriaZamowieniaId = c.Int(nullable: false, identity: true),
                        UserID = c.String(),
                        Cena = c.Int(nullable: false),
                        Pizza = c.String(),
                        Data = c.String(),
                    })
                .PrimaryKey(t => t.HistoriaZamowieniaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HistoriaZamowienias");
        }
    }
}
