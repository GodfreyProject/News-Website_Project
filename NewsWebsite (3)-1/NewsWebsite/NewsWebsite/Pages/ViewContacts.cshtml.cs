using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;

namespace NewsWebsite.Pages
{
    public class ViewContactsModel : PageModel
    {
        public List<Contact> contacts;

        ContactManager contactManager;

        public ViewContactsModel()
        {
            this.contactManager  = new ContactManager(new ContactRePository());
        }
        public IActionResult OnGet()
        {

            this.contacts = contactManager.GetContacts();


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
