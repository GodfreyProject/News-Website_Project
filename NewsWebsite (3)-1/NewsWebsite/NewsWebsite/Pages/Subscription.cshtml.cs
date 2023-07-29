using System;
using System.Collections.Generic;
using System.Linq;
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
    public class SubscriptionModel : PageModel
    {
        Person Person { get; set; }
        PersonManager personManager;
        SubscribeManager subscribeManager = new SubscribeManager(new SubscriptionRepository());

        //[BindProperty]
        //Customer customer { get; set; }
        public List<SubScription> GetScriptions;
        [BindProperty]

        public String FirstName { get; set; }

        [BindProperty]

        public int PersonID { get; set; }

        [BindProperty]
        public String Msg { get; set; }

        public SubscriptionModel()
        {
            //ds = new DatabaseSelector(DatabaseType.Cloud);
            this.personManager = new PersonManager(new PersonRePository());
            // SubscribeManager subscribeManager = new SubscribeManager(new SubscriptionRepository());
        }
        [BindProperty]
        public Person customer { get; set; }

        [BindProperty]

        public int SubID { get; set; }
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
                GetScriptions = subscribeManager.GetAllSubsscription();
                //Login Login = new Login( new EmailManager());
                GetSub = new SubScription();
                GetSub = subscribeManager.GetSubScribe(ID);
                //SubID = GetSub.SubID;
                customer = new Customer();

                customer = personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

                return Page();
            }
            return new RedirectToPageResult("AccessDenied");
        }

       
    }
}
