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
    public partial class frmAddCourse : Form
    {
        public frmAddCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseLogic courseLogic = new CourseLogic();
            Cours cours = new Cours();
            cours.CourseName=textBox1.Text;
            courseLogic.AddCrs(cours);
        }
    }
}
