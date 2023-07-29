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
    public class UpdateReviewsModel : PageModel
    {
     
        [BindProperty]

        public Review DisplayRecords { get; set; }

        [BindProperty]

        public NewsArticle news { get; set; }

        

        
        [BindProperty]
        public int PersonID { get; set; }
        public String Message { get; set; }
        public String Subject { get; set; }
        public String Username { get; set; }

        [BindProperty]
        public String NewsType { get; set; }

        [BindProperty]
        public int NewsID { get; set; }


        [BindProperty]
        public int ReviewID { get; set; }


        [BindProperty]
        public String Date { get; set; }

        [BindProperty]
        public Person customer { get; set; }

        public List<Review> News = new List<Review>();
        NewsArticleManager articleManager = new NewsArticleManager(new NewsArticleRePository());
        public ReviewManager ReviewManager = new ReviewManager(new ReviewRePository());
        PersonManager personManager = new PersonManager(new PersonRePository());
        public IActionResult OnGet(int ID)
        {
            this.News = ReviewManager.GetAllReviews() ;

            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return new RedirectToPageResult("index");
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
              
                // news = articleManager.GetArticle(ID);

                //ID = news.NewsID;
                //NewsType = news.NewsType;
                //Login Login = new Login( new EmailManager());
               
                customer = new Customer();

                DisplayRecords = new Review();
                // news = articleManager.GetArticle(NewsID);
                //NewsID = news.NewsID;
                //NewsType = news.NewsType;
                //views = ReviewManager.Review(HttpContext.Session.GetString("User"));
                DisplayRecords = ReviewManager.GetWebReview(ID);// Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));
                DisplayRecords.NewsID.ToString();
                DisplayRecords.PersonID.ToString();
                DisplayRecords.Username.ToString();
                DisplayRecords.NewsID.ToString();
                DisplayRecords.NewsType.ToString();
                DisplayRecords.Message.ToString();
                DisplayRecords.Date.ToString();
                news =  articleManager.GetArticle(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));
                //views = ReviewManager.Review(HttpContext.Session.GetString("UserID"));
                customer = personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

               
                return Page();
            }
            return new RedirectToPageResult("AccessDenied");

          
        }


        public IActionResult OnPost(int ID)
        {
            //DisplayRecords = ReviewManager.GetReview(ID);// Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));
            //DisplayRecords.NewsID.ToString();
            //DisplayRecords.PersonID.ToString();
            //DisplayRecords.Username.ToString();
            //DisplayRecords.NewsID.ToString();
            //DisplayRecords.NewsType.ToString();
            //DisplayRecords.Message.ToString();
            //DisplayRecords.Date.ToString();
            //customer = personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

            if ( String.IsNullOrEmpty(NewsType) || String.IsNullOrEmpty( Message) || String.IsNullOrEmpty( Date) || String.IsNullOrEmpty( ReviewID.ToString()))
            {
                Message = "All Fields are required";

                ViewData["Message"] = Message;
            }

            if (ReviewManager.UpdateNewReview(DisplayRecords. NewsType,DisplayRecords. Message, DisplayRecords. Date, ID))
                {
                    Message = "Update Succesfully";

                    ViewData["Message"] = Message;

                    return new RedirectToPageResult("UpdateReviews");
            }
            else
            {
                Message = "Somthing went wrong";

                ViewData["Message"] = Message;
            }
            


            return Page();

        }
        //public void OnGet()
        //{
        //}
    }
}
