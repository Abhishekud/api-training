using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public interface IStudentRepo
    {
        Student GetStudentBId(int id);

        List<Student> GetStudentList();

        List<Student> AddStudent(Student model);

        Student UpdateStudent(int id, Student model);
        void DeleteStudent(int id);
    }
}