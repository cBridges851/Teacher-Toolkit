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
        bool individualProgressNewGroupCreated;
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

            try
            {
                //CB 2020-01-24 Writing the name and the level to the CSV file
                TextWriter tw = new StreamWriter(@"Documents");
                tw.WriteLine(studentName + ", " + currentLevel);
                tw.Close();

                //CB 2020-01-24 Reading the lines in the CSV file
                TextReader tr = new StreamReader(@"Documents");
                string ln;
                while ((ln = tr.ReadLine()) != null)
                {
                    textBoxOutput.Text += ln + "\r\n";
                }
                tr.Close();
            }

            catch (FileNotFoundException)
            {
                labelError.Text = "FILE NOT FOUND";
            }
        }

        private void NewGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGroup newGroup = new NewGroup();
            newGroup.ShowDialog();
            newGroup.Close();

            individualProgressNewGroupCreated = NewGroup.newGroupCreated;

            if (individualProgressNewGroupCreated == false)
            { 
                textBoxOutput.Text = textBoxOutput.Text;
            }

            else
            {
                textBoxOutput.Text = "";
            }

            
        }
    }
}
