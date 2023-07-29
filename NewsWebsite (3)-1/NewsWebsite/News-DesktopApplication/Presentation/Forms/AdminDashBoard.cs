//using News_ClassLibrary.AdminInterface;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_DesktopApplication.Presentation;
using News_DesktopApplication.Presentation.Forms;
using SynthesisClassLibrary;
using SynthesisClassLibrary.ManagerClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace News_DesktopApplication.Forms
{
    public partial class AdminDashBoard : Form
    {
        NewsArticleManager  control;
        PersonManager personManager;
        Admin a;
        public AdminDashBoard(Admin admin , PersonManager adminControl)
        {
            InitializeComponent();

            a = admin;
            ///control = adminControl;
            personManager = adminControl;

            Detail();
        }

        public void Detail()
        {
            lbCustomerFirstName.Text = $"Welcomr Customer:{a.Username}";
        }
        private void adminProFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile(a, personManager);

            adminProfile.Show();

            //this.Hide();
        }

        private void addNewsContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewsArticle newsArticle = new NewsArticle();
            ADDContents aDDContents = new ADDContents(newsArticle);

            aDDContents.Show();

            //this.Close();
        }

        private void showAllContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllContents showAllContents = new ShowAllContents();

            showAllContents.Show();

            //Close();
        }

        private void aLLPersonInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllPersonsInfo allPersonsInfo = new AllPersonsInfo();

            allPersonsInfo.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Review review = new Review();
            Login login = new Login(review);

            login.Show();

            this.Hide();
        }

        private void commentsByCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALL_CustomerComments aLL_CustomerComments = new ALL_CustomerComments();

            aLL_CustomerComments.Show();
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile(a, personManager);

            adminProfile.Show();

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            AdminChangePassword adminChange = new AdminChangePassword(a);

            adminChange.Show();
        }

        private void btnAddNewsContent_Click(object sender, EventArgs e)
        {
            NewsArticle newsArticle = new NewsArticle();
            ADDContents aDDContents = new ADDContents(newsArticle);

            aDDContents.Show();
        }

        private void btnShowAllNews_Click(object sender, EventArgs e)
        {
            ShowAllContents showAllContents = new ShowAllContents();

            showAllContents.Show();

        }

        private void btnAllPersonsInfo_Click(object sender, EventArgs e)
        {
            AllPersonsInfo allPersonsInfo = new AllPersonsInfo();

            allPersonsInfo.Show();
        }

        private void btnAllComments_Click(object sender, EventArgs e)
        {
            ALL_CustomerComments aLL_CustomerComments = new ALL_CustomerComments();

            aLL_CustomerComments.Show();
        }

        private void btnViewSubscribers_Click(object sender, EventArgs e)
        {
            ViewAllSubscribers viewAll = new ViewAllSubscribers();

            viewAll.Show();
        }
    }
}
