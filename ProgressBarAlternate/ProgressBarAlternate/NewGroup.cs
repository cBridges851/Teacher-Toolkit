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
    public partial class NewGroup : Form
    {

        public static bool newGroupCreated = true;

        public NewGroup()
        {
            InitializeComponent();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            newGroupCreated = true;
            this.Close();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            newGroupCreated = false;
            this.Close();
        }
    }
}
