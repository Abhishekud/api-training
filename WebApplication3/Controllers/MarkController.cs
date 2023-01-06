using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApplication3.Models;
using WebApplication3.Models.Dto;

namespace WebApplication3.Controllers
{
    public class MarkController : AuthenticationController
    {
        private readonly IMarkRepo _repo;
        public MarkController()
        {
            _repo = new MarkRepo();
        }

        public List<Mark> Get()
        {
            return _repo.GetMarkList();

        } 

        public List<Mark> Post(Mark request)
        {
            var Mark = _repo.AddMark(request);

            return Mark;
        }

        public Mark Put(int id, Mark request)
        {
            var Mark = _repo.GetMarkId(id);
            if (Mark == null)
            {
                throw new Exception("Mark Id is not exist");
            }
            var emp = _repo.UpdateMark(id, request);

            return emp;
        }

        public List<Mark> Delete(int id)
        {

            var Mark = _repo.GetMarkId(id);
            if (Mark == null)
            {
                throw new Exception("Mark Id is not exist");
            }
            _repo.DeleteMark(id);
            return _repo.GetMarkList(); ;
        }

    }
}
