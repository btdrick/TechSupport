using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.View;

namespace TechSupport
{
    /**
     * A Login form which allows the user to log in
     * to the Tech Support service.
     */
    public partial class LoginForm : Form
    {
        //Initializes LoginForm
        public LoginForm()
        {
            InitializeComponent();
        }

        //Validates username and password
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Jane" && passwordTextBox.Text == "Test123")
            {
                MainForm mainForm = new MainForm();
                mainForm.Owner = this;
                mainForm.LabelText = usernameTextBox.Text;
                mainForm.Show();
                this.Hide();
            } 
            else
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Invalid username/password";
            }
        }

        //Hides errorMessage when login info changed.
        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }

        //Closes the application upon form closure.
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
