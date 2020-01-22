using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarAlternate
{
    public partial class IndividualProgress : Form
    {
        public IndividualProgress()
        {
            InitializeComponent();
        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            string studentName = textBoxName.Text;
            string currentLevel = domainUpDownLevel.Text;

            textBoxOutput.Text = studentName + currentLevel;
        }
    }
}
