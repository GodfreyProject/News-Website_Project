using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using News_ClassLibrary.Business.Logic.Classes;
//using News_ClassLibrary.DBClasses;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.dbClasses;
using SynthesisClassLibrary.ManagerClasses;
//using WAD_ASSIGNMENT.Model;

namespace WAD_ASSIGNMENT.Pages
{
    public class SportModel : PageModel
    {
        public NewsArticleManager newsArticleManager;

        public List<NewsArticle> articles = new List<NewsArticle>();
        public Person employee { get; set; }

        [BindProperty]

        public String NewsType { get; set; }

        [BindProperty]

        public NewsArticle news { get; set; }

        public SportModel()
        {
            this.newsArticleManager = new NewsArticleManager(new NewsArticleRePository());

           
        }

        public IActionResult OnGetPosition()
        {
            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return new RedirectToPageResult("index");
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
               // Login Login = new Login(new PersonManager(new dbPersonManager()), new EmailManager());

                //employee = new Customer();

                //employee = Login.personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

                return Page();
            }
            return new RedirectToPageResult("index");
        }
          
        
        public NewsArticle GetNewsType()
        {
           return  newsArticleManager.GetNewsType(NewsType);
        }

        public IActionResult  OnGet(String Type)
        {
           // ds = new DatabaseSelector(DatabaseType.Cloud);
            this.articles = new List<NewsArticle>();

           news =  newsArticleManager.GetNewsType(Type);
            //NewsType = news.NewsType;
            this.articles = newsArticleManager.GetAllNewsArticles();

           

            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return new RedirectToPageResult("AccessDenied");
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                return Page();
            }
            return new RedirectToPageResult("AccessDenied");
        }

        public IActionResult OnPostSport()
        {
            //ds = new DatabaseSelector(DatabaseType.Cloud);
            foreach (NewsArticle imageClass in this.newsArticleManager.GetAllNewsArticles())
            {
                if (imageClass.NewsType == "SPORT")
                {
                    return new RedirectToPageResult("Sport");
                }
            }

            return new RedirectToPageResult("AccessDenied");
        }
    }
    

}
