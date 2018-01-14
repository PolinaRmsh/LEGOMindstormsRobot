using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//libraries for EV3
using EV3MessengerLib;
using System.IO.Ports;

namespace FIS_RobotThing
{
    public partial class secondForm : Form
    {
        private EV3Messenger messenger;
        static firstForm firstForm = new firstForm();

        public secondForm()
        {
            InitializeComponent();
            //initialising the app
            messenger = new EV3Messenger();
            fillSerialPortSelectionBoxWithAvailablePorts();
            updateFormGUI();
        }

        //exiting the app
        private void logoutBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstForm.Show();
        }

        #region Connection form

        private void refreshButton_Click(object sender, EventArgs e)
        {
            fillSerialPortSelectionBoxWithAvailablePorts();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

            if (portListBox.SelectedIndex > -1)
            {
                // Get the selected port from the ListBox
                string port = portListBox.SelectedItem.ToString().ToUpper();
                // Try to connect with the Brick via the selected port
                if (messenger.Connect(port))
                {
                    updateFormGUI();
                    connectButton.BackColor = Color.LimeGreen;
                }
                else
                {
                    MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                        + "Make sure your robot is connected to that serial port and try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select a port for the bluetooth connection");
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            messenger.Disconnect();
            connectButton.BackColor = Color.SpringGreen;
            updateFormGUI();

        }

        private void fillSerialPortSelectionBoxWithAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            portListBox.Items.Clear();
            foreach (String port in ports)
            {
                portListBox.Items.Add(port);
            }
        }


        #endregion

        #region IO form

        private void inputButton_Click(object sender, EventArgs e)
        {
            string txtMsg = inputTextBox.Text;
            // Make sure a message has been typed
            if (!String.IsNullOrWhiteSpace(txtMsg))
            {
                // Send a message to the Brick with title: MESSAGE and the message
                if (messenger.SendMessage("MESSAGE", txtMsg))
                {
                    inputTextBox.Text = "";
                    MessageBox.Show("The message has been send to the Brick");
                }
                else
                {
                    MessageBox.Show("Unable to send the message to the Brick. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please type a message in the above textbox for the Brick");
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            // Try to get a message
            EV3Message message = messenger.ReadMessage();
            // Check if there is a message received from the Brick
            if (message != null)
            {
                outputListBox.Items.Add("Message: " + message.ValueAsText);
                // Auto scroll the listbox
                outputListBox.TopIndex = outputListBox.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("No message recieved from the Brick");
            }
        }


        #endregion

        #region GUI

        private void updateFormGUI()
        {
            if (messenger.IsConnected)
            {
                refreshButton.Enabled = false;
                connectButton.Enabled = false;

                panel2.Enabled = true;
                panel3.Enabled = true;
                disconnectButton.Enabled = true;

                outputListBox.Items.Clear();
            }
            else
            {
                refreshButton.Enabled = true;
                connectButton.Enabled = true;

                panel2.Enabled = false;
                panel3.Enabled = false;
                disconnectButton.Enabled = false;
            }
        }
        #endregion

        #region Modes
        //  MANUAL MODE TURNING ON/OFF
        private void manualModeButton_Click(object sender, EventArgs e)
        {
            if (messenger.IsConnected)
            {
                if (manualModePanel.Enabled)
                {
                    messenger.SendMessage("MESSAGE", "manualout");
                    manualModePanel.Enabled = false;
                    manualModePanel.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    manualModePanel.Enabled = true;
                    messenger.SendMessage("MESSAGE", "manual");
                    manualModePanel.BackColor = Color.Lavender;
                }
                if (autoModePanel.Enabled)
                {
                    autoModePanel.Enabled = false;
                    autoModePanel.BackColor = Color.WhiteSmoke;
                }
            }
            else
            {
                MessageBox.Show("Make sure you are connected to the robot");
            }

        }

        //  AUTO MODE TURNING ON/OFF
        private void btnAutoMode_Click(object sender, EventArgs e)
        {
            if (messenger.IsConnected)
            {
                if (autoModePanel.Enabled)
                {
                    autoModePanel.Enabled = false;
                    autoModePanel.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    autoModePanel.Enabled = true;
                    autoModePanel.BackColor = Color.Lavender;
                    messenger.SendMessage("MESSAGE", "auto");
                }
                if (manualModePanel.Enabled)
                {
                    messenger.SendMessage("MESSAGE", "manualout");
                    manualModePanel.Enabled = false;
                    manualModePanel.BackColor = Color.WhiteSmoke;
                }
            }
            else
            {
                MessageBox.Show("Make sure you are connected to the robot");
            }

        }

        //  BUTTONS IN AUTO MODE
        bool paused = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "start");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "stop");
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (paused == true)
            {
                messenger.SendMessage("MESSAGE", "busy");
                paused = false;
            }
            else
            {
                messenger.SendMessage("MESSAGE", "pause");
                paused = true;
            }
        }

        //  BUTTONS IN MANUAL MODE
        private void btnForw_Click(object sender, EventArgs e)
        {
            if (trackBarSpeed.Value == 0)
            {
                messenger.SendMessage("MESSAGE", "forwardslow");
            }
            else if (trackBarSpeed.Value == 1)
            {
                messenger.SendMessage("MESSAGE", "forwardmedium");
            }
            else if (trackBarSpeed.Value == 2)
            {
                messenger.SendMessage("MESSAGE", "forwardfast");
            }
        }

        private void btnBackw_Click(object sender, EventArgs e)
        {

            if (trackBarSpeed.Value == 0)
            {
                messenger.SendMessage("MESSAGE", "backwardsslow");
            }
            else if (trackBarSpeed.Value == 1)
            {
                messenger.SendMessage("MESSAGE", "backwardsmedium");
            }
            else if (trackBarSpeed.Value == 2)
            {
                messenger.SendMessage("MESSAGE", "backwardsfast");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "right");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "left");
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "stop");
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "pick");
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "drop");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Try to get a message
            EV3Message message = messenger.ReadMessage();
            // Check if there is a message received from the Brick
            if (message != null)
            {
                outputListBox.Items.Add("Message: " + message.ValueAsText);
                // Auto scroll the listbox
                outputListBox.TopIndex = outputListBox.Items.Count - 1;
            }
            else
            {

            }
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string txtMsg = inputTextBox.Text;
                // Make sure a message has been typed
                if (!String.IsNullOrWhiteSpace(txtMsg))
                {
                    // Send a message to the Brick with title: MESSAGE and the message
                    if (messenger.SendMessage("MESSAGE", txtMsg))
                    {
                        inputTextBox.Text = "";
                        MessageBox.Show("The message has been send to the Brick");
                    }
                    else
                    {
                        MessageBox.Show("Unable to send the message to the Brick. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Please type a message for the Brick");
                }
            }










            #endregion

            /*private void secondForm_KeyDown(object sender, KeyEventArgs e)
            {
                if (!manualModePanel.Enabled)
                {
                    return;
                }
                switch (e.KeyCode)
                {
                    case Keys.A:
                        messenger.SendMessage("MESSAGE", "left");
                        break;
                    case Keys.W:
                        messenger.SendMessage("MESSAGE", "forward");
                        break;
                    case Keys.D:
                        messenger.SendMessage("MESSAGE", "right");
                        break;
                    case Keys.S:
                        messenger.SendMessage("MESSAGE", "backwards");
                        break;
                }
            }*/
        }

     
    }
}
