using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyCourses.Models
{
    public class Students
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string LastName { get; set; }

        public AdmissionTerms AdmissionTerms { get; set; }
        public char AdmissionTermCode { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Majors Majors { get; set; }
        public byte MajorId { get; set; }
    }

    public class Majors
    {
        public byte Id { get; set; }
        public string MajorName { get; set; }
    }

    public class AdmissionTerms
    {
        public int Id { get; set; }
        public char AdmissionTermsCode { get; set; }
    }
}