namespace LTQLTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_table_khachHang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachHangs", "email", c => c.String(nullable: false));
            AddColumn("dbo.KhachHangs", "password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHangs", "password");
            DropColumn("dbo.KhachHangs", "email");
        }
    }
}
