namespace FIS_RobotThing
{
    partial class firstForm
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
            this.loginLB = new System.Windows.Forms.Label();
            this.passwordLB = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.startBT = new System.Windows.Forms.Button();
            this.wrongLB = new System.Windows.Forms.Label();
            this.aboutBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLB
            // 
            this.loginLB.AutoSize = true;
            this.loginLB.Location = new System.Drawing.Point(272, 99);
            this.loginLB.Name = "loginLB";
            this.loginLB.Size = new System.Drawing.Size(29, 13);
            this.loginLB.TabIndex = 0;
            this.loginLB.Text = "login";
            // 
            // passwordLB
            // 
            this.passwordLB.AutoSize = true;
            this.passwordLB.Location = new System.Drawing.Point(272, 152);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(52, 13);
            this.passwordLB.TabIndex = 1;
            this.passwordLB.Text = "password";
            // 
            // loginTB
            // 
            this.loginTB.BackColor = System.Drawing.Color.LemonChiffon;
            this.loginTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.loginTB.Location = new System.Drawing.Point(275, 115);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(100, 20);
            this.loginTB.TabIndex = 2;
            this.loginTB.Click += new System.EventHandler(this.loginTB_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.LemonChiffon;
            this.passwordTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.passwordTB.Location = new System.Drawing.Point(275, 168);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(100, 20);
            this.passwordTB.TabIndex = 3;
            this.passwordTB.Click += new System.EventHandler(this.loginTB_Click);
            // 
            // startBT
            // 
            this.startBT.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.startBT.Location = new System.Drawing.Point(275, 209);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(75, 23);
            this.startBT.TabIndex = 4;
            this.startBT.Text = "start";
            this.startBT.UseVisualStyleBackColor = false;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // wrongLB
            // 
            this.wrongLB.AutoSize = true;
            this.wrongLB.BackColor = System.Drawing.Color.Azure;
            this.wrongLB.ForeColor = System.Drawing.Color.Red;
            this.wrongLB.Location = new System.Drawing.Point(240, 73);
            this.wrongLB.Name = "wrongLB";
            this.wrongLB.Size = new System.Drawing.Size(168, 13);
            this.wrongLB.TabIndex = 5;
            this.wrongLB.Text = "Wrong login or password provided";
            this.wrongLB.Visible = false;
            // 
            // aboutBT
            // 
            this.aboutBT.BackColor = System.Drawing.Color.LightPink;
            this.aboutBT.Location = new System.Drawing.Point(12, 12);
            this.aboutBT.Name = "aboutBT";
            this.aboutBT.Size = new System.Drawing.Size(53, 23);
            this.aboutBT.TabIndex = 6;
            this.aboutBT.Text = "About";
            this.aboutBT.UseVisualStyleBackColor = false;
            this.aboutBT.Click += new System.EventHandler(this.aboutBT_Click);
            // 
            // firstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(642, 359);
            this.Controls.Add(this.aboutBT);
            this.Controls.Add(this.wrongLB);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.passwordLB);
            this.Controls.Add(this.loginLB);
            this.Name = "firstForm";
            this.Text = "Robot App Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLB;
        private System.Windows.Forms.Label passwordLB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button startBT;
        private System.Windows.Forms.Label wrongLB;
        private System.Windows.Forms.Button aboutBT;
    }
}

