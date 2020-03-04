using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TimerSeconds_Tick(object sender, EventArgs e)
        {
            counter++;
            textBoxSecondsOutput.Text = counter.ToString();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            timerSeconds.Enabled = true;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            timerSeconds.Enabled = false;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            counter = 0;
        }
    }
}
