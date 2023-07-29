using News_ClassLibrary.Business.ManagerClasses;
using News_ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace News_DesktopApplication.Presentation
{
    public partial class ViewAllSubscribers : Form
    {
        SubscribeManager subscribeManager;
        public ViewAllSubscribers()
        {
            InitializeComponent();

            subscribeManager = new SubscribeManager(new SubscriptionRepository());

            ShowAllSubscribers();
        }

        public void ShowAllSubscribers()
        {
            this.dgvSubscribers.DataSource = subscribeManager.GetAllSubsscription();
        }
    }
}
