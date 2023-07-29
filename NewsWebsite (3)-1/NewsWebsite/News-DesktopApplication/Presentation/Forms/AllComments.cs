using ClassLibrary.Class;
using MySql.Data.MySqlClient;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace News_DesktopApplication.Forms
{
    public partial class AllComments : Form
    {
        ReviewManager reviewManager;
        Customer c;
      
        //Person p;
        Review view;
        NewsArticle a;
        public AllComments(Customer customer)
        {
            InitializeComponent();
            reviewManager = new ReviewManager(new ReviewRePository());
            c = customer;
           
            
          DisplayAllComments();

           
             view = new  Review(); 

            Pdetails();
        }

        public void Pdetails()
        {
            tbPersonID.Text = c.ID.ToString();
            txbFirstName.Text = c.Username;
        }
        public void review()
        {
            Review r = new Review();
                      //int ReviwId = Convert.ToInt32(r.ReviewID);

             r = reviewManager.GetWebReview(r.ReviewID);

           txbComId.Text = r.ReviewID.ToString(); //r.ReviewID.ToString();
            tbPersonID.Text = c.ID.ToString();
            txbFirstName.Text = c.Username;
            tbxNewsID.Text = r.NewsID.ToString();
            cboxNewsType.Text = r.NewsType;
            tbxMessage.Text = r.Message;

            dateText.Text = r.Date;
        }
       
      
        public void DisplayAllComments()
        {
            try
            {
                  string Username = txbFirstName.Text;
                    //Review r = new Review();
                    Review view = new Review();
                  //r = reviewManager.GetReview(r.ReviewID);
                foreach (Review r in reviewManager.GetReview(c.Username))
                  {
                    if (r.Username == c.Username)
                    {

                        dgvComments.DataSource = reviewManager.GetReview(c.Username);
                    }
                    else
                    {
                        MessageBox.Show("Sorry, you dont Have Comments Yet for any News Contants");
                    }

                }
                    
                  
                
            }
            catch (Exception exp)
            {
                MessageBox.Show("Can not be Empty", exp.Message);
            }

        }
       
       private void RefreshDataGridview()
        {
            dgvComments.DataSource = reviewManager.GetReview(c.Username);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AllComments_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateReview_Click(object sender, EventArgs e)
        {
            try
            {
                int CommentId = Convert.ToInt32(txbComId.Text);
                int PersonID = Convert.ToInt32(tbPersonID.Text);
                String Username = txbFirstName.Text;
                //int NewsId = Convert.ToInt32(tboxNewId.Text);
                 String Type = cboxNewsType.Text;
                NewsArticle news = new NewsArticle();
                news.NewsType = cboxNewsType.Text;
                news.NewsID = Convert.ToInt32(tbxNewsID.Text);
                String Message = tbxMessage.Text;
                String Date = dateText.Value.ToShortDateString();

                if (String.IsNullOrEmpty(CommentId.ToString()))
                {
                    MessageBox.Show("Pls, Enter CommentID");
                }
                else
                {
                    if (String.IsNullOrEmpty(PersonID.ToString()))
                    {
                        MessageBox.Show("Pls, Enter Customer Id");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(Username))
                        {
                            MessageBox.Show("Username is required");
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(news.NewsType))
                            {
                                MessageBox.Show("Newstype is Required");
                            }
                            else
                            {
                                if (String.IsNullOrEmpty(Message))
                                {
                                    MessageBox.Show("Pls, Enter your Message");
                                }
                                else
                                {
                                    if (String.IsNullOrEmpty(Date))
                                    {
                                        MessageBox.Show("Pls, Enter the Date");
                                    }
                                    else
                                    {
                                        if (reviewManager.UpdateReview(c, news, Message, Date,CommentId))
                                        {
                                            MessageBox.Show("Updated Successfully");
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
                MessageBox.Show("please, Fill text boxes with their Characters");
            }
        }

        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txbComId.Text);

                if (String.IsNullOrEmpty(ID.ToString()))
                {
                    MessageBox.Show("Username is Required");
                }
                else
                {
                    if (reviewManager.RemoveReview(ID))
                    {
                        MessageBox.Show("Deleted Successfully");
                    }
                }
            }
            catch
            {
                MessageBox.Show("please, Fill text boxes with their Characters");
            }
        }

       

        private void dgvComments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbComId.Text = dgvComments.CurrentRow.Cells[0].Value.ToString(); //r.ReviewID.ToString();
            tbPersonID.Text = dgvComments.CurrentRow.Cells[1].Value.ToString();
            txbFirstName.Text = dgvComments.CurrentRow.Cells[2].Value.ToString();
            tbxNewsID.Text = dgvComments.CurrentRow.Cells[3].Value.ToString();
            cboxNewsType.Text = dgvComments.CurrentRow.Cells[4].Value.ToString();
            tbxMessage.Text = dgvComments.CurrentRow.Cells[5].Value.ToString();

            dateText.Text = dgvComments.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnShowAllContants_Click(object sender, EventArgs e)
        {
            this.RefreshDataGridview();
        }
    }
}

