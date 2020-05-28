namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class records2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SysUser", "Email", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SysUser", "Email");
        }
    }
}
