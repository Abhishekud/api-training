using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public interface IMarkRepo
    {
        Mark GetMarkBId(int id);
         
        List<Mark> GetMarkList();

        List<Mark> AddMark(Mark model);

        Mark UpdateMark(int id, Mark model);
 
        void DeleteMark(int id);
    }
}