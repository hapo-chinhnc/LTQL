namespace LTQLTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaoBang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tien = c.Int(nullable: false),
                        Id_KhachHang = c.Int(nullable: false),
                        KhachHang_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.KhachHangs", t => t.KhachHang_id)
                .Index(t => t.KhachHang_id);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 30),
                        phone = c.String(nullable: false),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "KhachHang_id", "dbo.KhachHangs");
            DropIndex("dbo.HoaDons", new[] { "KhachHang_id" });
            DropTable("dbo.KhachHangs");
            DropTable("dbo.HoaDons");
        }
    }
}
