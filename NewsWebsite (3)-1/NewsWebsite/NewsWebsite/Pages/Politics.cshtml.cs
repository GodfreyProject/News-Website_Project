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

namespace NewsWebsite.Pages
{
    public class PoliticsModel : PageModel
    {
        NewsArticleManager articleManager = new NewsArticleManager(new NewsArticleRePository());
        //[BindProperty]

        public List<NewsArticle> articles = new List<NewsArticle>();
        public Person employee { get; set; }

        [BindProperty]

        public NewsArticle news { get; set; }


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




        public IActionResult OnGet()
        {
           
            this.articles = new List<NewsArticle>();

            this.articles = articleManager.GetAllNewsArticles();

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
         
            foreach (NewsArticle imageClass in this.articleManager.GetAllNewsArticles())
            {
                if (imageClass.NewsType == "POLITICS")
                {
                    return new RedirectToPageResult("Politics");
                }
            }

            return new RedirectToPageResult("Index");
        }
    }

   
    
}
