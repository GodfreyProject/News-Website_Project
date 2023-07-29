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
    public class BusinessModel : PageModel
    {
        NewsArticleManager articleManager = new NewsArticleManager(new NewsArticleRePository());
        //[BindProperty]
        public List<NewsArticle> News = new List<NewsArticle>();
        public IActionResult OnGet()
        {
            
            this.News = articleManager.GetAllNewsArticles();

          

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

        public IActionResult OnPostBusiness()
        {
            
            foreach (NewsArticle imageClass in this.articleManager.GetAllNewsArticles())
            {
                if (imageClass.NewsType == "BUSINESS")
                {
                    return new RedirectToPageResult("Business");
                }
            }

            return new RedirectToPageResult("Index");
        }
    }
}
