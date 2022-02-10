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

        /// <summary>
        /// Handles the event of selecting a different tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TechSupportDashboardTabControlSelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (this.techSupportDashboardTabControl.SelectedIndex)
            {
                case 0:
                    this.addIncidentUserControl.RefreshComboBoxes();
                    break;
                case 1:
                    this.loadInternalIncidentsUserControl.RefreshDataGrid();
                    break;
                case 2:
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
