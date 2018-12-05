using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginFailureLabel.Visible)
            {
                LoginFailureLabel.Visible = false;
            }

            //Process login
            if (String.IsNullOrEmpty(UsernameTextBox.Text))
            {
                MessageBox.Show("Please provide your username.");
            }
            else if (String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Please enter your password.");
            }
            else
            {
                //Success
                if (LoginController.verifyUser(UsernameTextBox.Text, PasswordTextBox.Text, this))
                {
                    this.Hide();
                    this.UsernameTextBox.Text = String.Empty;
                    this.PasswordTextBox.Text = String.Empty;
                }
                //Failure
                else
                {
                    LoginFailureLabel.Visible = true;
                    MessageBox.Show("Invalid username/password.");
                }
            }
        }
    }
}
