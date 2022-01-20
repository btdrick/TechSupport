using System;
using System.Windows.Forms;
using TechSupport.View;

namespace TechSupport
{
    /// <summary>
    /// A Login form which allows the user to log in 
    /// to the Tech Support service.
    /// </summary>
    public partial class LoginForm : Form
    {
        private MainForm mainForm;

        //Initializes LoginForm
        public LoginForm()
        {
            mainForm = new MainForm()
            {
                Owner = this,
            };
            InitializeComponent();
        }

        /// <summary>
        /// Hides errorMessage when login info changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginTextBoxTextChangedEventHandle(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }

        /// <summary>
        /// Validates username and password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButtonClickEventHandle(object sender, EventArgs e)
        {
            if (ValidateLogin())
            {
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

        /// <summary>
        /// Validates usernameTextBox entry for login.
        /// </summary>
        /// <returns>true for valid login</returns>
        private bool ValidateLogin()
        {
            return (usernameTextBox.Text == "Jane") && (passwordTextBox.Text == "test1234");
        }

        /// <summary>
        /// Closes the application upon form closure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginFormClosedEventHandle(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
