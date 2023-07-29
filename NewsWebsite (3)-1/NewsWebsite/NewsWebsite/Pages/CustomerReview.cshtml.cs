using System;
using System.Collections.Generic;
using System.Data;
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
using SynthesisClassLibrary.dbClasses;
using SynthesisClassLibrary.ManagerClasses;

namespace NewsWebsite.Pages
{
    public class CustomerReviewModel : PageModel
    {
       public PersonManager personManager;

        NewsArticleManager articleManager = new NewsArticleManager(new NewsArticleRePository());
        [BindProperty]

        Review  Review { get; set; }
        //[BindProperty]
        //Customer customer { get; set; }
        public List<NewsArticle> newsArticles = new List<NewsArticle>();

        [BindProperty]
      public  NewsArticle article { get; set; }

        [BindProperty]

        public String Username { get; set; }

        [BindProperty]

        public int PersonID { get; set; }

        [BindProperty]

        public int  NewsID { get; set; } 


        [BindProperty]

        public String NewsType { get; set; }

        [BindProperty]

        public String Message { get; set; }


        [BindProperty]

        public String Date { get; set; }


        [BindProperty]

        public String Search { get; set; }

        public String Msg { get; set; }

        public List<NewsArticle> News = new List<NewsArticle>();
        public CustomerReviewModel()
        {
            //ds = new DatabaseSelector(DatabaseType.Cloud);
            this.personManager = new PersonManager(new PersonRePository());
            this.newsArticles = articleManager.GetAllNewsArticles();
            this.article = articleManager.SearchContent(Search);
            NewsID = article.NewsID;
            NewsType = article.NewsType;
        }
        [BindProperty]
        public Person customer { get; set; }




        public IActionResult OnGet()
        {
            //article = articleManager.GetArticle(Convert.ToInt32("UserID"));
            this.News = articleManager.GetAllNewsArticles();

            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return new RedirectToPageResult("index");
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                //Login Login = new Login( new EmailManager());

                customer = new Customer();

                customer = personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

                return Page();
            }
            return new RedirectToPageResult("index");
        }

        public IActionResult OnGetContent()
        {
            //NewsArticleManager articleManager = new NewsArticleManager(new NewsArticleRePository());

            //NewsArticle news = new NewsArticle();

            //news = articleManager.SearchNewsArticle(Search);

            //NewsID = news.NewsID;
            //NewsType = news.NewsType;

            return new RedirectToPageResult("CustomerReview");
        }

        public IActionResult OnPost()
        {
            ReviewManager reviewManager = new ReviewManager(new ReviewRePository());
            //ds = new DatabaseSelector(DatabaseType.Cloud);
            customer = new Customer();
            article = new NewsArticle();
            
           customer =  personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

            if (reviewManager.AddNewReview(customer.ID, customer.Username,NewsID, NewsType, Message, Date))
                {
                    Msg = "Customer Review has been Created";

                    ViewData["Message"] = Message;

                    return new RedirectToPageResult("CustomerReview");
                }

          else  if (String.IsNullOrEmpty(PersonID.ToString()) || String.IsNullOrEmpty(Username) || String.IsNullOrEmpty(NewsID.ToString()) || String.IsNullOrEmpty(NewsType) || String.IsNullOrEmpty(Message) || String.IsNullOrEmpty(Date))
            {
                Msg = "Fill All Input Boxes with their Characters";
                ViewData["Message"] = Message;
            }
            else
            {
                Msg = "ERRORS";
                ViewData["Message"] = Message;
            }

            return Page();
        }

        public void SearchArticle()
        {
            NewsArticleManager articleManager = new NewsArticleManager(new NewsArticleRePository());
            List<NewsArticle> reviews = new List<NewsArticle>();

            reviews.Clear();

            foreach (NewsArticle news in articleManager.GetAllNewsArticles())
            {
                if (news == articleManager.SearchContent(Search))
                {
                    NewsID = news.NewsID;
                    NewsType = news.NewsType;

                   
                }
                else
                {
                    Msg = "ERRORS";
                    ViewData["Message"] = Message;
                }
            }

           

        }
         
    }
    
}

