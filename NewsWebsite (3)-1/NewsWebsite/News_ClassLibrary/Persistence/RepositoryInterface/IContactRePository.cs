using ClassLibrary.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace News_ClassLibrary.ManagerInterface
{
   public interface IContactRePository
    {
       
        public bool AddNewContact(int PersonID, string Firstname, string Email, string Message);

        public List<Contact> GetContacts();

        public Contact GetContact(int ID);
    }
}

