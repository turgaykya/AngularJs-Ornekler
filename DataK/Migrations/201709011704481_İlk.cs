namespace DataK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class İlk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ürünler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 50),
                        KategoriId = c.Int(nullable: false),
                        ŞehirId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoris", t => t.KategoriId)
                .ForeignKey("dbo.Şehir", t => t.ŞehirId)
                .Index(t => t.KategoriId)
                .Index(t => t.ŞehirId);
            
            CreateTable(
                "dbo.Şehir",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ürünler", "ŞehirId", "dbo.Şehir");
            DropForeignKey("dbo.Ürünler", "KategoriId", "dbo.Kategoris");
            DropIndex("dbo.Ürünler", new[] { "ŞehirId" });
            DropIndex("dbo.Ürünler", new[] { "KategoriId" });
            DropTable("dbo.Şehir");
            DropTable("dbo.Ürünler");
            DropTable("dbo.Kategoris");
        }
    }
}
