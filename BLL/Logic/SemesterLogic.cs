using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Logic
{
    public class SemesterLogic
    {
        //CRUD (Create,Update,Select,Delete)
        private readonly SchoolContext schoolContext = new SchoolContext();
        public IEnumerable<Semester> GetAllSemesters()
        {
            return schoolContext.Semesters.ToList();
        }
        public void AddSemesters(Semester Semester)
        {
            schoolContext.Semesters.Add(Semester);
            schoolContext.SaveChanges();
        }

        public void DelSemesterById(int id)
        {
            Semester semester = schoolContext.Semesters.Find(id);
            schoolContext.Semesters.Remove(semester);

            schoolContext.SaveChanges();
        }
        public void UpdateSemester()
        {
            schoolContext.SaveChanges();
        }
        public Semester GetSemester(int SemesterID)
        {
            var Semester = schoolContext.Semesters.Find(SemesterID);
            return Semester;
        }
    }
}
