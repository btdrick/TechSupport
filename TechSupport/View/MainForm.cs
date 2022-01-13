using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.View
{
    /**
     * The main form for Tech Support application.
     */
    public partial class MainForm : Form
    {
        /*
         * Exposes label property to be manipulated
         */
        public string LabelText
        {
            get
            {
                return this.usernameLabel.Text;
            }
            set 
            {
                this.usernameLabel.Text = value;
            }
        }

        /*
         * Initializes MainForm
         */
        public MainForm()
        {
            InitializeComponent();
        }

        /*
         * Hides current form and shows owner LoginForm
         */
        private void LogoutLinkClickedEventHandle(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        /*
         * Closes the application upon form closure.
         */
        private void MainFormClosedEventHandle(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
