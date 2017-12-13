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
    public partial class firstForm : Form
    {
        public firstForm()
        {
            InitializeComponent();
        }

        static secondForm secondForm = new secondForm();
        private string passwordHash = "$2a$10$idkaaeH0zsFslR.erxyywuiI5TQ7x4sgsrj91lRWANuMvtRW0676u";

        private void startBT_Click(object sender, EventArgs e)
        {
            if (loginTB.Text == "admin" && BCrypt.CheckPassword(passwordTB.Text, passwordHash))
            {
                
                this.Hide();
                secondForm.Show();
                wrongLB.Visible = false;
            }
            else
            {
                loginTB.Text = "";
                passwordTB.Text = "";
                wrongLB.Visible = true;
            }
            
        }

       

        private void loginTB_Click(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;               
            if (text.Text == "Wrong")                   
            {
                text.Text = "";
            }
        }

        static thirdForm thirdForm = new thirdForm();

        private void aboutBT_Click(object sender, EventArgs e)
        {
            thirdForm.Show();
        }

        private void passwordTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (loginTB.Text == "admin" && BCrypt.CheckPassword(passwordTB.Text, passwordHash))
                {

                    this.Hide();
                    secondForm.Show();
                    wrongLB.Visible = false;
                }
                else
                {
                    loginTB.Text = "";
                    passwordTB.Text = "";
                    wrongLB.Visible = true;
                }
            }
        }


        /*private void loginTB_Click(object sender, EventArgs e)
{
if (loginTB.Text == "Wrong")
{
loginTB.Text = "";
}
}
private void passwordTB_Click(object sender, EventArgs e)
{
if (passwordTB.Text == "Wrong")
{
passwordTB.Text = "";
}
}*/

    }
    
}
