using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.dbClasses;
using SynthesisClassLibrary.ManagerClasses;

namespace NewsWebsite.Pages
{
    public class AdminProfileModel : PageModel
    {
      

        [BindProperty]
        public Person employee { get; set; }
        PersonManager personManager = new PersonManager(new PersonRePository());
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                //Login Login = new Login(new EmailManager());

                employee = new Admin();

                employee =  personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

                return Page();
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                return new RedirectToPageResult("index");
            }
            return new RedirectToPageResult("Index");
        }

        public void UpdateProfileEmail()
        {
            EmailManager emailManager = new EmailManager();
            int ID = employee.ID;
            string Firstname = employee.FirstName;
            string Lastname = employee.LastName;
            string email = employee.Email;
            string username = employee.Username;
            string password = employee.Password;
            string Zipcode = employee.Zipcode;
            bool isEmail = Regex.IsMatch(email, @"[a-z]*@gmail.com$");
            emailManager.UpdateAcountInfo(Firstname, Lastname, username, email, Zipcode, ID);
        }

        public IActionResult OnPost()
            {
                if (personManager.UpdatePersons(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")), employee.FirstName, employee.LastName, employee.Username, employee.Email, employee.Zipcode))
                {
                    ViewData["Message"] = " Information updates, email has been send to " + employee.Email + ".";
                     UpdateProfileEmail();

                return new RedirectToPageResult("AdminProfile");
                }
                else
                {
                    ViewData["Message"] = "Something went wrong.";
                }
                return Page();
                //if (ModelState.IsValid)
                //{
                //    Login Login = new Login(new EmailManager());
                //    if (personManager.GetPersonBYUsername(employee.Username) == null || personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID"))).Username == employee.Username)
                //    {
                //        string Message = NewAcountInfoCheck(employee.FirstName, employee.LastName, employee.Username,  employee.Email, employee.Password, employee.Zipcode, employee.UserRole,"Admin");
                //        if (Message == "")
                //        {
                //            if (personManager.UpdatePerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")), employee.FirstName, employee.LastName, employee.Email, employee.Username,  employee.Zipcode) == true)
                //            {
                //                ViewData["Message"] = " Information updates, email has been send to " + employee.Email + ".";
                //            }
                //            else
                //            {
                //                ViewData["Message"] = "Somethinf went wrong.";
                //            }
                //        }
                //        else { ViewData["Message"] = Message; }
                //    }
                //    else { ViewData["Message"] = "Username already exists"; }
            //}
        }
        public string NewAcountInfoCheck(string FirstName, string LastName, string Email, string Address, string UserName, string Password, String Zipcode, String Role)
        {
            if (string.IsNullOrEmpty(FirstName))
            {
                return "Firstname failed, make it's atleast 3 charecters long max:12.";
            }
            else if (!Regex.IsMatch(FirstName, @"^[^ ]{3,12}$"))
            {
                return "Firstname failed, make it's atleast 3 charecters long max:12.";
            }
            else if (string.IsNullOrEmpty(LastName))
            {
                return "LastName failed, make it's atleast 3 charecters long max:12.";
            }
            else if (!Regex.IsMatch(LastName, @"^[^ ]{3,12}$"))
            {
                return "LastName failed, make it's atleast 3 charecters long max:12.";
            }
            else if (string.IsNullOrEmpty(Email))
            {
                return "Email failed, please try again.";
            }
            else if (!Regex.IsMatch(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return "Email failed, please try again.";
            }
            else if (string.IsNullOrEmpty(Address))
            {
                return "Address failed, please try again.";
            }
            else if (!Regex.IsMatch(Address, @"^[^ ]{3,12}$"))
            {
                return "Address failed, please try again.";
            }
            else if (string.IsNullOrEmpty(UserName))
            {
                return "UserName failed, make it's atleast 4 charecters long max:12.";
            }
            else if (!Regex.IsMatch(UserName, @"^[^ ]{4,12}$"))
            {
                return "UserName failed, make it's atleast 4 charecters long max:12.";
            }
            else if (string.IsNullOrEmpty(Password))
            {
                return "Please include at least 1 number and 6 letter in your password";
            }
            else if (!Regex.IsMatch(Password, @"^(?=.*\d)([\w]{6,})$"))
            {
                return "Please include at least 1 number and 6 letter in your password";
            }
            return "";
        }
    }
}
