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
    public partial class Dice : Form
    {
        public Dice()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int rndDiceOne = rnd.Next(1, 7);
            int rndDiceTwo = rnd.Next(1, 7);
            int rndDiceThree = rnd.Next(1, 7);

            //KJL 2020-01-26 18:51
            //Check dice one for its number and load corresponding image
            if (rndDiceOne == 1)
            {
                pictureBoxDiceOne.Image = global::Dice.Properties.Resources.Dice1;
            }

            if (rndDiceOne == 2)
            {
                pictureBoxDiceOne.Image = global::Dice.Properties.Resources.Dice2;
            }

            if (rndDiceOne == 3)
            {
                pictureBoxDiceOne.Image = global::Dice.Properties.Resources.Dice3;
            }

            if (rndDiceOne == 4)
            {
                pictureBoxDiceOne.Image = global::Dice.Properties.Resources.Dice4;
            }

            if (rndDiceOne == 5)
            {
                pictureBoxDiceOne.Image = global::Dice.Properties.Resources.Dice5;
            }

            if (rndDiceOne == 6)
            {
                pictureBoxDiceOne.Image = global::Dice.Properties.Resources.Dice6;
            }

            //KJL 2020-01-26 18:58
            //Check dice two for its number and load corresponding image
            if (rndDiceTwo == 1)
            {
                pictureBoxDiceTwo.Image = global::Dice.Properties.Resources.Dice1;
            }

            if (rndDiceTwo == 2)
            {
                pictureBoxDiceTwo.Image = global::Dice.Properties.Resources.Dice2;
            }

            if (rndDiceTwo == 3)
            {
                pictureBoxDiceTwo.Image = global::Dice.Properties.Resources.Dice3;
            }

            if (rndDiceTwo == 4)
            {
                pictureBoxDiceTwo.Image = global::Dice.Properties.Resources.Dice4;
            }

            if (rndDiceTwo == 5)
            {
                pictureBoxDiceTwo.Image = global::Dice.Properties.Resources.Dice5;
            }

            if (rndDiceTwo == 6)
            {
                pictureBoxDiceTwo.Image = global::Dice.Properties.Resources.Dice6;
            }

            //KJL 2020-01-26 21:23
            //Check dice two for its number and load corresponding image
            if (rndDiceThree == 1)
            {
                pictureBoxDiceThree.Image = global::Dice.Properties.Resources.Dice1;
            }

            if (rndDiceThree == 2)
            {
                pictureBoxDiceThree.Image = global::Dice.Properties.Resources.Dice2;
            }

            if (rndDiceThree == 3)
            {
                pictureBoxDiceThree.Image = global::Dice.Properties.Resources.Dice3;
            }

            if (rndDiceThree == 4)
            {
                pictureBoxDiceThree.Image = global::Dice.Properties.Resources.Dice4;
            }

            if (rndDiceThree == 5)
            {
                pictureBoxDiceThree.Image = global::Dice.Properties.Resources.Dice5;
            }

            if (rndDiceThree == 6)
            {
                pictureBoxDiceThree.Image = global::Dice.Properties.Resources.Dice6;
            }

            //KJL 2020-01-26 21:21
            //Display value of dice in textbox to test if it matches dice image
            textBoxDiceOne.Text = Convert.ToString(rndDiceOne);
            textBoxDiceTwo.Text = Convert.ToString(rndDiceTwo);
            textBoxDiceThree.Text = Convert.ToString(rndDiceThree);
        }

        //KJL 2020-01-26 21:37
        //If number of dice selected is 1, Dice 2 and 3 becomes invisible and 1 becomes visible
        private void radioButtonDiceOne_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDiceOne.Checked == true)
            {
                pictureBoxDiceOne.Visible = true;
                pictureBoxDiceTwo.Visible = false;
                pictureBoxDiceThree.Visible = false;
            }
        }

        //KJL 2020-01-26 21:42
        //If number of dice selected is 2, Dice 3 becomes invisible and 1 and 2 becomes visible
        private void radioButtonDiceTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDiceTwo.Checked == true)
            {
                pictureBoxDiceOne.Visible = true;
                pictureBoxDiceTwo.Visible = true;
                pictureBoxDiceThree.Visible = false;
            }
        }

        //KJL 2020-01-26 21:42
        //If number of dice selected is 3, all dice become visible
        private void radioButtonDiceThree_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDiceThree.Checked == true)
            {
                pictureBoxDiceOne.Visible = true;
                pictureBoxDiceTwo.Visible = true;
                pictureBoxDiceThree.Visible = true;
            }
        }
    }
}
