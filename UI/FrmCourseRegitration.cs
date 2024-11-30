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
    public partial class FrmCourseRegitration : Form
    {
        int id;
        public FrmCourseRegitration(int id1)
        {
            InitializeComponent();
            this.id = id1;

        }
        private static readonly CourseRegistrationLogic courseRegistrationLogic = new CourseRegistrationLogic();
        private void FrmCourseRegitration_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= courseRegistrationLogic.GetAllCourseByID(this.id);
        }
    }
}
