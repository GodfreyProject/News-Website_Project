using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.dbClasses;
using SynthesisClassLibrary.ManagerClasses;
using System;
using System.Text.RegularExpressions;

namespace SynthesisWebsite.Pages
{
    public class CustomerPorfileModel : PageModel
    {
        [BindProperty]
        public Person customer { get; set; }

        public PersonManager personManager;
        public CustomerPorfileModel()
        {
            this.personManager = new PersonManager(new PersonRePository());
        }
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return new RedirectToPageResult("AccessDenied");
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
               // Login Login = new Login( new EmailManager());

                customer = new Customer();

               customer =  personManager.GetPerson(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));

                return Page();
            }
            return new RedirectToPageResult("AccessDenied");
        }

        public void UpdateProfileEmail()
        {
            EmailManager emailManager = new EmailManager();
            int ID = customer.ID;
            string Firstname = customer.FirstName;
            string Lastname = customer.LastName;
            string email = customer.Email;
            string username = customer.Username;
            string password = customer.Password;
            string Zipcode = customer.Zipcode;
            bool isEmail = Regex.IsMatch(email, @"[a-z]*@gmail.com$");
            emailManager.UpdateAcountInfo(Firstname, Lastname, username, email, Zipcode, ID);
        }
        public IActionResult OnPost()
        {
            
                    string message = UpdateAccountInfoCheck(customer.FirstName, customer.LastName, customer.Username, customer.Email, customer.Zipcode, customer.UserRole);
                    if (message == "")
                    {
                        if (personManager.UpdatePersons(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")), customer.FirstName, customer.LastName, customer.Username, customer.Email, customer.Zipcode))
                        {
                           

                            ViewData["Message"] = " Information updates, email has been send to " + customer.Email + ".";
                             UpdateProfileEmail();
                             return new RedirectToPageResult("CustomerPorfile");
                        }
                        ViewData["Message"] = "Something went wrong please try again later.";
                    }
                    else
                    {
                        ViewData["Message"] = message;
                    }
                 
            return Page();
        }
        public string UpdateAccountInfoCheck(string FirstName, string LastName, string Email, string UserName,  string Zipcode, String Role)
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
                return "Invalid last name; please captilize only the first letter"; //"/*/*LastName failed, make it's atleast 3 charecters long max:12.*/*/";
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
            //else if (string.IsNullOrEmpty(Password))
            //{
            //    return "UserName failed, make it's atleast 4 charecters long max:12.";
            //}

            //else if (string.IsNullOrEmpty(Password))
            //{
            //    return "Please include at least 1 number and 6 letter in your password";
            //}
            //else if (!Regex.IsMatch(Password, @"^(?=.*\d)([\w]{6,40})$"))
            //{
            //    return "Please include at least 1 number and 6 letter in your password";
            //}
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

        //public string NewAcountInfoCheck(string FirstName, string LastName, string Email,  string UserName, string Password)
        //{
        //    if (string.IsNullOrEmpty(FirstName))
        //    {
        //        return "Firstname failed, make it's atleast 3 charecters long max:12.";
        //    }
        //    else if (!Regex.IsMatch(FirstName, @"^[^ ]{3,12}$"))
        //    {
        //        return "Firstname failed, make it's atleast 3 charecters long max:12.";
        //    }
        //    else if (string.IsNullOrEmpty(LastName))
        //    {
        //        return "LastName failed, make it's atleast 3 charecters long max:12.";
        //    }
        //    else if (!Regex.IsMatch(LastName, @"^[^ ]{3,12}$"))
        //    {
        //        return "LastName failed, make it's atleast 3 charecters long max:12.";
        //    }
        //    else if (string.IsNullOrEmpty(Email))
        //    {
        //        return "Email failed, please try again.";
        //    }
        //    else if (!Regex.IsMatch(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
        //    {
        //        return "Email failed, please try again.";
        //    }
        //    //else if (string.IsNullOrEmpty(Address))
        //    //{
        //    //    return "Address failed, please try again.";
        //    //}
        //    //else if (!Regex.IsMatch(Address, @"^[^ ]{3,12}$"))
        //    //{
        //    //    return "Address failed, please try again.";
        //    //}
        //    else if (string.IsNullOrEmpty(UserName))
        //    {
        //        return "UserName failed, make it's atleast 4 charecters long max:12.";
        //    }
        //    else if (!Regex.IsMatch(UserName, @"^[^ ]{4,12}$"))
        //    {
        //        return "UserName failed, make it's atleast 4 charecters long max:12.";
        //    }
        //    else if (string.IsNullOrEmpty(Password))
        //    {
        //        return "Please include at least 1 number and 6 letter in your password";
        //    }
        //    else if (!Regex.IsMatch(Password, @"^(?=.*\d)([\w]{6,})$"))
        //    {
        //        return "Please include at least 1 number and 6 letter in your password";
        //    }
        //    return "";
        //}
    }
}
