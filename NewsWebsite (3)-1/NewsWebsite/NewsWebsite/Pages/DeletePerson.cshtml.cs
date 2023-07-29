using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.ManagerClasses;

namespace NewsWebsite.Pages
{
    public class DeletePersonModel : PageModel
    {
        [BindProperty]
        public Person DisplayRecords { get; set; }

        PersonManager  personManager;

        public String Message { get; set; }

        [BindProperty]
        public int PersonID  { get; set; }

        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public String LastName { get; set; }


        [BindProperty]
        public String Username { get; set; }

        [BindProperty]
        public String Email { get; set; }
        [BindProperty]
        public String Password { get; set; }

        [BindProperty]
        public String Role { get; set; }


        [BindProperty]
        public String Date { get; set; }

        public DeletePersonModel()
        {
            personManager = new PersonManager(new PersonRePository());
        }

    
        public IActionResult OnGet(int ID)
        {
            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                DisplayRecords = new Admin();

                DisplayRecords = personManager.GetPerson(ID);//(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

                return Page();
                
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                
                return new RedirectToPageResult("AccessDenied");
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
                    if (personManager.DeletePerson(ID))
                    {
                        Message = "Your Content with that News Id Has been Deleted Successfully";

                        ViewData["Message"] = Message;

                        return new RedirectToPageResult("DeletePerson");
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
