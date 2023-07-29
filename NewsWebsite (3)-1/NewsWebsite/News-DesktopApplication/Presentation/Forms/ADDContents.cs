using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using ClassLibrary.Class;
using News_ClassLibrary.Persistence;

namespace News_DesktopApplication.Forms
{
    public partial class ADDContents : Form
    {
        NewsArticleManager articleManager;
        NewsArticle news;
        public ADDContents(NewsArticle newsArticle)
        {
            InitializeComponent();

            //ds = new DatabaseSelector(DatabaseType.Cloud);
            articleManager = new NewsArticleManager(new NewsArticleRePository());
            news = newsArticle;
            ShowAll();
            //Display();
        }


        public void ShowAll()
        {
            //dgvAllContents.Rows.Clear();

            dgvAllContents.DataSource = articleManager.GetAllNewsContents();

            dgvAllContents.RowTemplate.Height = 60;
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)dgvAllContents.Columns[3];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvAllContents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddContent_Click(object sender, EventArgs e)
        {
            try
            {

                String NewsType = cbbNewsType.Text;
                MemoryStream ms = new MemoryStream();
                picImage.Image.Save(ms, picImage.Image.RawFormat);
                byte[] Img = ms.ToArray();
                String Title = txbTitle.Text;

                String Description = txbDescription.Text;

                String Author = txbAuthor.Text;

                String Date = dateText.Text;
                NewsArticle SelectedContent = articleManager.GetArticle(Title);

                //File.Copy(ImageText.Text, Application.StartupPath + @"\Image\" + Path.GetFileName(picImage.ImageLocation));

                if (String.IsNullOrEmpty(NewsType)  || string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(Author) || String.IsNullOrEmpty(Date))
                {
                    MessageBox.Show("Please Inputs All Fields with their Required Characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                else if(Img == null)
                {
                    MessageBox.Show("News Images can not be Empty");
                    return;
                }

                
                else if(SelectedContent != null)
                {
                    MessageBox.Show("News content with that Title Already Exist", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              
                  else  if(this.articleManager.AddNewsContent(NewsType, Img, Title, Description, Author, Date))
                    {
                        MessageBox.Show("News Content has been Created SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                        ShowAll();
                        ClearList();
                    }

                else
                {
                    MessageBox.Show("Something went wrong");
                }
                
            }
            catch(Exception exp)
            {
                MessageBox.Show("Somthing has gone Wrong", exp.Message);
            }

        }

        private void ClearList()
        {
            cbbNewsType.Text ="";
            txbTitle.Text = "";
            txbDescription.Text = "";
            txbAuthor.Text = "";
            dateText.Text = "";
            txbNewsID.Text = "";
        }
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "choose Image(*.JPG;*.PNG;*.GIF) | *.jpg;*.png;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAllContents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txbNewsID.Text = dgvAllContents.CurrentRow.Cells[0].Value.ToString();
            cbbNewsType.Text = dgvAllContents.CurrentRow.Cells[1].Value.ToString();
            Byte[] img= (byte[])dgvAllContents.CurrentRow.Cells[3].Value;
            MemoryStream ms = new MemoryStream(img);
            picImage.Image = Image.FromStream(ms);
            txbTitle.Text = dgvAllContents.CurrentRow.Cells[4].Value.ToString();
            txbDescription.Text = dgvAllContents.CurrentRow.Cells[5].Value.ToString();
            txbAuthor.Text = dgvAllContents.CurrentRow.Cells[6].Value.ToString();
            dateText.Text = dgvAllContents.CurrentRow.Cells[7].Value.ToString();


        }

        private void btnUpdateContent_Click(object sender, EventArgs e)
        {
            try
            {
                int NewId = Convert.ToInt32(txbNewsID.Text);
                String NewsType = cbbNewsType.SelectedItem.ToString();
                MemoryStream ms = new MemoryStream();
                picImage.Image.Save(ms, picImage.Image.RawFormat);
                byte[] Img = ms.ToArray();
                String Title = txbTitle.Text;

                String Description = txbDescription.Text;

                String Author = txbAuthor.Text;

                String Date = dateText.Text;

                //File.Copy(ImageText.Text, Application.StartupPath + @"\Image\" + Path.GetFileName(picImage.ImageLocation));

                if (String.IsNullOrEmpty(NewsType)  || string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Description)|| string.IsNullOrEmpty(Author) || String.IsNullOrEmpty(Date))
                {
                    MessageBox.Show("Please Inputs All Fields with their Required Characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (Img == null)
                {
                    MessageBox.Show("News Images can not be Empty");
                    return;
                }
              else  if(this.articleManager.UpdateNewsContent(NewsType, Img, Title, Description, Author, Date, NewId))
                    {
                        MessageBox.Show("News Content has been Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowAll();
                    ClearList();
                }
                
            }
            catch(Exception EXP)
            {
                MessageBox.Show("Pls Fill All Text boxes with their Characters", EXP.Message);
            }
        }

        private void btnDeleteContent_Click(object sender, EventArgs e)
        {
            try
            {
                int NewsID = Convert.ToInt32(txbNewsID.Text);

                if (String.IsNullOrEmpty(NewsID.ToString()))
                {
                    MessageBox.Show("Pls Enter the NewsId");
                }
                else
                {
                    if (articleManager.RemoveContent(NewsID))
                    {
                        MessageBox.Show("Content Removed Completely");
                    }
                    else
                    {
                        MessageBox.Show("Somthing went wrong");
                    }
                }

            }
            catch
            {
                MessageBox.Show("Pls Fill the NewId");
            }


        }

        private void txbDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
