using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// The main form for Tech Support application.
    /// </summary>
    public partial class MainForm : Form
    {

        /// <summary>
        /// Initializes MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.usernameLabel.Text = "Hello, " + FormProvider.LoginForm.UsernameLabel + "!";
        }

        /// <summary>
        /// Hides current form and shows owner LoginForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutLinkClickedEventHandle(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormProvider.LoginForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Closes the application upon form closure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormClosedEventHandle(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TechSupportDashboardTabControlSelectedIndexChanged(object sender, System.EventArgs e)
        {
            //if (this.techSupportDashboardTabControl.SelectedTab == this.techSupportDashboardTabControl.TabPages["displayOpenIncidentsTab"])
            //{
            //    this.displayOpenIncidentsUserControl.RefreshOpenIncidents();
            //}
            //if (this.techSupportDashboardTabControl.SelectedTab == this.techSupportDashboardTabControl.TabPages["loadInternalIncidentsTab"])
            //{
            //    this.loadInternalIncidentsUserControl.RefreshDataGrid();
           // }

            switch (this.techSupportDashboardTabControl.SelectedIndex)
            {
                case 1:
                    this.loadInternalIncidentsUserControl.RefreshDataGrid();
                    break;
                case 3:
                    this.displayOpenIncidentsUserControl.RefreshOpenIncidents();
                    break;
                default:
                    break;
            }
        }
    }
}
