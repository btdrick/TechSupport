using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// This class serves as a Dialog box to 
    /// create and add an incident report.
    /// </summary>
    public partial class AddIncidentDialog : Form
    {
        private readonly TechSupportController techSupportController;

        /// <summary>
        /// 0-param constructor
        /// </summary>
        public AddIncidentDialog()
        {
            InitializeComponent();
            this.techSupportController = new TechSupportController();
        }

        /// <summary>
        /// Handles the add incident button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIncidentButtonClick(object sender, System.EventArgs e)
        {
            try
            {
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;
                var customerID = int.Parse(this.customerIDTextBox.Text);

                this.techSupportController.Add(new Incident(title, description, customerID));

                this.DialogResult = DialogResult.OK;
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input!\n\nAn incident must have a:\n - Title\n- Description\n- CustomerID greater than 0", 
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the cancel button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
