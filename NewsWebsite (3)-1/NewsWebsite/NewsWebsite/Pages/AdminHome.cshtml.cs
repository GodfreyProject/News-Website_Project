using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewsWebsite.Pages
{
    public class AdminHomeModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return Page();
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                return new RedirectToPageResult("index");
            }
            return new RedirectToPageResult("index");
        }
    }
}
