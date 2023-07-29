using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Class;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using News_ClassLibrary.Business.Logic.Classes;
///using News_ClassLibrary.DBClasses;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.ManagerClasses;
//using WAD_ASSIGNMENT.Model;

namespace WAD_ASSIGNMENT.Pages
{
    public class EditModel : PageModel
    {
        //[BindProperty]
        //public NewsArticle DisplayRecords { get; set; }

     

        private IHostingEnvironment _environment;
        NewsArticleManager articleManager;
        public EditModel(IHostingEnvironment environment)
        {
            _environment = environment;

            //  ds = new DatabaseSelector(DatabaseType.Cloud);
            articleManager = new NewsArticleManager(new NewsArticleRePository());

            articles = articleManager.GetAllNewsArticles();
        }

        [BindProperty]
        public NewsArticle news { get; set; }

        [BindProperty]
        public IFormFile Upload { get; set; }
        public String Message { get; set; }

        public List<NewsArticle> articles = new List<NewsArticle>();

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

        [BindProperty]
        public Person customer { get; set; }

        
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
               
                customer = new Customer();

                customer = personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

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
        public void OnGetDetail(int ID)
        {
            NewsArticle news = articleManager.GetArticle(ID);

            NewsID = news.NewsID;
            NewsType = news.NewsType;
            Img = news.Img;
            Title = news.Title;
            Description = news.Description;
            Author = news.Author;
            Date = news.Date;

            // return Page();
        }

        public async Task OnPost(int ID)
        {
            //if (String.IsNullOrEmpty(NewsType) || String.IsNullOrEmpty(Img) || String.IsNullOrEmpty(Title) || String.IsNullOrEmpty(Description) || String.IsNullOrEmpty(Author) || String.IsNullOrEmpty(Date))
            //{
            //    Message = "All Fields are required";

            //    ViewData["Message"] = Message;
            //}
            //else
            //{

                var file = Path.Combine(_environment.ContentRootPath, @"wwwroot\photo", Upload.FileName);
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    Img = Upload.FileName;
                    NewsArticleManager gameDB = new NewsArticleManager(new NewsArticleRePository());
                    gameDB.UpdateContent(NewsType, Img, Title, Description, Author, Date, ID);
                    await Upload.CopyToAsync(fileStream);
                    Img = Upload.FileName;

                    Message = "Content Updated";
               
                    ViewData["Message"] = Message;

                }

            //}

        }
            //public IActionResult OnGet()
            //{

            //    if (HttpContext.Session.GetString("UserPosition") == "Admin")
            //    {
            //        return Page();
            //    }
            //    else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            //    {
            //        return new RedirectToPageResult("index");
            //        //return Page();
            //    }
            //    return new RedirectToPageResult("index");
            //    //if (HttpContext.Session.GetString("UserPosition") == "Admin")
            //    //{
            //    //    return Page();
            //    //}
            //    //else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            //    //{
            //    //    return new RedirectToPageResult("Index");
            //    //}
            //    //return Page();
            //}
            // return new RedirectToPageResult("Edit");
        }
    }




