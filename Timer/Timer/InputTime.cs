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
    public partial class InputTime : Form
    {
        public static int inputHours;
        public static int inputMinutes;
        public static int inputSeconds;


        public InputTime()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            {
                labelOutput.Text = "";
                inputHours = Convert.ToInt32(numericUpDownHours.Text);
                inputMinutes = Convert.ToInt32(numericUpDownMinutes.Text);
                inputSeconds = Convert.ToInt32(numericUpDownSeconds.Text);


                Countdown startCountdown = new Countdown();
                startCountdown.Show();
            }

            catch (FormatException)
            {
                labelOutput.Text = "Please Input A Number";
            }
        }

        private void Button30secs_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "00";
            numericUpDownSeconds.Text = "30";
        }

        private void Button1mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "1";
            numericUpDownSeconds.Text = "00";
        }

        private void Button2mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "2";
            numericUpDownSeconds.Text = "00";
        }

        private void Button5mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "5";
            numericUpDownSeconds.Text = "00";
        }

        private void Button10mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "10";
            numericUpDownSeconds.Text = "00";
        }

        private void Button15mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "15";
            numericUpDownSeconds.Text = "00";
        }

        private void Button20mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "20";
            numericUpDownSeconds.Text = "00";
        }

        private void Button25mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "25";
            numericUpDownSeconds.Text = "00";
        }

        private void Button30mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "30";
            numericUpDownSeconds.Text = "00";
        }

        private void Button35mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "35";
            numericUpDownSeconds.Text = "00";
        }

        private void Button40mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "40";
            numericUpDownSeconds.Text = "00";
        }

        private void Button45mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "45";
            numericUpDownSeconds.Text = "00";
        }

        private void Button50mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "50";
            numericUpDownSeconds.Text = "00";
        }

        private void Button55mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "00";
            numericUpDownMinutes.Text = "55";
            numericUpDownSeconds.Text = "00";
        }

        private void Button1hour_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "1";
            numericUpDownMinutes.Text = "00";
            numericUpDownSeconds.Text = "00";
        }

        private void Button1hour30mins_Click(object sender, EventArgs e)
        {
            numericUpDownHours.Text = "1";
            numericUpDownMinutes.Text = "30";
            numericUpDownSeconds.Text = "00";
        }
    }
}
