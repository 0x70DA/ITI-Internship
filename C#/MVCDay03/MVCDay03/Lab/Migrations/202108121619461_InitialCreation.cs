namespace Lab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DeptID = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                    })
                .PrimaryKey(t => t.DeptID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(),
                        Salary = c.Int(),
                        DeptID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.DeptID)
                .Index(t => t.DeptID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DeptID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DeptID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
