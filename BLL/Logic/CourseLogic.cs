using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Logic
{
    public class CourseLogic
    {
        private readonly SchoolContext schoolContext = new SchoolContext();
        public IEnumerable <Cours> GetAllCourse() 
        {
            return schoolContext.Courses.ToList();
        }
        public void AddCrs(Cours crs)
        {
            schoolContext.Courses.Add(crs);
            schoolContext.SaveChanges();
        }

        public void DelCrsById(int id)
        {
            Cours crs = schoolContext.Courses.Find(id);
            schoolContext.Courses.Remove(crs);
            schoolContext.SaveChanges();
        }
        public void UpdateCrs()
        {
            schoolContext.SaveChanges();
        }
        public Cours GetCrs(int CrsId)
        {
            var crs = schoolContext.Courses.Find(CrsId);
            return crs;
        }
    }
}
