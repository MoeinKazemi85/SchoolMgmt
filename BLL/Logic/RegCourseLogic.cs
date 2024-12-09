using BLL.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class RegCourseLogic
    {
        private readonly SchoolContext schoolContext = new SchoolContext();
        public void SetStudentByID(int studentID, int courseID, int semesterID)
        {
            CourseRegisteration courseRegisteration = new CourseRegisteration();
            courseRegisteration.StudentID = studentID;
            courseRegisteration.CourseID = courseID;
            courseRegisteration.SemestersID = semesterID;
            schoolContext.CourseRegisterations.Add(courseRegisteration);
            schoolContext.SaveChanges();
        }
        public void UpdateStudentByID(int rowIndex, int studentID, int courseID, int semesterID)
        {
            CourseRegistrationLogic courseRegistrationLogic = new CourseRegistrationLogic();
            var course = courseRegistrationLogic.GetAllCourseByID(studentID).ToList()[rowIndex - 1];
            courseRegistrationLogic.UpdateStudentByID(rowIndex,studentID,courseID,semesterID);


        }
        public void GetStudentByID(int studentID)
        {
            CourseRegisteration courseRegisteration = new CourseRegisteration();
            courseRegisteration.StudentID = studentID;
            schoolContext.CourseRegisterations.Add(courseRegisteration);
            schoolContext.SaveChanges();
        }
    }
}
