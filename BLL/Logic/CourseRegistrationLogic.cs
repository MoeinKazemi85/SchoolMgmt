using DAL.Domain;
using DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Logic
{
    public class CourseRegistrationLogic
    {
        private readonly SchoolContext schoolContext = new SchoolContext();
        public IEnumerable<CourseRegisterationVM> GetAllCourseByID(int id)
        {
            return schoolContext.CourseRegisterations.Where(c=>c.StudentID==id)
                .Select(
                c=>new CourseRegisterationVM
                {
                    CourseRegisterationID = c.CourseRegisterationID,
                    CourseName=c.Cours.CourseName,
                    SemesterName=c.Semester.Semesters,
                    STDName=c.Student.Name

                }
                )
                .ToList();
        }
        public void UpdateStudentByID(int rowIndex, int studentID, int courseID, int semesterID)
        {
           
            var course = schoolContext.CourseRegisterations.Where(s => s.SemestersID == studentID).ToList()[rowIndex-1];
            course.StudentID = studentID;
            course.CourseID = courseID;
            course.SemestersID = semesterID;
            schoolContext.SaveChanges();


        }
    }
}
