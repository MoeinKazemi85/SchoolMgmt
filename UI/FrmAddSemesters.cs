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
    public partial class FrmAddSemesters : Form
    {
        public FrmAddSemesters()
        {
            InitializeComponent();
        }
        private static readonly SemesterLogic semesterLogic =new SemesterLogic();
        private void button1_Click(object sender, EventArgs e)
        {
            Semester newSemester = new Semester();
            newSemester.Semesters = textBox1.Text;
            semesterLogic.AddSemesters(newSemester);
        }
    }
}
