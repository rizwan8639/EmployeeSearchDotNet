namespace EmpSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpCode = c.String(),
                        EmpName = c.String(),
                        Dob = c.DateTime(nullable: false),
                        Department = c.String(),
                        ReportTo = c.String(),
                        ContactNo = c.Long(nullable: false),
                        Resigned = c.String(),
                        ResignedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
