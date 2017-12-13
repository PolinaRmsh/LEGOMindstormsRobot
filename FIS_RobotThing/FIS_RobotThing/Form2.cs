﻿using System;
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

        #region Manual
        private void manualModeButton_Click(object sender, EventArgs e)
        {
            manualModePanel.Enabled = true;
        }

        #endregion
    }
}
