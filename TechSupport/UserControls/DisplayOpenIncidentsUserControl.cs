using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class DisplayOpenIncidentsUserControl : UserControl
    {
        private readonly TechSupportController techSupportController;

        /// <summary>
        /// 0-param constructor
        /// </summary>
        public DisplayOpenIncidentsUserControl()
        {
            InitializeComponent();
            this.techSupportController = new TechSupportController();
            this.RefreshOpenIncidents();
        }

        /// <summary>
        /// Refreshes the ListView of Open Incidents.
        /// </summary>
        public void RefreshOpenIncidents()
        {
            this.openIncidentsListView.Items.Clear();
            try
            {
                List<Incident> openIncidents = this.techSupportController.GetOpenIncidents();

                if (openIncidents.Count > 0)
                {
                    Incident incident;
                    for (int i = 0; i < openIncidents.Count; i++)
                    {
                        incident = openIncidents[i];
                        this.openIncidentsListView.Items.Add(incident.ProductCode);
                        this.openIncidentsListView.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        this.openIncidentsListView.Items[i].SubItems.Add(incident.Customer);
                        this.openIncidentsListView.Items[i].SubItems.Add(incident.Technician);
                        this.openIncidentsListView.Items[i].SubItems.Add(incident.Title);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.openIncidentsListView.Clear();
            }
        }
    }
}
