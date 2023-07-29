using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Business.Logic.Model;
using News_ClassLibrary.Business.ManagerClasses;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.ManagerClasses;

namespace NewsWebsite.Pages
{
    public class UnsubscribeModel : PageModel
    {
        Person Person { get; set; }
       public PersonManager personManager;
       public SubscribeManager subscribeManager = new SubscribeManager(new SubscriptionRepository());
       
        [BindProperty]

        public int SUBID { get; set; }

        [BindProperty]

        public int PersonID { get; set; }

        [BindProperty]


        public String Msg { get; set; }

        public UnsubscribeModel()
        {
            //ds = new DatabaseSelector(DatabaseType.Cloud);
            this.personManager = new PersonManager(new PersonRePository());
            SubscribeManager subscribeManager = new SubscribeManager(new SubscriptionRepository());
        }
        [BindProperty]
        public Person customer { get; set; }
        [BindProperty]
        public SubScription GetSub { get; set; }
        public IActionResult OnGet(int ID)
        {
            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return new RedirectToPageResult("index");
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                
                GetSub = new SubScription();
                GetSub = subscribeManager.GetSubScribe(ID);
               // SUBID = GetSub.SubID;
                customer = new Customer();

                customer = personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

                return Page();
            }
            return new RedirectToPageResult("AccessDenied");
        }
        public IActionResult OnPost(int ID)
        {
            //ds = new DatabaseSelector(DatabaseType.Cloud);

            if (String.IsNullOrEmpty(ID.ToString()))
            {
                Msg = "All Fields can't be Left Empty";
                ViewData["Msg"] = Msg;
            }
            else
            {

                if (subscribeManager.UnSubscribe(ID))
                {
                    Msg = "Customer has subdcribe Successfully";
                    SendEmail();
                    ViewData["Msg"] = Msg;
                }

                return new RedirectToPageResult("Unsubscribe");
            }

            return Page();
        }

        public void SendEmail()
        {
            EmailManager emailManager = new EmailManager();
            int ID = customer.ID;
            string Firstname = customer.FirstName;
            string Lastname = customer.LastName;
            string email = customer.Email;
            //string username = customer.Username;
            //string password = customer.Password;
            //string Zipcode = customer.Zipcode;
            bool isEmail = Regex.IsMatch(email, @"[a-z]*@gmail.com$");
            emailManager.UnSubScriber(Firstname, Lastname, email, ID);
        }

    }
}
