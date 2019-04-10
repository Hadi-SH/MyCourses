namespace MyCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnrollmentV2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        TermCode = c.Int(nullable: false, identity: true),
                        StudentId = c.Byte(nullable: false),
                        CourseId = c.Byte(nullable: false),
                        MajorId = c.Byte(nullable: false),
                        Grade = c.Int(nullable: false),
                        EcrolledIndicator = c.Boolean(nullable: false),
                        PaymentIndicator = c.Boolean(nullable: false),
                        Courses_Id = c.Int(),
                        Majors_Id = c.Byte(),
                        Students_Id = c.Int(),
                    })
                .PrimaryKey(t => t.TermCode)
                .ForeignKey("dbo.Courses", t => t.Courses_Id)
                .ForeignKey("dbo.Majors", t => t.Majors_Id)
                .ForeignKey("dbo.Students", t => t.Students_Id)
                .Index(t => t.Courses_Id)
                .Index(t => t.Majors_Id)
                .Index(t => t.Students_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "Students_Id", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "Majors_Id", "dbo.Majors");
            DropForeignKey("dbo.Enrollments", "Courses_Id", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "Students_Id" });
            DropIndex("dbo.Enrollments", new[] { "Majors_Id" });
            DropIndex("dbo.Enrollments", new[] { "Courses_Id" });
            DropTable("dbo.Enrollments");
        }
    }
}
