namespace LTQLTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetablehoadon : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HoaDons", "KhachHang_id", "dbo.KhachHangs");
            DropIndex("dbo.HoaDons", new[] { "KhachHang_id" });
            AlterColumn("dbo.HoaDons", "KhachHang_id", c => c.Int(nullable: false));
            CreateIndex("dbo.HoaDons", "KhachHang_id");
            AddForeignKey("dbo.HoaDons", "KhachHang_id", "dbo.KhachHangs", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "KhachHang_id", "dbo.KhachHangs");
            DropIndex("dbo.HoaDons", new[] { "KhachHang_id" });
            AlterColumn("dbo.HoaDons", "KhachHang_id", c => c.Int());
            CreateIndex("dbo.HoaDons", "KhachHang_id");
            AddForeignKey("dbo.HoaDons", "KhachHang_id", "dbo.KhachHangs", "id");
        }
    }
}
