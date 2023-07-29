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
    public class RemoveReviewsModel : PageModel
    {
        public ReviewManager ReviewManager = new ReviewManager(new ReviewRePository());

        public NewsArticleManager articleManager = new NewsArticleManager(new NewsArticleRePository());

        [BindProperty]

        public NewsArticle news { get; set; }
        [BindProperty]

        public Review review { get; set; }

        [BindProperty]

        public int ReviewID { get; set; }

        [BindProperty]

        public Person customer { get; set; }

        public String Message;
        //public void OnGet()
        //{
        //}
        public IActionResult OnGet(int ID)
        {
            //this.News = ReviewManager.GetAllReviews();

            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return new RedirectToPageResult("index");
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {

                //news = articleManager.GetArticle(ID);

                //ID = news.NewsID;
                //NewsType = news.NewsType;
                //Login Login = new Login( new EmailManager());
                PersonManager personManager = new PersonManager(new PersonRePository());
                customer = new Customer();

                review = new Review();
                review = ReviewManager.GetWebReview(ID);
               
                customer = personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));


                return Page();
            }
            return new RedirectToPageResult("AccessDenied");


        }

        public IActionResult OnPost(int ID)
        {
            try
            {
                if (String.IsNullOrEmpty(ID.ToString()))
                {
                    Message = "the News ID Content can not Empty";
                    ViewData["Message"] = Message;
                }
                else
                {
                    if (ReviewManager.RemoveNewReview(ID))
                    {
                        Message = "Your Content with that News Id Has been Deleted Successfully";

                        ViewData["Message"] = Message;

                        return new RedirectToPageResult("RemoveReviews");
                    }
                }
            }
            catch (Exception)
            {
                Message = "Something went Wrong";
                ViewData["Message"] = Message;
            }
            return Page();
        }
    }
}
