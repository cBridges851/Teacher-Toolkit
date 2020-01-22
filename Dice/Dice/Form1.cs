using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int rndDiceOne = rnd.Next(1, 8);
            int rndDiceTwo = rnd.Next(1, 8);

            textBoxDiceOne.Text = Convert.ToString(rndDiceOne);
            textBoxDiceTwo.Text = Convert.ToString(rndDiceTwo);
        }
    }
}
