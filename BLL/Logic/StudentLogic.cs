using DAL.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
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
    }
}
