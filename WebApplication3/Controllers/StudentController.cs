using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentRepo _repo;
        public StudentController()
        {
            _repo = new StudentRepo();
        }

        public List<Student> Get()
        {
            return _repo.GetStudentList();

        }
        public Student Get(int id)
        {

            return _repo.GetStudentBId(id);

        }

        public List<Student> Post(Student request)
        {
            var Student = _repo.AddStudent(request);

            return Student;
        }

        public Student Put(int id, Student request)
        {
            var Student = _repo.GetStudentBId(id);
            if (Student == null)
            {
                throw new Exception("Student Id is not exist");
            }
            var emp = _repo.UpdateStudent(id, request);

            return emp;
        }

        public List<Student> Delete(int id)
        {

            var Student = _repo.GetStudentBId(id);
            if (Student == null)
            {
                throw new Exception("Student Id is not exist");
            }
            _repo.DeleteStudent(id);
            return _repo.GetStudentList(); ;
        }

    }
}
