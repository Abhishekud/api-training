using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Student 
    {
        [Key]
        public int StudentId { get; set; }

        public string Name { get; set; }

        //[Display(Name = "Subject")]
        public virtual int SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subjects { get; set; } 

        [Required]
        public int Marks { get; set; }
    }
}