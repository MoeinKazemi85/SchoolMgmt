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
       public static readonly StudentLogic studentLogic=new StudentLogic();
        private void button1_Click(object sender, EventArgs e)
        {
            //crete std
            Student newStudent=new Student(); 
            newStudent.Name=textBox1.Text;
            newStudent.Registered=false;
            studentLogic.AddStd(newStudent);
            studentLogic.registeration(newStudent);
        }
        
    }
}
