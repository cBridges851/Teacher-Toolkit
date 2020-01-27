using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            //CB 2020-01-24 Storing the text that are in the controls in variables
            string studentName = textBoxName.Text;
            string currentLevel = domainUpDownLevel.Text;

            textBoxName.Text = "";

            //CB 2020-01-24 Writing the name and the level to the CSV file
            TextWriter tw = new StreamWriter(@"D:\Coding Club\Teacher Toolkit\Progress Bar\currentList.csv");
            tw.WriteLine(studentName + ", " + currentLevel);
            tw.Close();

            //CB 2020-01-24 Reading the lines in the CSV file
            TextReader tr = new StreamReader(@"D:\Coding Club\Teacher Toolkit\Progress Bar\currentList.csv");
            string ln;
            while ((ln = tr.ReadLine()) != null)
            {
                textBoxOutput.Text += ln + "\r\n";
            }
            tr.Close();
        }
    }
}
