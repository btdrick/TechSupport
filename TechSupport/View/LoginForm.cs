using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Validates username and password
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Jane" && passwordTextBox.Text == "Test123")
            {

            } else
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Invalid username/password";
            }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }
    }
}
