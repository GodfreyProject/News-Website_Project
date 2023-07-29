using ClassLibrary.Class;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Logic.Classes;
using SynthesisClassLibrary.dbClasses;
using SynthesisClassLibrary.Interface;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace SynthesisClassLibrary.ManagerClasses
{
    public class EmailManager: IEmail
    {
        //public PasswordResetCodeManager passwordResetCodeManager;
        public EmailManager()
        {
           // passwordResetCodeManager = new PasswordResetCodeManager();
        }

        public void NewAcountInfo(string FirstName, string LastName, string UserName, string Email,  string Password, string Zipcode, String Rolr)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("GodfreyOgbeide10@gmail.com", "Gr10a10ce82@"),
                    EnableSsl = true,
                };

                StringBuilder message = new StringBuilder();

                message.Append(" <h1>‘Welcome To News Today B.V</h1>");
                message.Append(" <h1>Acount informatin</h1>");
                message.AppendLine("<h2>A new acount has just been created using this email.</h2>");
                message.AppendLine("<br />");
                message.AppendLine("<p> Here is all the information of the new acount. </p>");
                message.AppendLine($"<p> Firstname: {FirstName} </p>");
                message.AppendLine($"<p> LastName: {LastName} </p>");
                message.AppendLine($"<p> UserName: {UserName} </p>");
                message.AppendLine($"<p> Email: {Email} </p>");
                message.AppendLine($"<p> Passsword: {dbConnection.hashPassword(Password)}</p>");
                message.AppendLine($"<p> Zipcode: {Zipcode} </p>");
                //message.AppendLine($"<p> Password: {} </p>");
                message.AppendLine("<p></p>");
                message.AppendLine("<p>Link to website: https://i426309.luna.fhict.nl/ </p>");

                message.AppendLine("<p> Contact us with this email adress if you run in to any problems: nazibul.kabir.srv@gmail.com</p>");

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("MediaBazaar.HQ@gmail.com"),
                    Subject = "‘Daily News Today B.V Acount Information.",
                    Body = message.ToString(),
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(Email);

                smtpClient.Send(mailMessage);
            }
            catch (Exception a)
            {
                Debug.WriteLine(a.Message);
            }
        }
        public void UpdateAcountInfo(string FirstName, string LastName,   string UserName, string Email, string Zipcode,  int ID)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("GodfreyOgbeide10@gmail.com", "Gr10a10ce82@"),
                    EnableSsl = true,
                };

                StringBuilder message = new StringBuilder();

                message.Append(" <h1>‘News Today B.V</h1>");
                message.Append(" <h1>Your Account Informationan has been Updated Succesfully</h1>");
                message.AppendLine("<h2>You acount inforamtion has just been updated.</h2>");
                message.AppendLine("<br />");
                message.AppendLine("<p> Here is all the information of the acount. </p>");
                message.AppendLine($"<p> Firstname: {FirstName} </p>");
                message.AppendLine($"<p> LastName: {LastName} </p>");
                message.AppendLine($"<p> Email: {Email} </p>");
                message.AppendLine($"<p> Address: {Zipcode} </p>");
                message.AppendLine($"<p> UserName: {UserName} </p>");
                //message.AppendLine($"<p> Password: {dbConnection.hashPassword(Password)} </p>");
                message.AppendLine("<p></p>");
                message.AppendLine("<p>Link to website: https://i426309.luna.fhict.nl/ </p>");

                message.AppendLine("<p> Contact us with this email adress if you run in to any problems: nazibul.kabir.srv@gmail.com</p>");

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("MediaBazaar.HQ@gmail.com"),
                    Subject = "‘Daily News Today B.V Acount Information.",
                    Body = message.ToString(),
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(Email);

                smtpClient.Send(mailMessage);
            }
            catch (Exception a)
            {
                Debug.WriteLine(a.Message);
            }
        }

        public void NewSubScriber(string FirstName, string LastName,  string Email, String Payment, String Month, String Payed)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("GodfreyOgbeide10@gmail.com", "Gr10a10ce82@"),
                    EnableSsl = true,
                };

                StringBuilder message = new StringBuilder();

                message.Append(" <h1>‘Welcome To News Today B.V</h1>");
                message.Append(" <h1>Subscriber information</h1>");
                message.AppendLine("<h2>A new Subscriber has just been created and Payed by Customer using this email.</h2>");
                message.AppendLine("<br />");
                message.AppendLine("<p> Here is all the information of the new Subscriber Payment Account Info. </p>");
                message.AppendLine($"<p> Firstname: {FirstName} </p>");
                message.AppendLine($"<p> LastName: {LastName} </p>");
                message.AppendLine($"<p> Email: {Email} </p>");
                message.AppendLine($"<p> Payment-Bill: {Payment} </p>");
                message.AppendLine($"<p> Monthly: {Month}</p>");
                message.AppendLine($"<p> Status: {Payed} </p>");
                //message.AppendLine($"<p> Password: {} </p>");
                message.AppendLine("<p></p>");
                message.AppendLine("<p>Link to website: https://i426309.luna.fhict.nl/ </p>");

                message.AppendLine("<p> Contact us with this email adress if you run in to any problems: nazibul.kabir.srv@gmail.com</p>");

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("MediaBazaar.HQ@gmail.com"),
                    Subject = "‘Daily News Today B.V Acount Information.",
                    Body = message.ToString(),
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(Email);

                smtpClient.Send(mailMessage);
            }
            catch (Exception a)
            {
                Debug.WriteLine(a.Message);
            }
        }

        public void UnSubScriber(string FirstName, string LastName,String Email,int ID)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("GodfreyOgbeide10@gmail.com", "Gr10a10ce82@"),
                    EnableSsl = true,
                };

                StringBuilder message = new StringBuilder();

                message.Append(" <h1>‘Welcome To News Today B.V</h1>");
                message.Append($" <h1>UnSubscriber information</h1>");
                message.AppendLine($"<h2> You have Succesfully UnSubscribe From News Today using this email.</h2>");
                message.AppendLine("<br />");
                message.AppendLine("<p> Here is all the information of the new Subscriber Payment Account Info. </p>");
                message.AppendLine($"<p> PersonID: {ID} </p>");
                message.AppendLine($"<p> Firstname: {FirstName} </p>");
                message.AppendLine($"<p> LastName: {LastName} </p>");
                message.AppendLine($"<p> Email: {Email} </p>");
              
           
                //message.AppendLine($"<p> Password: {} </p>");
                message.AppendLine("<p></p>");
                message.AppendLine("<p>Link to website: https://i426309.luna.fhict.nl/ </p>");

                message.AppendLine("<p> Contact us with this email adress if you run in to any problems: nazibul.kabir.srv@gmail.com</p>");

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("MediaBazaar.HQ@gmail.com"),
                    Subject = "‘Daily News Today B.V Acount Information.",
                    Body = message.ToString(),
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(Email);

                smtpClient.Send(mailMessage);
            }
            catch (Exception a)
            {
                Debug.WriteLine(a.Message);
            }
        }
        public void AddNewContact(Contact contact)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("MediaBazaar.HQ@gmail.com", "MediaBazaar21"),
                    EnableSsl = true,
                };

                StringBuilder message = new StringBuilder();

                message.Append("<h1>‘News Today B.V</h1>");
                message.Append("<h2>Client Contact</h2>");
                message.AppendLine($"<p> Customer: {contact.FirstName} {contact.FirstName}</p>");
                message.AppendLine($"<p> Email: {contact.Email} </p>");
                message.AppendLine($"<h3> Subject: {contact.Subject} </h3>");
               // message.AppendLine($"<h4> Message: {contact.Message} </h4>");
                message.AppendLine("<h4> Make sure to get back to the customer as soon as possible. </h4>");
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("MediaBazaar.HQ@gmail.com"),
                    Subject = contact.Subject,
                    Body = message.ToString(),
                    IsBodyHtml = true,
                };
                mailMessage.To.Add("MediaBazaar.HQ@gmail.com");

                smtpClient.Send(mailMessage);
            }
            catch (Exception a)
            {
                Debug.WriteLine(a.Message);
            }
        }

        public void UpdateAcountInfo(string FirstName, string LastName, string UserName, string Email, string Password)
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(int ID, string Password)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("GodfreyOgbeide10@gmail.com", "Gr10a10ce82@"),
                    EnableSsl = true,
                };

                StringBuilder message = new StringBuilder();

                message.Append(" <h1>‘Welcome To News Today B.V</h1>");
                message.Append(" <h1>Your Password has been Updated Succesfully</h1>");
                message.AppendLine("<h2>Password has been Changed.</h2>");
                message.AppendLine("<br />");
                message.AppendLine("<p> Here is all the information of the new Subscriber Payment Account Info. </p>");
                message.AppendLine($"<p> ID: {ID} </p>");
                message.AppendLine($"<p> Password: {Password} </p>");
              
                message.AppendLine("<p></p>");
                message.AppendLine("<p>Link to website: https://i426309.luna.fhict.nl/ </p>");

                message.AppendLine("<p> Contact us with this email adress if you run in to any problems: nazibul.kabir.srv@gmail.com</p>");

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("MediaBazaar.HQ@gmail.com"),
                    Subject = "‘Daily News Today B.V Acount Information.",
                    Body = message.ToString(),
                    IsBodyHtml = true,
                };
               

                smtpClient.Send(mailMessage);
            }
            catch (Exception a)
            {
                Debug.WriteLine(a.Message);
            }
        }

        public void CreateReview(Review review)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("MediaBazaar.HQ@gmail.com", "MediaBazaar21"),
                    EnableSsl = true,
                };

                StringBuilder message = new StringBuilder();

                message.Append("<h1>‘News Today B.V</h1>");
                message.Append("<h2>Client Contact</h2>");
                message.AppendLine($"<p> ReviewID: {review.ReviewID} </p>");
                message.AppendLine($"<p> PersonID: {review.PersonID} </p>");
                message.AppendLine($"<h3> Username: {review.Username} </h3>");
                message.AppendLine($"<h3> NewsID: {review.NewsID} </h3>");
                message.AppendLine($"<h3> NewsType: {review.NewsType} </h3>");
                message.AppendLine($"<h3> Subject: {review.Message} </h3>");
                message.AppendLine($"<h3> Subject: {review.Date} </h3>");
                // message.AppendLine($"<h4> Message: {contact.Message} </h4>");
                message.AppendLine("<h4> Make sure to get back to the customer as soon as possible. </h4>");
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("MediaBazaar.HQ@gmail.com"),
                    Subject = review.Message,
                    Body = message.ToString(),
                    IsBodyHtml = true,
                };
                mailMessage.To.Add("MediaBazaar.HQ@gmail.com");

                smtpClient.Send(mailMessage);
            }
            catch (Exception a)
            {
                Debug.WriteLine(a.Message);
            }
        }
    }
}
