namespace coding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class codingDB_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Admin", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Admin");
        }
    }
}
