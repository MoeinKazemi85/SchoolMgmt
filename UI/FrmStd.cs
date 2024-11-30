using BLL.Logic;
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
    }
}
