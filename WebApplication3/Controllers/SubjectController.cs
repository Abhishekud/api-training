using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class SubjectController : ApiController
    {
        private readonly ISubjectRepo _repo;
        public SubjectController()
        {
            _repo = new SubjectRepo();
        }

        public List<Subject> Get()
        {
            return _repo.GetSubjectList();

        }
        public Subject Get(int id)
        {

            return _repo.GetSubjectBId(id);

        }

        public List<Subject> Post(Subject request)
        {
            var Subject = _repo.AddSubject(request);

            return Subject;
        }

        public Subject Put(int id, Subject request)
        {
            var Subject = _repo.GetSubjectBId(id);
            if (Subject == null)
            {
                throw new Exception("Subject Id is not exist");
            }
            var emp = _repo.UpdateSubject(id, request);

            return emp;
        }

        public List<Subject> Delete(int id)
        {

            var Subject = _repo.GetSubjectBId(id);
            if (Subject == null)
            {
                throw new Exception("Subject Id is not exist");
            }
            _repo.DeleteSubject(id);
            return _repo.GetSubjectList(); ;
        }

    }
}
