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

        /*
         * Hides errorMessage when login info changed.
         */
        private void LoginTextBoxTextChangedEventHandle(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }

        /**
         * Validates username and password
         */
        private void LoginButtonClickEventHandle(object sender, EventArgs e)
        {
            if (ValidateLogin())
            {
                MainForm mainForm = new MainForm
                {
                    Owner = this,
                    LabelText = usernameTextBox.Text
                };
                mainForm.Show();
                this.Hide();
            }
            else
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Invalid username/password";
            }
        }

        /*
         * Validates usernameTextBox entry for login.
         */
        private bool ValidateLogin()
        {
            return (usernameTextBox.Text == "Jane") && (passwordTextBox.Text == "Test123");
        }

        /*
         * Closes the application upon form closure.
         */
        private void LoginFormClosedEventHandle(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
