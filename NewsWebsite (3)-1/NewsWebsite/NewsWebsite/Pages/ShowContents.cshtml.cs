using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using News_ClassLibrary.DBClasses;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;

namespace NewsWebsite.Pages
{
    public class ShowContentsModel : PageModel
    {

        private NewsArticleManager articleManager;
        public List<NewsArticle> ShowGames;

        [BindProperty]
        public NewsArticle Game { get; set; }

        public string  Message { get; set; }

        [BindProperty]
        public String NewsType { get; set; }

        [BindProperty]
        public int NewsID { get; set; }
        [BindProperty]
        public String Title { get; set; }


        [BindProperty]
        public String Description { get; set; }

        [BindProperty]
        public String Img { get; set; }

        [BindProperty]
        public String Author { get; set; }


        [BindProperty]
        public String Date { get; set; }

        public ShowContentsModel()
        {
            this.articleManager = new NewsArticleManager(new NewsArticleRePository());
            ShowGames = articleManager.GetAllNewsArticles();
        }
        public IActionResult  OnGet()
        {
            //this.ds = new DatabaseSelector(DatabaseType.Cloud);
            ShowGames = articleManager.GetAllNewsArticles();

            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                // return new RedirectToPageResult("ShowContents");

                return Page();

                //if (HttpContext.Session.GetString("ID") != null)
                //{
                //    NewsID = (int)HttpContext.Session.GetInt32("ID");
                //    NewsType = HttpContext.Session.GetString("News");
                //    Img = HttpContext.Session.GetString("Img");
                //    Title = HttpContext.Session.GetString("Tit");
                //    Description = HttpContext.Session.GetString("Descr");
                //    Author = HttpContext.Session.GetString("Auth");
                //    Date = HttpContext.Session.GetString("Dt");
                //}

            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                return new RedirectToPageResult("Index");
            }

            return new RedirectToPageResult("Index");
            //return Page();
        }

        public IActionResult OnPostUpdate(int ID)   
        { 
           try
                {
                    if (String.IsNullOrEmpty(ID.ToString()))
                    {
                        Message = "pls Enter the NewsId";
                        ViewData["Message"] = Message;
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(Game.NewsType))
                        {
                            Message = "pls Enter the NewsType";
                            ViewData["Message"] = Message;
                        }
                        else
                        {
                    if (String.IsNullOrEmpty(Img))
                     {
                     Message = "pls Enter the images";
                   ViewData["Message"] = Message;
                         }
                      else
                     {
                  if (String.IsNullOrEmpty(Title))
                 {
            Message = "pls Enter the Title";
            ViewData["Message"] = Message;
             }
             else
          {
            if (String.IsNullOrEmpty(Description))
            {
                Message = "pls Enter the News Description";
                ViewData["Message"] = Message;
            }
            else
            {
                if (String.IsNullOrEmpty(Author))
                {
                    Message = "pls Enter the Author";
                    ViewData["Message"] = Message;
                }
                else
                {
                    if (String.IsNullOrEmpty(Date))
                    {
                        Message = "pls Enter the Date";
                        ViewData["Message"] = Message;
                    }
                    else
                    {
                        if (articleManager.UpdateContent(NewsType, Img, Title,Description, Author, Date, NewsID))
                        {
                            Message = "News Content has been Updated";
                            ViewData["Message"] = Message;

                     // return new RedirectToPageResult("ShowContents");
                     }
                        
                    }
                }
            }
        }
    }
}
                    }

                }
                catch (Exception)
            {
             Message = "pls Fill the Input boxes with their Characters";
            }
        return Page();
            }

            //public IActionResult OnPostAync(int ID)
            //{
            //    String Updates = DBQUERY.UPDATE_CONTENT;
            //    using(MySqlConnection conn = DBQUERY.GetConnection())
            //    {
            //        using(MySqlCommand  cmd  = new MySqlCommand(Updates, conn))
            //        {
            //            conn.Open();


            //            cmd.Parameters.AddWithValue("@ntype", DisplayRecords.NewsType);
            //            cmd.Parameters.AddWithValue("@id", ID);


            //            cmd.ExecuteNonQuery();
            //           // conn.Close();
            //        }
            //    }

            //    return RedirectToPage("Admin");
            //}

            //public IActionResult OnPostAsync(int id)
            //{
            //    using (MySqlConnection conn = DBQUERY.GetConnection())
            //    {
            //        String UpdateData = "UPDATE contents SET newsType='" + this.DisplayRecords.NewsType + "' WHERE articleId=" + id;

            //        using (MySqlCommand cmd = new MySqlCommand(UpdateData, conn))
            //        {
            //            conn.Open();
            //            cmd.ExecuteNonQuery();
            //            conn.Close();
            //        }
            //    }

            //    return RedirectToPage("Admin");
            //}

        //public IActionResult OnGetRole()
        //{
        //    if (HttpContext.Session.GetString("UserPosition") == "Admin")
        //    {
        //        return Page();
        //    }
        //    else if (HttpContext.Session.GetString("UserPosition") == "Customer")
        //    {
        //        return new RedirectToPageResult("Index");
        //    }
        //    return Page();
        //}
    }
}
