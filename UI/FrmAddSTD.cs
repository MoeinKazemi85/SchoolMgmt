using BLL.Logic;
using DAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmAddSTD : Form
    {
        public FrmAddSTD()
        {
            InitializeComponent();
        }
        public static readonly StudentLogic studentLogic = new StudentLogic();
        public delegate void OnUpdateDBHandler();
        public event OnUpdateDBHandler OnUpdateDB;
        private void button1_Click(object sender, EventArgs e)
        {
            //crete std
            try
            {
                Student newStudent = new Student();
                newStudent.Name = textBox1.Text;
                newStudent.Registered = false;
                studentLogic.AddStd(newStudent);
                studentLogic.registeration(newStudent);
                if (OnUpdateDB != null) OnUpdateDB();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmAddSTD_Load(object sender, EventArgs e)
        {
            SemesterLogic semesterLogic = new SemesterLogic();
            CourseLogic courseLogic = new CourseLogic();

            var allSemesters = semesterLogic.GetAllSemesters();
            var allCourses = courseLogic.GetAllCourse();

            // Set the property to display in the ComboBox
            comboBox1.DisplayMember = "Semesters";
            comboBox2.DisplayMember = "CourseName";

            // Combine the items into one list (optional)
            var combinedList = new List<object>();
            combinedList.AddRange(allSemesters);
            var combinedList2 = new List<object>();
            combinedList2.AddRange(allCourses);
            // Add items to the ComboBox
            comboBox1.Items.AddRange(combinedList.ToArray());
            comboBox2.Items.AddRange(combinedList2.ToArray());



        }
    }
}
