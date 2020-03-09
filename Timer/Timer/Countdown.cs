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
    public partial class Countdown : Form
    {
        int countdownHours;
        int countdownMinutes;
        int countdownSeconds;

        public static int totalSeconds;
        public static int totalMinutes;
        public static int leftOverSeconds;

        public static int timeLeftInSeconds;

        public static int totalHours;

        public static string hoursOutput;
        public static string minutesOutput;
        public static string secondsOutput;

        bool running = true;

        public Countdown()
        {
            InitializeComponent();
            countdownHours = InputTime.inputHours;
            countdownMinutes = InputTime.inputMinutes;
            countdownSeconds = InputTime.inputSeconds;

            totalSeconds = (countdownHours * 3600) + (countdownMinutes * 60) + countdownSeconds;
            timeLeftInSeconds = totalSeconds;

            totalMinutes = totalSeconds / 60;
            leftOverSeconds = totalSeconds % 60;
            

            totalHours = totalMinutes / 60;
            totalMinutes = totalMinutes % 60;

            FormatOutput();

            labelTimeOutput.Text = hoursOutput + ":" + minutesOutput + ":" + secondsOutput;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //CB 2020-03-09 Numerical Countdown
            leftOverSeconds--;
            timeLeftInSeconds--;

            if (leftOverSeconds == -1)
            {
                if (totalMinutes != 0)
                {
                    leftOverSeconds = 59;
                    totalMinutes--;

                    
                }

                else if (totalHours != 0 && totalMinutes == 0)
                {
                    totalMinutes = 59;
                    leftOverSeconds = 59;

                    totalHours--;
                }

                else
                {
                    leftOverSeconds = 0;
                }
            }

            FormatOutput();
            labelTimeOutput.Text = hoursOutput + ":" + minutesOutput + ":" + secondsOutput;

            if (totalHours == 0 && totalMinutes == 0 && leftOverSeconds == 0)
            {
                timer1.Enabled = false;
                TimeUpMessage timeUpOutput = new TimeUpMessage();
                timeUpOutput.ShowDialog();
                this.Close();
            }


        }

        public static void FormatOutput()
        {
            if (totalHours < 10)
            {
                hoursOutput = "0" + totalHours.ToString();
            }

            else
            {
                hoursOutput = totalHours.ToString();
            }

            if (totalMinutes < 10)
            {
                minutesOutput = "0" + totalMinutes.ToString();
            }

            else
            {
                minutesOutput = totalMinutes.ToString();
            }

            if (leftOverSeconds < 10)
            {
                secondsOutput = "0" + leftOverSeconds.ToString();
            }

            else
            {
                secondsOutput = leftOverSeconds.ToString();
            }

            
        }

        private void ButtonPauseResume_Click(object sender, EventArgs e)
        {
            if (running == true)
            {
                buttonPauseResume.Text = "Resume";
                buttonPauseResume.BackColor = Color.Green;
                running = false;
                timer1.Enabled = false;
            }

            else 
            {
                buttonPauseResume.Text = "Pause";
                buttonPauseResume.BackColor = Color.Red;
                running = true;
                timer1.Enabled = true;
            }
        }
    }
}
