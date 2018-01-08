using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIS_RobotThing
{
    class Buttons
    {
        private void btstop_Click(object sender, EventArgs e)
        {

            messenger.SendMessage("MESSAGE", "stop");
        }

        private void btstart_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "start");


        }

        private void btpickup_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "pick");

        }

        private void btdropdown_Click(object sender, EventArgs e)
        {

        }

        private void btdropdown_Click_1(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "drop");
        }
    }
}
