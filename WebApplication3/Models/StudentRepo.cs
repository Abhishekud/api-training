using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class StudentRepo : IStudentRepo
    {
        private MyContext _StudentContext;
        public StudentRepo()
        {
            _StudentContext = new MyContext();
        }

        public List<Student> AddStudent(Student model)
        {
            _StudentContext.Students.Add(model);
            _StudentContext.SaveChanges();
            return GetStudentList();
        }

        public void DeleteStudent(int id)
        {
           
            var Student = _StudentContext.Students.FirstOrDefault(e => e.StudentId == id);
            _StudentContext.Students.Remove(Student);
            _StudentContext.SaveChanges();
        }

        public Student GetStudentBId(int id)
        {
            var Student = _StudentContext.Students.FirstOrDefault(e => e.StudentId == id);
            return Student;

        }

        public List<Student> GetStudentList()
        {
            return _StudentContext.Students.ToList();
        }

        public Student UpdateStudent(int id, Student model)
        {
           var emp = _StudentContext.Students.FirstOrDefault(e => e.StudentId == id);

            emp.Name = model.Name;
            emp.Marks = model.Marks;

            _StudentContext.Students.AddOrUpdate(emp);
            _StudentContext.SaveChanges();
            return emp;

        }
    }
}