using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class SubjectRepo : ISubjectRepo
    {
        private SubjectContext _SubjectContext;
        public SubjectRepo()
        {
            _SubjectContext = new SubjectContext();
        }

        public List<Subject> AddSubject(Subject model)
        {
            _SubjectContext.Subjects.Add(model);
            _SubjectContext.SaveChanges();
            return GetSubjectList();
        }

        public void DeleteSubject(int id)
        {
           
            var Subject = _SubjectContext.Subjects.FirstOrDefault(e => e.SubjectId == id);
            _SubjectContext.Subjects.Remove(Subject);
            _SubjectContext.SaveChanges();
        }

        public Subject GetSubjectBId(int id)
        {
            var Subject = _SubjectContext.Subjects.FirstOrDefault(e => e.SubjectId == id);
            return Subject;

        }

        public List<Subject> GetSubjectList()
        {
            return _SubjectContext.Subjects.ToList();
        }

        public Subject UpdateSubject(int id, Subject model)
        {
           var emp = _SubjectContext.Subjects.FirstOrDefault(e => e.SubjectId == id);

            emp.Name = model.Name; 

            _SubjectContext.Subjects.AddOrUpdate(emp);
            _SubjectContext.SaveChanges();
            return emp;

        }
    }
}