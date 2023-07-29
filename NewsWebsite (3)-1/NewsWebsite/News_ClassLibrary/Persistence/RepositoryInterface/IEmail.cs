using ClassLibrary.Class;
using News_ClassLibrary.Logic.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisClassLibrary.Interface
{
   public interface IEmail
    {
        public void NewAcountInfo(string FirstName, string LastName, string UserName, string Email,   string Password, string Zipcode, String Role);
        public void UpdateAcountInfo(string FirstName, string LastName, string UserName, string Email,  String Zipcode,  int ID);
       

        public void ChangePassword(int ID ,String Password);
        public void AddNewContact(Contact contact);

        public void CreateReview(Review review);

        public void NewSubScriber(string FirstName, string LastName, string Email, String Payment, String Month, String Payed);
        
    }
}
