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
    public partial class FrmCourse : Form
    {
        public FrmCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddCourse frmAddCourse = new frmAddCourse();
            frmAddCourse.ShowDialog();
        }

          private static readonly CourseLogic courseLogic = new CourseLogic();
        private void FrmCourse_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=courseLogic.GetAllCourse();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SchoolContext schoolContext = new SchoolContext();
            if (e.ColumnIndex == 0) //edit
            {

            }
            else if (e.ColumnIndex == 1)//remove
            {

                int id = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                courseLogic.DelCrsById(id);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = courseLogic.GetAllCourse();
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }
    }
}
