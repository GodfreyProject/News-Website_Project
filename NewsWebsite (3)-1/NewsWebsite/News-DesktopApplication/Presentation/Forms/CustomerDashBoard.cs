//using News_ClassLibrary.CustomerInterface;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Logic.Classes;
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
    public partial class CustomerDashBoard : Form
    {
        PersonManager  control;
        Customer c;
        NewsArticle n;
        Review r;
        Customer customer = new Customer();
        public CustomerDashBoard(Customer customer,  PersonManager customerControl)
        {
            InitializeComponent();

            c = customer;

            control = customerControl;
            r = new Review();

            Detail();
        
            }

        public void Detail()
        {
            lbCustomerFirstName.Text = $"Welcomr Customer:{c.Username}";
        }
        //private void customerProfileToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    CustomerProfile customerProfile = new CustomerProfile(c);

        //    customerProfile.Show();
        //}

        //private void aLLNewsArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ShowAllContents showAllContents = new ShowAllContents();
        //    showAllContents.Show();

        //    //Close();

            
        //}

        //private void addCommentsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //Customer person = new Customer();
           
        //    AddComment addComment = new AddComment(c);

        //    addComment.Show();

        //    //Close();
        //}

        //private void personalCommentsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Review review = new Review();
        //    Person person = new Person();
        //    AllComments allComments = new AllComments(c);
        //    allComments.Show();

        //   // Close();
        //}

        //private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ChangePassword change = new ChangePassword(c);

        //    change.Show();

        //    //Close();
        //}

        //private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ContactForm contactForm = new ContactForm(c);

        //    contactForm.Show();

        //    //Close();
        //}

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login(r);
            login.Show();

            this.Hide();
        }

        private void btnCustomerProfile_Click(object sender, EventArgs e)
        {
            CustomerProfile customerProfile = new CustomerProfile(c);

            customerProfile.Show();
        }

        private void btnSearchContents_Click(object sender, EventArgs e)
        {
            CustomerSearchContents customerSearch = new CustomerSearchContents(c);

            customerSearch.Show();
        }

        private void btnShowAllContents_Click(object sender, EventArgs e)
        {
            ShowAllContents showAllContents = new ShowAllContents();
            showAllContents.Show();

        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            AddComment addComment = new AddComment(c);

            addComment.Show();
        }

        private void btnViewCommentAndManage_Click(object sender, EventArgs e)
        {
            AllComments allComments = new AllComments(c);
            allComments.Show();

        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(c);

            change.Show();

        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm(c);

            contactForm.Show();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            CustomerSubscribe customerSubscribe = new CustomerSubscribe(c);

            customerSubscribe.Show();
        }
    }
}
