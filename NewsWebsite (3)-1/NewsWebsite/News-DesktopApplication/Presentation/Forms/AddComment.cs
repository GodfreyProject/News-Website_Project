using ClassLibrary.Class;
//using News_ClassLibrary.CustomerInterface;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace News_DesktopApplication.Forms
{
    public partial class AddComment : Form
    {
        ReviewManager reviewManager;
        NewsArticleManager articleManager;

        Customer person;
      

        NewsArticle news;
        public AddComment(Customer person)
        {
            InitializeComponent();

            //ds = new DatabaseSelector(DatabaseType.Cloud);
            this.reviewManager = new ReviewManager(new ReviewRePository());
            news  = new NewsArticle();
            this.person = person;
            this.articleManager = new NewsArticleManager(new NewsArticleRePository());
         
            PersonDetail();

          //  ShowNewsDetails();

           // cmbType.SelectedIndex = 0;

            GetContents();
        }

        public void PersonDetail()
        {
            txbPersonId.Text = person.ID.ToString();
            txbFirstName.Text = person.Username;
        }

        public void ShowNewsDetails()
        {
            String KeyWords = tbSearch.Text;
           
            news = articleManager.SearchContent(KeyWords);

            CbbNewsID.Text = news.NewsID.ToString();
            cmbType.Text = news.NewsType;

        }

        private void GetContents()
        {
            cmbType.Items.Clear();
            foreach(NewsArticle newsArticle in articleManager.GetAllNewsContents())
            {
                cmbType.Items.Add(newsArticle.NewsType);
                CbbNewsID.Items.Add(newsArticle.NewsID);
            }
        }
       

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            try
            {
                int personId = Convert.ToInt32(txbPersonId.Text);
                String Username = txbFirstName.Text;
                int NEWSID = Convert.ToInt32(CbbNewsID.Text);
                String NewsType = cmbType.Text;
                String Message = txbMesg.Text;
                String Date = date.Value.ToShortDateString();

                if (String.IsNullOrEmpty(personId.ToString()))
                {
                    MessageBox.Show("Enter your PersonID");
                }
                else
                {
                    if (String.IsNullOrEmpty(NEWSID.ToString()))
                    {
                        MessageBox.Show("Enter your NewsId");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(Message))
                        {
                            MessageBox.Show("Enter your Message");
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(Date))
                            {
                                MessageBox.Show("Enter the Date");
                            }
                            else
                            {
                                if (String.IsNullOrEmpty(Username))
                                {
                                    MessageBox.Show("Enter your FirstName");
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(NewsType))
                                    {
                                        MessageBox.Show("Enter the NewsType");
                                    }
                                    else
                                    {
                                        if (reviewManager.AddReview(person, news, Message, Date))
                                        {
                                            //txbMesg.Clear();
                                            MessageBox.Show("Reviews Added");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Pls , Enter all Chatacters");
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            String KeyWords = tbSearch.Text;

            news = articleManager.SearchNewsArticle(KeyWords);

            CbbNewsID.Text = news.NewsID.ToString();
            cmbType.Text = news.NewsType;
        }
    }
}
