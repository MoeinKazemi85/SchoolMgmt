﻿using BLL.Logic;
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
    public partial class FrmSelectORM : Form
    {
        public FrmSelectORM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) 
            {
                //EF
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //ADO
            }
            new FrmMain().ShowDialog();
        }
    }
}
