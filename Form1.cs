﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Test myForm = new Test();
            this.Hide();
            myForm.Show();
            
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ExampleProgram.ExampleProgram myForm2 = new ExampleProgram.ExampleProgram();
            myForm2.Show();
        }
    }
}
