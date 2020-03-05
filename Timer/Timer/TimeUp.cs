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
    public partial class TimeUpMessage : Form
    {
        public TimeUpMessage()
        {
            InitializeComponent();
        }

        private void TimeUpMessage_Load(object sender, EventArgs e)
        {

        }

        private void ButtonTimeUpClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
