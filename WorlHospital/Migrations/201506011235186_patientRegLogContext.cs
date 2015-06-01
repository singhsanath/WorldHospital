namespace WorlHospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class patientRegLogContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientsAuths",
                c => new
                    {
                        PatientID = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PatientID);
            
            CreateTable(
                "dbo.PatientRegistrations",
                c => new
                    {
                        PID = c.String(nullable: false, maxLength: 128),
                        PName = c.String(nullable: false),
                        PFName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        PAge = c.String(nullable: false),
                        DOB = c.String(nullable: false),
                        BGroup = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        State = c.String(nullable: false),
                        MNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatientRegistrations");
            DropTable("dbo.PatientsAuths");
        }
    }
}
