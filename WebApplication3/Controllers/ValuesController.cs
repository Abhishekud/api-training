using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Filter;
using WebApplication3.Models;
using WebApplication3.Models.Dto;

namespace WebApplication3.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IStudentRepo _repo;
        public ValuesController()
        {
            _repo = new StudentRepo();
        }
        [AthorizationFilter]
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [AthorizationFilter]
        public StudentDto Get(int id)
        {

            return _repo.GetStudentDto(id);

        }

        // POST api/values
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
