using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class ViewCommentsModel : PageModel
    {
        public List<Review> reviews;

        ReviewManager reviewManager;
        PersonManager personManager;
      
        public int PersonID { get; set; }

        [BindProperty]

        public int NewsID { get; set; }


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
        public ViewCommentsModel()
        {
            this.reviewManager = new ReviewManager(new ReviewRePository());

            //ds = new DatabaseSelector(DatabaseType.Cloud);
            this.personManager = new PersonManager(new PersonRePository());
            //this.newsArticles = articleManager.GetAllNewsArticles();
            //this.article = articleManager.SearchContent(Search);
            //NewsID = article.NewsID;
            //NewsType = article.NewsType;
        }
        [BindProperty]
        public Person customer { get; set; }



        public IActionResult OnGet()
        {
            this.reviews = reviewManager.GetAllReviews();
            personManager = new PersonManager(new PersonRePository());
            //this.News = new List<Review>();

            //this.News = reviewManager.GetAllReviews();

            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return new RedirectToPageResult("AccessDenied");
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                customer = new Customer();
                //article = new NewsArticle();
                //Review = new Review();
                customer = personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));
                //Review = reviewManager.GetReview(Review.ReviewID);
                //article = articleManager.GetArticle(Convert.ToInt32(HttpContext.Session.GetInt32("NewsID")));
                return Page();
            }
            return new RedirectToPageResult("AccessDenied");
        }

    
    }
}
