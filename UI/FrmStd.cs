﻿using BLL.Logic;
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
    public partial class FrmStd : Form
    {
        public FrmStd()
        {
            InitializeComponent();
        }
        private readonly static StudentLogic studentLogic = new StudentLogic();
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddSTD frmAddSTD = new FrmAddSTD();
            frmAddSTD.ShowDialog();
        }

        private void FrmStd_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= studentLogic.GetAllStd();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SchoolContext schoolContext = new SchoolContext();
            if (e.ColumnIndex == 0) //edit
            {

            }
            else if (e.ColumnIndex == 1)//remove
            {
                Student std=new Student();
                int id = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                std = schoolContext.Students.Where(c => c.StudentsID == id).First();
                studentLogic.DelStdById(std);
                dataGridView1.DataSource= null;
                dataGridView1.DataSource= studentLogic.GetAllStd();
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
            
        }
    }
}
