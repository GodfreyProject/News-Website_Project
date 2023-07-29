using ClassLibrary.Class;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
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
    public partial class ShowAllContents : Form
    {
        NewsArticleManager articleManager;
        public ShowAllContents()
        {
            InitializeComponent();

            //ds = new DatabaseSelector(DatabaseType.Cloud);

            this.articleManager = new NewsArticleManager(new NewsArticleRePository());

            ShowAll();
        }


        public void ShowAll()
        {
            dgvContents.Rows.Clear();

            dgvContents.DataSource = articleManager.GetAllNewsContents();

            dgvContents.RowTemplate.Height = 60;
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)dgvContents.Columns[3];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvContents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvContents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvContents.Rows[e.RowIndex];

                if (row.Cells["NewsType"].Value.ToString() != "")
                {
                    try
                    {
                        
                        NewsArticle news = new NewsArticle(
                        Convert.ToInt32(row.Cells["NewsID"].Value),
                        row.Cells["NewsType"].Value.ToString(),
                        row.Cells["Photo"].Value.ToString(),
                        row.Cells["Title"].Value.ToString(),
                        row.Cells["Description"].Value.ToString(),
                        row.Cells["Author"].Value.ToString(),
                        (row.Cells["Date"].Value.ToString())
                        );

                        //NewsInformation item = new NewsInformation(news);
                        //item.Show();
                    }
                    catch { MessageBox.Show("Error, News Content information is incomplete."); }
                }
            }
        }

    }

}