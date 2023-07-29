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

namespace News_DesktopApplication.Presentation.Forms
{
    public partial class CustomerSearchContents : Form
    {
        NewsArticleManager articleManager;
        Customer person;
        public CustomerSearchContents(Customer person)
        {
            InitializeComponent();
            this.person = person;
            this.articleManager = new NewsArticleManager(new NewsArticleRePository());
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txbSearchNews_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Image img = picImage.Image;
                //byte[] arry;
                String KeyWords = txbSearchNews.Text;

                if (KeyWords == "")
                {
                    txbNewsId.Text = "";
                    cbbNewsType.Text = "";
                    //img = (byte[])news.Photo;
                    //MemoryStream ms = new MemoryStream(img);
                    txbTitle.Text = "";
                    txbDescr.Text = "";
                    txbAuthor.Text = "";
                    dateText.Text = "";

                    return;
                }
                NewsArticle news = new NewsArticle();
                news = articleManager.SearchNewsArticle(KeyWords);

                txbNewsId.Text = news.NewsID.ToString();
                cbbNewsType.Text = news.NewsType;
                byte[] img = (byte[])news.Photo;//dgvAllContents.CurrentRow.Cells[3].Value;
                MemoryStream ms = new MemoryStream(img);
                picImage.Image = Image.FromStream(ms);
                txbTitle.Text = news.Title;
                txbDescr.Text = news.Description;
                txbAuthor.Text = news.Author;
                dateText.Text = news.Date;


                //picImage.Image..Height = 60;
                //DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
                ////imgcol = (DataGridViewImageColumn)dgvContents.Columns[3];
                //imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                //picImage.Image = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("News Content Data Doesnt Exist");
            }
        }
    }
    
}
