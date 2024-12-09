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
    public partial class FrmRegisterCourse : Form
    {
        int idStd;
        private static readonly StudentLogic StdLogic = new StudentLogic();
        public FrmRegisterCourse(int id)
        {
            InitializeComponent();
            this.idStd = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                RegCourseLogic regCourseLogic = new RegCourseLogic();
                regCourseLogic.SetStudentByID(idStd, comboBox1.SelectedIndex+1, comboBox2.SelectedIndex+1);
            }
            else MessageBox.Show("Please Choose items");
        }
        private void FrmRegisterCourse_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            student = StdLogic.GetStudents(idStd);
            textBox1.Text = student.Name;
            Cours cours = new Cours();
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
