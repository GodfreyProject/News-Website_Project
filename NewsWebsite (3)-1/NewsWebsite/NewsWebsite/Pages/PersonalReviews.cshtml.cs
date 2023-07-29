using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;

namespace NewsWebsite.Pages
{
    public class PersonalReviewsModel : PageModel
    {
        private NewsArticleManager articleManager;
        public List<NewsArticle> ShowArticles;

        [BindProperty]
        public NewsArticle Game { get; set; }

        public string Message { get; set; }

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

        public PersonalReviewsModel()
        {
            this.articleManager = new NewsArticleManager(new NewsArticleRePository());
        }
        public IActionResult OnGet()
        {
            //this.ds = new DatabaseSelector(DatabaseType.Cloud);
            ShowArticles = articleManager.GetAllNewsArticles();

            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                // return new RedirectToPageResult("ShowContents");
                return new RedirectToPageResult("Index");
                

                if (HttpContext.Session.GetString("ID") != null)
                {
                    NewsID = (int)HttpContext.Session.GetInt32("ID");
                    NewsType = HttpContext.Session.GetString("News");
                    Img = HttpContext.Session.GetString("Img");
                    Title = HttpContext.Session.GetString("Tit");
                    Description = HttpContext.Session.GetString("Descr");
                    Author = HttpContext.Session.GetString("Auth");
                    Date = HttpContext.Session.GetString("Dt");
                }

            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                //return new RedirectToPageResult("Index");
                return Page();
            }

            return new RedirectToPageResult("Index");
            //return Page();
        }

        
    }
}
