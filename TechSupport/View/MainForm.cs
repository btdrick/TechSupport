using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// The main form for Tech Support application.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly TechSupportController techSupportController;

        /// <summary>
        /// Initializes MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.techSupportController = new TechSupportController();
            this.usernameLabel.Text = FormProvider.LoginForm.UsernameLabel;
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
        /// Loads the MainForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormLoad(object sender, System.EventArgs e)
        {
            this.RefreshDataGrid();
        }

        /// <summary>
        /// Refresh list of incident reports.
        /// </summary>
        private void RefreshDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.techSupportController.GetIncidents();
        }

        /// <summary>
        /// Handles event for addIncidentButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIncidentButtonClick(object sender, System.EventArgs e)
        {
            using (Form addIncidentDialog = new AddIncidentDialog())
            {
                DialogResult result = addIncidentDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.RefreshDataGrid();
                }
            }
        }

        /// <summary>
        /// Handles event for searchIncidentButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchIncidentButtonClick(object sender, System.EventArgs e)
        {
            using (Form searchIncidentDialog = new SearchIncidentDialog())
            {
                searchIncidentDialog.ShowDialog();
            }
        }
    }
}
