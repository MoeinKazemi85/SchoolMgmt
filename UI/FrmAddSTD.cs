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
        int idStd;
        public FrmAddSTD(int id)
        {
            InitializeComponent();
            idStd = id;
        }
        public static readonly StudentLogic studentLogic = new StudentLogic();
        public delegate void OnUpdateDBHandler();
        public event OnUpdateDBHandler OnUpdateDB;
        private void button1_Click(object sender, EventArgs e)
        {
            if (frmStatus == false)
            {


                //create std
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
            else
            {
                Student newStudent = new Student();
                newStudent.Name = textBox1.Text;
                newStudent.Registered = false;
                if (panel1.Visible == false)
                {
                    studentLogic.UpdateStd(idStd, textBox1.Text);
                    if (OnUpdateDB != null) OnUpdateDB();

                }
                else
                {
             
                    RegCourseLogic regCourseLogic = new RegCourseLogic();
                    regCourseLogic.UpdateStudentByID(int.Parse(cmbRowIndex.Text), idStd, comboBox2.SelectedIndex + 1, comboBox1.SelectedIndex + 1);
                }
                MessageBox.Show("updated!!!");
               
                Close();

            }
        }
        bool frmStatus = false;
        bool noindexChange = true;
        private void FrmAddSTD_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            if (panel1.Visible==true)
            {
                textBox1.ReadOnly = true;
            }
            if (this.Text == "FrmAddSTD")
            {
                frmStatus = false;
            }
            else if (this.Text == "FrmEditSTD")
            {
                frmStatus = true;

            }
            //SemesterLogic semesterLogic = new SemesterLogic();
            //CourseLogic courseLogic = new CourseLogic();

            //var allSemesters = semesterLogic.GetAllSemesters();
            //var allCourses = courseLogic.GetAllCourse();

            //// Set the property to display in the ComboBox
            //comboBox1.DisplayMember = "Semesters";
            //comboBox2.DisplayMember = "CourseName";

            //// Combine the items into one list (optional)
            //var combinedList = new List<object>();
            //combinedList.AddRange(allSemesters);
            //var combinedList2 = new List<object>();
            //combinedList2.AddRange(allCourses);
            //// Add items to the ComboBox
            //comboBox1.Items.AddRange(combinedList.ToArray());
            //comboBox2.Items.AddRange(combinedList2.ToArray());

            if (frmStatus)//EDIT
            {
                Student student = new Student();
                student = studentLogic.GetStudents(this.idStd);
                textBox1.Text = student.Name;
                panel1.Visible = false;

                CourseRegistrationLogic courseRegistrationLogic = new CourseRegistrationLogic();
                int countRows = courseRegistrationLogic.GetAllCourseByID(this.idStd).ToList().Count;
                for (int i = 1; i <= countRows; i++)
                {
                    cmbRowIndex.Items.Add(i);
                }
   
                //cmbRowIndex.SelectedIndex = 0;
                noindexChange = false;

            }

        }

        private void cmbRowIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (noindexChange)
            {
                return;
            }
            else
            {  
               
                Cmb();
            }
            
        }
        private void Cmb() 
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
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.AddRange(combinedList.ToArray());
            comboBox2.Items.AddRange(combinedList2.ToArray());
            CourseRegistrationLogic courseRegistrationLogic = new CourseRegistrationLogic();
            comboBox1.Text = courseRegistrationLogic.GetAllCourseByID(this.idStd).ToList()[int.Parse(cmbRowIndex.Text) - 1].SemesterName;
            comboBox2.Text = courseRegistrationLogic.GetAllCourseByID(this.idStd).ToList()[int.Parse(cmbRowIndex.Text) - 1].CourseName;
        }
    }
}
