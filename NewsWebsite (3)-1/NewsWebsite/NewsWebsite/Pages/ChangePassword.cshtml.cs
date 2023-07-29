using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class ChangePasswordModel : PageModel
    {
        [Required]
        [BindProperty]
        public String Password { get; set; }

        [Required]
        [BindProperty]
        public String RepeatedPassword { get; set; }

        [BindProperty]
        public Person customer { get; set; }

        PersonManager personManager;
        public IActionResult OnGet()
        {
            personManager = new PersonManager(new PersonRePository());
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


        public IActionResult OnPost()
        {
            personManager = new PersonManager(new PersonRePository());

            if (String.IsNullOrEmpty(customer.Password))
            {
                ViewData["Message"] = "Make sure Passords are entered correclty";
            }
            else
            {
                if(this.personManager.UpdatePassword(customer.ID, customer.Password))
                {
                    ViewData["Message"] = "Password has been Updated Successfully";

                    return new RedirectToPageResult("ChangePassword");
                }
            }
            //if (ModelState.IsValid)
            //{
            //    if(personManager.UpdatePassword(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")), Password) == true)
            //    {
            //        ViewData["Message"] = "Make sure Passords are entered coreclty";

            //        return new RedirectToPageResult("ChangePassword");
            //    }
            //    else
            //    {
            //        { ViewData["Message"] = "Make sure Passords are entered coreclty"; }

            //    }

            return Page();
        }

           
        
        }
    }

