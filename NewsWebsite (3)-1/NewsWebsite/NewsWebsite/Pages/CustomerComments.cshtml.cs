using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;

namespace NewsWebsite.Pages
{
    public class CustomerCommentsModel : PageModel
    {
        public List<Review> reviews;

        ReviewManager reviewManager;

        public CustomerCommentsModel()
        {
            this.reviewManager = new  ReviewManager(new ReviewRePository());
        }
        public IActionResult OnGet()
        {
           
            this.reviews = reviewManager.GetAllReviews();


            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                // return new RedirectToPageResult("ShowContents");

                return Page();



            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                return new RedirectToPageResult("Index");
            }

            return new RedirectToPageResult("Index");
        }
      
    }
}
