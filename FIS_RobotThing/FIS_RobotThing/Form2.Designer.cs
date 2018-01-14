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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(secondForm));
            this.logoutBT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.manualModeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.portListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.manualModePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnPick = new System.Windows.Forms.Button();
            this.btnBackw = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.autoModePanel = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAutoMode = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.manualModePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.panel2.SuspendLayout();
            this.autoModePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutBT
            // 
            this.logoutBT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.logoutBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutBT.BackgroundImage")));
            this.logoutBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBT.Location = new System.Drawing.Point(540, 12);
            this.logoutBT.Name = "logoutBT";
            this.logoutBT.Size = new System.Drawing.Size(40, 40);
            this.logoutBT.TabIndex = 0;
            this.logoutBT.UseVisualStyleBackColor = false;
            this.logoutBT.Click += new System.EventHandler(this.logoutBT_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.outputListBox);
            this.panel3.Location = new System.Drawing.Point(238, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 181);
            this.panel3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Robot Commands Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // outputListBox
            // 
            this.outputListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(18, 26);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(179, 147);
            this.outputListBox.TabIndex = 5;
            // 
            // manualModeButton
            // 
            this.manualModeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.manualModeButton.Location = new System.Drawing.Point(12, 243);
            this.manualModeButton.Name = "manualModeButton";
            this.manualModeButton.Size = new System.Drawing.Size(75, 65);
            this.manualModeButton.TabIndex = 8;
            this.manualModeButton.Text = "Go to manual mode!";
            this.manualModeButton.UseVisualStyleBackColor = false;
            this.manualModeButton.Click += new System.EventHandler(this.manualModeButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(165, 26);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(40, 40);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.LightGreen;
            this.connectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectButton.BackgroundImage")));
            this.connectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.connectButton.FlatAppearance.BorderSize = 0;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Location = new System.Drawing.Point(73, 26);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(40, 40);
            this.connectButton.TabIndex = 2;
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.IndianRed;
            this.disconnectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("disconnectButton.BackgroundImage")));
            this.disconnectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.disconnectButton.FlatAppearance.BorderSize = 0;
            this.disconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectButton.Location = new System.Drawing.Point(119, 26);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(40, 40);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // portListBox
            // 
            this.portListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.portListBox.FormattingEnabled = true;
            this.portListBox.Location = new System.Drawing.Point(3, 21);
            this.portListBox.Name = "portListBox";
            this.portListBox.Size = new System.Drawing.Size(64, 56);
            this.portListBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.portListBox);
            this.panel1.Controls.Add(this.disconnectButton);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 79);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please choose a Bluetooth COM port";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // manualModePanel
            // 
            this.manualModePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.manualModePanel.Controls.Add(this.label1);
            this.manualModePanel.Controls.Add(this.trackBarSpeed);
            this.manualModePanel.Controls.Add(this.btnDrop);
            this.manualModePanel.Controls.Add(this.btnPick);
            this.manualModePanel.Controls.Add(this.btnBackw);
            this.manualModePanel.Controls.Add(this.btnLeft);
            this.manualModePanel.Controls.Add(this.btnRight);
            this.manualModePanel.Controls.Add(this.btnUp);
            this.manualModePanel.Enabled = false;
            this.manualModePanel.Location = new System.Drawing.Point(106, 210);
            this.manualModePanel.Name = "manualModePanel";
            this.manualModePanel.Size = new System.Drawing.Size(348, 129);
            this.manualModePanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose the speed \r\nof the robot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.BackColor = System.Drawing.SystemColors.GrayText;
            this.trackBarSpeed.Location = new System.Drawing.Point(152, 53);
            this.trackBarSpeed.Maximum = 2;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(93, 45);
            this.trackBarSpeed.TabIndex = 6;
            // 
            // btnDrop
            // 
            this.btnDrop.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDrop.Location = new System.Drawing.Point(266, 73);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(75, 23);
            this.btnDrop.TabIndex = 5;
            this.btnDrop.Text = "Drop";
            this.btnDrop.UseVisualStyleBackColor = false;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // btnPick
            // 
            this.btnPick.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPick.Location = new System.Drawing.Point(266, 44);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 4;
            this.btnPick.Text = "Pick up";
            this.btnPick.UseVisualStyleBackColor = false;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // btnBackw
            // 
            this.btnBackw.BackColor = System.Drawing.Color.Transparent;
            this.btnBackw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackw.BackgroundImage")));
            this.btnBackw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackw.FlatAppearance.BorderSize = 0;
            this.btnBackw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackw.ForeColor = System.Drawing.Color.Transparent;
            this.btnBackw.Location = new System.Drawing.Point(48, 86);
            this.btnBackw.Name = "btnBackw";
            this.btnBackw.Size = new System.Drawing.Size(40, 40);
            this.btnBackw.TabIndex = 3;
            this.btnBackw.UseVisualStyleBackColor = false;
            this.btnBackw.Click += new System.EventHandler(this.btnBackw_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLeft.BackgroundImage")));
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.ForeColor = System.Drawing.Color.Transparent;
            this.btnLeft.Location = new System.Drawing.Point(3, 44);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(39, 40);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRight.BackgroundImage")));
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.ForeColor = System.Drawing.Color.Transparent;
            this.btnRight.Location = new System.Drawing.Point(94, 44);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(40, 40);
            this.btnRight.TabIndex = 1;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUp.BackgroundImage")));
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.Color.Transparent;
            this.btnUp.Location = new System.Drawing.Point(48, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 40);
            this.btnUp.TabIndex = 0;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnForw_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.inputTextBox);
            this.panel2.Controls.Add(this.inputButton);
            this.panel2.Location = new System.Drawing.Point(473, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 96);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manual sendng \r\nof commands";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.inputTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.inputTextBox.Location = new System.Drawing.Point(13, 37);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(80, 20);
            this.inputTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.inputTextBox, resources.GetString("inputTextBox.ToolTip"));
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // inputButton
            // 
            this.inputButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputButton.Location = new System.Drawing.Point(13, 62);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(80, 23);
            this.inputButton.TabIndex = 4;
            this.inputButton.Text = "Send";
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // autoModePanel
            // 
            this.autoModePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.autoModePanel.Controls.Add(this.btnPause);
            this.autoModePanel.Controls.Add(this.btnStart);
            this.autoModePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.autoModePanel.Enabled = false;
            this.autoModePanel.Location = new System.Drawing.Point(106, 136);
            this.autoModePanel.Name = "autoModePanel";
            this.autoModePanel.Size = new System.Drawing.Size(99, 49);
            this.autoModePanel.TabIndex = 9;
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.Color.Transparent;
            this.btnPause.Location = new System.Drawing.Point(53, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(40, 40);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.Transparent;
            this.btnStart.Location = new System.Drawing.Point(7, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(40, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAutoMode
            // 
            this.btnAutoMode.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAutoMode.Location = new System.Drawing.Point(12, 128);
            this.btnAutoMode.Name = "btnAutoMode";
            this.btnAutoMode.Size = new System.Drawing.Size(75, 65);
            this.btnAutoMode.TabIndex = 10;
            this.btnAutoMode.Text = "Go to automatic mode!";
            this.btnAutoMode.UseVisualStyleBackColor = false;
            this.btnAutoMode.Click += new System.EventHandler(this.btnAutoMode_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 700;
            this.toolTip1.ReshowDelay = 100;
            // 
            // secondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 351);
            this.Controls.Add(this.btnAutoMode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.autoModePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.manualModeButton);
            this.Controls.Add(this.manualModePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.logoutBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "secondForm";
            this.Text = "Robot App Controls";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.manualModePanel.ResumeLayout(false);
            this.manualModePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.autoModePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutBT;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.Button btnBackw;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Panel autoModePanel;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAutoMode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}