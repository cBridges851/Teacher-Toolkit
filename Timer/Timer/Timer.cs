using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Timer : Form
    {
        int hours;
        int minutes;
        int seconds;

        int minuteCounter = 0;
        public Timer()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            hours = Convert.ToInt32(numericUpDownHours.Text);
            minutes = Convert.ToInt32(numericUpDownMinutes.Text);
            seconds = Convert.ToInt32(numericUpDownSeconds.Text);

            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            

            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                timer1.Enabled = false;
                TimeUpMessage myForm = new TimeUpMessage();
                myForm.ShowDialog();


            }

            else
            {
                minuteCounter++;
                seconds--;
                numericUpDownSeconds.Text = seconds.ToString();
                if (seconds == 0)
                {
                    minutes--;
                    numericUpDownMinutes.Text = minutes.ToString();
                    seconds = 59;
                    numericUpDownSeconds.Text = seconds.ToString();
                }
            }
        }
    }
}
