using ClassLibrary.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.dbClasses;
using SynthesisClassLibrary.ManagerClasses;

namespace SynthesisWebsite.Pages
{
    public class loginModel : PageModel
    {
        public string PageTitle { get; set; }

        [BindProperty]
        public Customer customer { get; set; }

        //public DatabaseSelector ds;

        public loginModel()
        {
            
        }
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return new RedirectToPageResult("AdminHome");
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                return new RedirectToPageResult("CustomerHome");
            }
            return Page();
        }

        public IActionResult OnPostContent()
        {
            //this.ds = new DatabaseSelector(DatabaseType.Cloud);

            return RedirectToPage();
        }
        public IActionResult OnPost()
        {
            //Review review = new Review();
            NewsArticle news = new NewsArticle();
            string Username = customer.Username;
            string Password = customer.Password;

            if (string.IsNullOrEmpty(Username))
            {
                return null;
            }
            if (string.IsNullOrEmpty(Password))
            {
                return null;
            }
            if (checkLogin(customer.Username.ToString(), customer.Password.ToString()) != null)
            {

                Person a = checkLogin(customer.Username.ToString(), customer.Password.ToString());

                if (a is Admin)
                {
                    HttpContext.Session.SetInt32("UserID", a.ID);
                    HttpContext.Session.SetString("UserPosition", "Admin");

                    return new RedirectToPageResult("AdminHome");
                }
                else if (a is Customer)
                {
                    HttpContext.Session.SetInt32("UserID", a.ID);
                    HttpContext.Session.SetInt32("ID", news.NewsID);
                   
                    HttpContext.Session.SetString("UserPosition", "Customer");

                    return new RedirectToPageResult("CustomerHome");
                }
                else
                {
                    return Page();
                }
            }
            string message = "Invalid credentials, try again";
            ViewData["LoginMessage"] = message;
            return Page();
        }

        //public void OnPostForgotPassword()
        //{
        //    Login Login = new Login(new PersonManager(new dbPersonManager()), new EmailManager());
            
        //    Person person = Login.personManager.GetPerson(customer.Username);

        //    if (person != null)
        //    {
        //        Login.emailManager.ForgotPassword(person);
        //        ViewData["LoginMessage"] = "A email has been send to your email address with the inforamtion you'll need to reset you password.";
        //    }
        //}

        public Person checkLogin(string UserName, string Password)
        {
            PersonManager personManager = new PersonManager(new PersonRePository());
           // Login Login = new Login( new EmailManager());

           return personManager.GetPerson(UserName, Password);
        }
    }
}
