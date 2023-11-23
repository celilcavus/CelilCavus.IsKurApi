namespace CelilCavus.IsKurApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bosses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        TCNo = c.String(),
                        CreateAtDate = c.DateTime(nullable: false),
                        UpdateAtDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        TCNo = c.String(),
                        CreateAtDate = c.DateTime(nullable: false),
                        UpdateAtDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Works",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position = c.Int(nullable: false),
                        DeadLine = c.DateTime(nullable: false),
                        CreateAtDate = c.DateTime(nullable: false),
                        UpdateAtDate = c.DateTime(nullable: false),
                        JobDescription = c.String(),
                        JobSkill = c.String(),
                        Profession = c.String(),
                        ProfessionExpreince = c.Byte(nullable: false),
                        Gender = c.Int(nullable: false),
                        Year = c.Byte(nullable: false),
                        disability = c.Boolean(nullable: false),
                        shift = c.Boolean(nullable: false),
                        Adress_Country = c.String(),
                        Adress_City = c.String(),
                        Adress_District = c.String(),
                        Adress_GeneralAdress = c.String(),
                        Contact_Name = c.String(),
                        Contact_Statu = c.Int(nullable: false),
                        Contact_PhoneNumber = c.String(),
                        Contact_Email = c.String(),
                        OrderDescription_Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDescription_MilitaryService = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Works");
            DropTable("dbo.Personels");
            DropTable("dbo.Bosses");
        }
    }
}
