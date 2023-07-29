using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.ManagerClasses;

namespace NewsWebsite.Pages
{
    public class DeleteModel : PageModel
    {

        [BindProperty]
        public NewsArticle DisplayRecords { get; set; }

        NewsArticleManager articleManager;
        public List<NewsArticle> articles = new List<NewsArticle>();

        [BindProperty]
        public Person admin { get; set; }
        public DeleteModel()
        {
            articleManager = new NewsArticleManager(new NewsArticleRePository());
        }

        [BindProperty]
        public IFormFile Upload { get; set; }
        public String Message { get; set; }

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

     
        //public void OnGet(int ID)
        //{
        //    NewsArticle news = articleManager.GetArticle(ID);

        //    NewsID = news.NewsID;
        //    NewsType = news.NewsType;
        //    Img = news.Img;
        //    Title = news.Title;
        //    Description = news.Description;
        //    Author = news.Author;
        //    Date = news.Date;

        //    // return Page();
        //}
        public IActionResult OnGet(int ID)
        {
            this.articles = articleManager.GetAllNewsArticles();

            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                NewsArticle news = articleManager.GetArticle(ID);

                NewsID = news.NewsID;
                NewsType = news.NewsType;
                Img = news.Img;
                Title = news.Title;
                Description = news.Description;
                Author = news.Author;
                Date = news.Date;
                return Page();
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                //Login Login = new Login( new EmailManager());
                PersonManager personManager = new PersonManager(new PersonRePository());

                admin = new Admin();

                admin = personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

                return new RedirectToPageResult("index");

            }


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
            //NewsArticle news = new NewsArticle();




            // return Page();

            //await Upload.CopyToAsync(fileStream);
            //}

            return new RedirectToPageResult("AccessDenied");
        }
        public IActionResult OnPost()
        {
            try
            {
                if (String.IsNullOrEmpty(NewsID.ToString()))
                {
                    Message = "the News ID Content can not Empty";
                    ViewData["Message"] = Message;
                }
                else
                {
                    if (articleManager.DeleteContent(NewsID))
                    {
                        Message = "Your Content with that News Id Has been Deleted Successfully";

                        ViewData["Message"] = Message;

                        return new RedirectToPageResult("Delete");
                    }
                }
            }catch(Exception)
            {
                Message = "Something went Wrong";
                ViewData["Message"] = Message;
            }
            return Page();
        }
    }
}
