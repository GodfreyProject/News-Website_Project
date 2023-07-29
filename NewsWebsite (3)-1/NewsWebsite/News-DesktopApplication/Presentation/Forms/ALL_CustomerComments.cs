using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace News_DesktopApplication.Presentation.Forms
{
    public partial class ALL_CustomerComments : Form
    {
        ReviewManager reviewManager;
        public ALL_CustomerComments()
        {
            InitializeComponent();

            reviewManager = new ReviewManager(new ReviewRePository());

            DisplayAllCoomets();
        }

        public void DisplayAllCoomets()
        {
            try
            {
                dgvAllComments.DataSource = reviewManager.GetAllReviews();
            }
            catch
            {
                MessageBox.Show("'Errors");
            }
        }
    }
}
