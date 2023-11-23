namespace CelilCavus.IsKurApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Works", "Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Works", new[] { "Id" });
        }
    }
}
