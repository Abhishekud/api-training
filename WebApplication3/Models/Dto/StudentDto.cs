using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.Dto
{
    public class StudentDto
    {
        public int StudentId { get; set; }
        public List<SubjectDto> Subjects { get; set; }
    }
    public class SubjectDto
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int Mark { get; set; }
    }
}