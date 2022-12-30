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
        public Student GetStudentByEmail(string email)
        {
            var Student = _StudentContext.Students.FirstOrDefault(e => e.Email == email);
            return Student;

        }

        public List<Student> GetStudentList()
        {
            return _StudentContext.Students.ToList();
        }

        public Student UpdateStudent(int id, Student model)
        {
           var Student = _StudentContext.Students.FirstOrDefault(e => e.StudentId == id);

            Student.FirstName = model.FirstName;
            Student.LastName = model.LastName;
            Student.Email = model.Email;
            Student.MobileNumber = model.MobileNumber;

            _StudentContext.Students.AddOrUpdate(Student);
            _StudentContext.SaveChanges();
            return Student;

        }
        public Student UpdateStudent(string email, Student model)
        {
            var Student = _StudentContext.Students.FirstOrDefault(e => e.Email == email);

            Student.FirstName = model.FirstName;
            Student.LastName = model.LastName;
            Student.Email = model.Email;
            Student.MobileNumber = model.MobileNumber;

            _StudentContext.Students.AddOrUpdate(Student);
            _StudentContext.SaveChanges();
            return Student;

        }
    }
}