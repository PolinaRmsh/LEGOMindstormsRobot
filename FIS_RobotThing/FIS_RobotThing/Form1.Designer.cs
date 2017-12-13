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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firstForm));
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
            this.loginLB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.loginLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginLB.Location = new System.Drawing.Point(272, 132);
            this.loginLB.Name = "loginLB";
            this.loginLB.Size = new System.Drawing.Size(35, 15);
            this.loginLB.TabIndex = 0;
            this.loginLB.Text = "Login";
            // 
            // passwordLB
            // 
            this.passwordLB.AutoSize = true;
            this.passwordLB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.passwordLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordLB.Location = new System.Drawing.Point(272, 183);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(55, 15);
            this.passwordLB.TabIndex = 1;
            this.passwordLB.Text = "Password";
            // 
            // loginTB
            // 
            this.loginTB.BackColor = System.Drawing.Color.FloralWhite;
            this.loginTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.loginTB.Location = new System.Drawing.Point(272, 150);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(104, 20);
            this.loginTB.TabIndex = 2;
            this.loginTB.Click += new System.EventHandler(this.loginTB_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.FloralWhite;
            this.passwordTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.passwordTB.Location = new System.Drawing.Point(272, 201);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(104, 20);
            this.passwordTB.TabIndex = 3;
            this.passwordTB.Click += new System.EventHandler(this.loginTB_Click);
            this.passwordTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTB_KeyDown);
            // 
            // startBT
            // 
            this.startBT.BackColor = System.Drawing.Color.IndianRed;
            this.startBT.Location = new System.Drawing.Point(289, 255);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(78, 23);
            this.startBT.TabIndex = 4;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = false;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // wrongLB
            // 
            this.wrongLB.AutoSize = true;
            this.wrongLB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wrongLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wrongLB.ForeColor = System.Drawing.Color.Red;
            this.wrongLB.Location = new System.Drawing.Point(240, 107);
            this.wrongLB.Name = "wrongLB";
            this.wrongLB.Size = new System.Drawing.Size(170, 15);
            this.wrongLB.TabIndex = 5;
            this.wrongLB.Text = "Wrong login or password provided";
            this.wrongLB.Visible = false;
            // 
            // aboutBT
            // 
            this.aboutBT.BackColor = System.Drawing.Color.SpringGreen;
            this.aboutBT.Location = new System.Drawing.Point(12, 44);
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 359);
            this.Controls.Add(this.aboutBT);
            this.Controls.Add(this.wrongLB);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.passwordLB);
            this.Controls.Add(this.loginLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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

