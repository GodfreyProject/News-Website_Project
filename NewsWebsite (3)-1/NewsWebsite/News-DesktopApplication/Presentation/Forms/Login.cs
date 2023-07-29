using ClassLibrary.Class;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using PersonManagerTest.Business;
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
    public partial class Login : Form
    {
        ReviewManager reviewManager;
        PersonManager personManager;
        //NewsArticle article;
        //Person c;
        Review r;
        public Login(Review review)
        {
            InitializeComponent();

            reviewManager = new ReviewManager(new ReviewRePository());

            this.personManager = new PersonManager(new PersonRePository());

            r = review;

            Getreview();
            //article = new NewsArticle();
            // LoginCusomerDetails();
        }
        public void Getreview()
        {
            //Review r = new Review();
            //int ReviwId = Convert.ToInt32(r.ReviewID);

            r = reviewManager.GetWebReview(r.ReviewID);

           
        }

       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                Person p = this.personManager.GetPerson(username, password);
              

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Enter your Username!");
                }
               else if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Enter your Password!");
                }

                else if (p is Admin)
                {
                    AdminDashBoard adminForm = new AdminDashBoard((Admin)personManager.GetPersonBYUsername(p.Username), personManager);
                    adminForm.Show();

                    this.Hide();
                }
                else if(p is Customer)
                {
                    CustomerDashBoard customerBoard = new CustomerDashBoard((Customer)personManager.GetPersonBYUsername(p.Username), personManager);
                    customerBoard.Show();

                    this.Hide();
                }

               
                else
                {
                    MessageBox.Show("Sorry !, Invalid Credentials Provided, not Found in the Database, Try Again");
                }
                //        else
                //        {
                //            foreach (Person p in personManager.GetAllPeople())
                //            {
                //                if (p is Admin)
                //                {
                //                    if (p.Username == username && p.Password == password)
                //                    {
                //                        AdminDashBoard adminForm = new AdminDashBoard((Admin)personManager.GetPersonBYUsername(p.Username), personManager);
                //                        adminForm.Show();

                //                        this.Hide();
                //                    }
                //                }
                //                else if (p is Customer)
                //                {
                //                    if (p.Username == username && p.Password == password)
                //                    {
                //                       // Review review = new Review();
                //                        CustomerDashBoard customer = new CustomerDashBoard((Customer)personManager.GetPersonBYUsername(p.Username), personManager);
                //                        customer.Show();

                //                        this.Hide();
                //                    }
                //                }
                //            }
                //        }
                //    }


            }
            catch (LoginException)
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CustomerSignUp signUp = new CustomerSignUp();

            signUp.Show();

            this.Hide();
        }
    }
}
