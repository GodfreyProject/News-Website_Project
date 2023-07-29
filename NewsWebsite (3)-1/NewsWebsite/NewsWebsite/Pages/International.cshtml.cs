using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;

namespace NewsWebsite.Pages
{
    public class InternationalModel : PageModel
    {
       
        //[BindProperty]
        public List<NewsArticle> News = new List<NewsArticle>();
        NewsArticleManager articleManager = new NewsArticleManager(new NewsArticleRePository());
        public IActionResult OnGet()
        {
          
            this.News  =  articleManager.GetAllNewsArticles();

            //ds = new DatabaseSelector(DatabaseType.Cloud);

            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return new RedirectToPageResult("AccessDenied");
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                // Login Login = new Login(new PersonManager(new dbPersonManager()), new EmailManager());

                //employee = new Customer();

                //employee = Login.personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

                return Page();
            }
            return new RedirectToPageResult("AccessDenied");
        }

        public IActionResult OnGetPosition()
        {
            //ds = new DatabaseSelector(DatabaseType.Cloud);

            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return new RedirectToPageResult("AccessDenied");
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                // Login Login = new Login(new PersonManager(new dbPersonManager()), new EmailManager());

                //employee = new Customer();

                //employee = Login.personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

                return Page();
            }
            return new RedirectToPageResult("AccessDenied");
        }

        public IActionResult OnPostBusiness()
        {
           // ds = new DatabaseSelector(DatabaseType.Cloud);
            foreach (NewsArticle imageClass in this.articleManager.GetAllNewsArticles())
            {
                if (imageClass.NewsType == "INTERNATIONAL-NEWS" || imageClass.NewsType == "WORLD")
                {
                    return new RedirectToPageResult("International");
                }
            }

            return new RedirectToPageResult("index");
        }
    }
}


    

