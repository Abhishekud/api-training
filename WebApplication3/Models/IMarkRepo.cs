using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models.Dto;

namespace WebApplication3.Models
{
    public interface IMarkRepo
    {
        Mark GetMarkId(int id);


        List<Mark> GetMarkList();

        List<Mark> AddMark(Mark model);

        Mark UpdateMark(int id, Mark model);
 
        void DeleteMark(int id);
    }
}