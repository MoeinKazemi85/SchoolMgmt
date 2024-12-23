﻿using DAL.Domain;
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
        private  SchoolContext schoolContext=new SchoolContext();
        public List<Student> GetAllStd()
        {
            return schoolContext.Students.ToList();
        }
        public void AddStd(Student student)
        {
            if (GetAllStd().Where(c=>c.Name==student.Name).Any())
            {
                throw new Exception("tekrari ast");
            }
            schoolContext.Students.Add(student);
            schoolContext.SaveChanges();
        }

        public void DelStdById(int id)
        {
            Student student = schoolContext.Students.Find(id);
            schoolContext.Students.Remove(student);
            
            schoolContext.SaveChanges();
        }
        public void UpdateStd(int id,string name)
        {
            var student = schoolContext.Students.Where(c => c.StudentsID == id).Single();
            student.Name = name;
            schoolContext.SaveChanges();
        }
        public Student GetStudents(int studentID) 
        { 
            var std=schoolContext.Students.Find(studentID);
            return std;
        }
        public void registeration(Student student) 
        {
            //check if student has selected unit
            int courseCount=schoolContext.CourseRegisterations.Where(c=>c.StudentID==student.StudentsID).Count();
            //check if student has made Payment
            int paymentCont=schoolContext.FeePayments.Where(f=>f.StudentID==student.StudentsID).Count();
            //if both are true registeration =true or 1
            if (courseCount > 0 && paymentCont > 0)
            {
                student.Registered=true;
                schoolContext.SaveChanges();
            }      
        }
    }
}
