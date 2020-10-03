namespace LTQLTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_HoaDon : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.HoaDons", "Id_KhachHang");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HoaDons", "Id_KhachHang", c => c.Int(nullable: false));
        }
    }
}
