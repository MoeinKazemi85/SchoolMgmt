using DAL.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Logic
{
    public class StudentLogic
    {
        //CRUD (Create,Update,Select,Delete)
        private readonly SchoolContext schoolContext=new SchoolContext();
        public IEnumerable<Student> GetAllStd()
        {
            return schoolContext.Students.ToList();
        }
        public void AddStd(Student student)
        {
            schoolContext.Students.Add(student);
            schoolContext.SaveChanges();
        }

        public void DelStdById(Student std)
        {
            schoolContext.Students.Remove(std);
            schoolContext.SaveChanges();
        }
        public void UpdateStd()
        {
            schoolContext.SaveChanges();
        }
        public Student GetStudents(int studentID) 
        { 
            var std=schoolContext.Students.Find(studentID);
            return std;
        }
    }
}
