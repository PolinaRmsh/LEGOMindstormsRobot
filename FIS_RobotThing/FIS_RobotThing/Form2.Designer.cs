namespace FIS_RobotThing
{
    partial class secondForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(secondForm));
            this.logoutBT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.manualModeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.portListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manualModePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutBT
            // 
            this.logoutBT.BackColor = System.Drawing.Color.IndianRed;
            this.logoutBT.Location = new System.Drawing.Point(488, 12);
            this.logoutBT.Name = "logoutBT";
            this.logoutBT.Size = new System.Drawing.Size(75, 23);
            this.logoutBT.TabIndex = 0;
            this.logoutBT.Text = "Log Out";
            this.logoutBT.UseVisualStyleBackColor = false;
            this.logoutBT.Click += new System.EventHandler(this.logoutBT_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.outputListBox);
            this.panel3.Controls.Add(this.outputButton);
            this.panel3.Location = new System.Drawing.Point(215, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 112);
            this.panel3.TabIndex = 6;
            // 
            // outputListBox
            // 
            this.outputListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(17, 13);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(212, 56);
            this.outputListBox.TabIndex = 5;
            // 
            // outputButton
            // 
            this.outputButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.outputButton.Location = new System.Drawing.Point(154, 75);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 23);
            this.outputButton.TabIndex = 4;
            this.outputButton.Text = "Receive";
            this.outputButton.UseVisualStyleBackColor = false;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // manualModeButton
            // 
            this.manualModeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.manualModeButton.Location = new System.Drawing.Point(69, 138);
            this.manualModeButton.Name = "manualModeButton";
            this.manualModeButton.Size = new System.Drawing.Size(75, 65);
            this.manualModeButton.TabIndex = 8;
            this.manualModeButton.Text = "Go to manual mode!";
            this.manualModeButton.UseVisualStyleBackColor = false;
            this.manualModeButton.Click += new System.EventHandler(this.manualModeButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.refreshButton.Location = new System.Drawing.Point(94, 13);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.SpringGreen;
            this.connectButton.Location = new System.Drawing.Point(94, 50);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.IndianRed;
            this.disconnectButton.Location = new System.Drawing.Point(94, 85);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // portListBox
            // 
            this.portListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.portListBox.FormattingEnabled = true;
            this.portListBox.Location = new System.Drawing.Point(13, 13);
            this.portListBox.Name = "portListBox";
            this.portListBox.Size = new System.Drawing.Size(75, 95);
            this.portListBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.portListBox);
            this.panel1.Controls.Add(this.disconnectButton);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 118);
            this.panel1.TabIndex = 3;
            // 
            // manualModePanel
            // 
            this.manualModePanel.BackColor = System.Drawing.Color.FloralWhite;
            this.manualModePanel.Enabled = false;
            this.manualModePanel.Location = new System.Drawing.Point(12, 220);
            this.manualModePanel.Name = "manualModePanel";
            this.manualModePanel.Size = new System.Drawing.Size(551, 115);
            this.manualModePanel.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.inputTextBox);
            this.panel2.Controls.Add(this.inputButton);
            this.panel2.Location = new System.Drawing.Point(215, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 73);
            this.panel2.TabIndex = 5;
            // 
            // inputButton
            // 
            this.inputButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputButton.Location = new System.Drawing.Point(142, 39);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(87, 23);
            this.inputButton.TabIndex = 4;
            this.inputButton.Text = "Send message";
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.inputTextBox.Location = new System.Drawing.Point(14, 13);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(215, 20);
            this.inputTextBox.TabIndex = 5;
            // 
            // secondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 348);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.manualModeButton);
            this.Controls.Add(this.manualModePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoutBT);
            this.Name = "secondForm";
            this.Text = "Robot App Controls";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutBT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button manualModeButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.ListBox portListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel manualModePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button inputButton;
    }
}