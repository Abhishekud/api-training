using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class MarkRepo : IMarkRepo
    {
        private MyContext _MarkContext;
        public MarkRepo()
        {
            _MarkContext = new MyContext();
        }

        public List<Mark> AddMark(Mark model)
        {
            _MarkContext.Marks.Add(model);
            _MarkContext.SaveChanges();
            return GetMarkList();
        }

        public void DeleteMark(int id)
        {
           
            var Mark = _MarkContext.Marks.FirstOrDefault(e => e.Id == id);
            _MarkContext.Marks.Remove(Mark);
            _MarkContext.SaveChanges();
        }

        public Mark GetStudentDto(int id)
        {
            var Mark = _MarkContext.Marks.FirstOrDefault(e => e.Id == id);
            return Mark;

        }
        //public Mark GetMarkBStudentId(int id)
        //{
        //    var Mark = _MarkContext.Students..FirstOrDefault(e => e.Id == id);
        //    return Mark;

        //}

        public List<Mark> GetMarkList()
        {
            return _MarkContext.Marks.ToList();
        }

        public Mark UpdateMark(int id, Mark model)
        {
           var Mark = _MarkContext.Marks.FirstOrDefault(e => e.Id == id);

            Mark.Marks = model.Marks; 

            _MarkContext.Marks.AddOrUpdate(Mark);
            _MarkContext.SaveChanges();
            return Mark;

        } 
    }
}