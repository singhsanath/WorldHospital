namespace WorlHospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class patientRegLogContext1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        StateID = c.String(nullable: false, maxLength: 128),
                        state = c.String(nullable: false),
                        country = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StateID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Locations");
        }
    }
}
