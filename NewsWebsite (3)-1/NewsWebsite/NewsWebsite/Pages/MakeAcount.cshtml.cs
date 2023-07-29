using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.dbClasses;
using SynthesisClassLibrary.ManagerClasses;

namespace SynthesisWebsite.Pages
{
    public class MakeAcountModel : PageModel
    {
        [BindProperty]
        public Customer customer { get; set; }

        public void OnGet()
        {
        }

        public void SendEmail()
        {
            EmailManager emailManager = new EmailManager();
            string Firstname = customer.FirstName;
            string Lastname = customer.LastName;
            string email = customer.Email;
            string username = customer.Username;
            string password = customer.Password;
            string Zipcode = customer.Zipcode;
            bool isEmail = Regex.IsMatch(email, @"[a-z]*@gmail.com$");
            emailManager.NewAcountInfo(Firstname, Lastname, username, email, password, Zipcode, "Admin");
        }
        public IActionResult OnPost()
        {
            PersonManager personManager = new PersonManager(new PersonRePository());
            if (ModelState.IsValid)
            {
                //Login Login = new Login( new EmailManager());
                if (personManager.GetPersonBYUsername(customer.Username) == null)
                {
                    string message = NewAcountInfoCheck(customer.FirstName, customer.LastName, customer.Username, customer.Email, customer.Password, customer.Zipcode, customer.UserRole);
                    if (message == "")
                    {
                        int ID = personManager.AddCustomer(customer.FirstName, customer.LastName, customer.Username, customer.Email,   customer.Password, customer.Zipcode, customer.UserRole);
                        if (ID !=0)
                        {
                            HttpContext.Session.SetInt32("UserID", ID);
                            HttpContext.Session.SetString("UserPosition", "Customer");
                            SendEmail();
                            return new RedirectToPageResult("CustomerHome");
                        }
                        ViewData["Message"] = "Something went wrong please try again later.";
                    }
                    else
                    {
                        ViewData["Message"] = message;
                    }
                }
                else
                {
                    ViewData["Message"] = "Username already exists.";
                }
            }
            return Page();
        }
        public string NewAcountInfoCheck(string FirstName, string LastName, string Email, string UserName, string Password, string Zipcode, String Role)
        {
            
            if (string.IsNullOrEmpty(FirstName))
            {
                return "Firstname failed, make it's atleast 3 charecters long max:12.";
            }
            else if (!Regex.IsMatch(FirstName, @"^[A-Z][a-z]+$")) //(Regex.IsMatch(FirstName, @"^[^ ]{3,12}$"))
            {

                return "Invalid first name; please captilize only the first letter";
            }//"Firstname failed, make it's atleast 3 charecters long max:12.";

            else if (string.IsNullOrEmpty(LastName))
            {
                return "LastName failed, make it's atleast 3 charecters long max:12.";
            }
            else if (!Regex.IsMatch(LastName, @"^[a-z \.A-Z]*[A-Z][a-z]+$"))//!Regex.IsMatch(LastName, @"^[^ ]{3,12}$"))
            {
                return "Invalid last name; please captilize only the first letter"; //"LastName failed, make it's atleast 3 charecters long max:12.";
            }
            else if (string.IsNullOrEmpty(UserName))
            {
                return "Username failed, please try again.";
            }
            else if (Regex.IsMatch(UserName, @"^[^ ]{4,12}$"))
            {
                return "UserName failed, make it's atleast 2 charecters long max:12.";
            }
            else if (string.IsNullOrEmpty(Email))
            {
                return "Email failed, please try again.";
            }
            else if (Regex.IsMatch(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")) // @"[a-z]*@gmail.com$"
            {
                return "Email failed, please try again.";
            }
            else if (string.IsNullOrEmpty(Password))
            {
                return "UserName failed, make it's atleast 4 charecters long max:12.";
            }

            else if (string.IsNullOrEmpty(Password))
            {
                return "Please include at least 1 number and 6 letter in your password";
            }
            else if (!Regex.IsMatch(Password, @"^(?=.*\d)([\w]{6,40})$"))
            {
                return "Please include at least 1 number and 6 letter in your password";
            }
            else if (string.IsNullOrEmpty(Zipcode))
            {
                return "zipcode failed, make it's atleast 4 charecters long max:12.";
            }
            else if (!Regex.IsMatch(Zipcode, @"^[0-9]{4}[A-Z]{2}$"))
            {
                return "Invalid postal code, Include Four numbers and Capitalize 2 charaters(letters)";
            }
            else if (string.IsNullOrEmpty(Zipcode))
            {
                return "zipcode failed, make it's atleast 4 charecters long max:12.";
            }
            return "";
        }
       

       
    }
}
