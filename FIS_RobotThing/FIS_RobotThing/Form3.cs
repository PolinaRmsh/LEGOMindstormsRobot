using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIS_RobotThing
{
    public partial class thirdForm : Form
    {
        public thirdForm()
        {
            InitializeComponent();
        }
        //removing the form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
