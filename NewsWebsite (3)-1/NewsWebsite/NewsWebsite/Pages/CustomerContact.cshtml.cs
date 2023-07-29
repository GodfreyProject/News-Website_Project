using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.dbClasses;
using SynthesisClassLibrary.ManagerClasses;

namespace NewsWebsite.Pages
{
    public class CustomerContactModel : PageModel
    {
        // DatabaseSelector ds;

        PersonManager personManager;
        ContactManager contact;
        [BindProperty]
        public String SubJect { get; set; }
        //[BindProperty]
        //Customer customer { get; set; }

        [BindProperty]
        Person Person { get; set; }

      
        [BindProperty]

        public String Username { get; set; }

        [BindProperty]

        public int PersonID { get; set; }

        [BindProperty]

       
        public String Msg { get; set; }

        public CustomerContactModel()
        {
            //ds = new DatabaseSelector(DatabaseType.Cloud);
            this.personManager = new PersonManager(new PersonRePository());
            contact = new ContactManager(new ContactRePository());
        }
        [BindProperty]
        public Person customer { get; set; }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return new RedirectToPageResult("index");
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                //Login Login = new Login( new EmailManager());

                customer = new Customer();

               customer =  personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

                return Page();
            }
            return new RedirectToPageResult("index");
        }

        public IActionResult OnPost()
        {
            //ds = new DatabaseSelector(DatabaseType.Cloud);

            if (String.IsNullOrEmpty(SubJect))
            {
                Msg = "Subject of that message cant be Left Empty";
                ViewData["Msg"] = Msg;
            }
            else 
            {
                if(contact.AddNewContact(customer.ID, customer.FirstName, customer.Email, SubJect))
                {
                    Msg = "Customer Contact Created Successfully";
                    ViewData["Msg"] = Msg;
                }

                return new RedirectToPageResult("CustomerContact");
            }

            return Page();
        }
       
    }
}
