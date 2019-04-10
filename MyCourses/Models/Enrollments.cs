using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyCourses.Models
{
    public class Enrollments
    {
        [Key]
        public int TermCode { get; set; }

        public Students Students { get; set; }
        public byte StudentId { get; set; }

        public Courses Courses { get; set; }
        public byte CourseId { get; set; }

        public Majors Majors { get; set; }
        public byte MajorId { get; set; }

        public int Grade { get; set; }
        public bool EcrolledIndicator { get; set; }
        public bool PaymentIndicator { get; set; }

    }
}