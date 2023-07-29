using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewsWebsite.Pages
{
    public class CustomerHomeModel : PageModel
    {
       

        public IActionResult OnGet()
        {
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
    }
}
