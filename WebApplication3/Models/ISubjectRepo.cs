using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public interface ISubjectRepo
    {
        Subject GetSubjectBId(int id);

        List<Subject> GetSubjectList();

        List<Subject> AddSubject(Subject model);

        Subject UpdateSubject(int id, Subject model);
        void DeleteSubject(int id);
    }
}