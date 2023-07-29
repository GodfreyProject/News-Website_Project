using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.ManagerClasses;

namespace NewsWebsite.Pages
{
    public class PersonInformationsModel : PageModel
    {
       public List<Person> GetPeople;

        PersonManager personManager;

        public PersonInformationsModel()
        {
            this.personManager = new PersonManager(new PersonRePository());
        }
        public IActionResult OnGet()
        {
            this.GetPeople = personManager.GetAllPeople();


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
