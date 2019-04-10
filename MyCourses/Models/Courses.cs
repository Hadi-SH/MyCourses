using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCourses.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public char CourseName { get; set; }
        public int Credits { get; set; }

        public Departments Departments { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Departments
    {
        public int Id { get; set; }
        public char DepartmentName { get; set; }
    }
}