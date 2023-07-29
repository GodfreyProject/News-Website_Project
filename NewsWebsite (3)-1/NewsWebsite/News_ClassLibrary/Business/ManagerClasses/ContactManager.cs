
using ClassLibrary.Class;
using News_ClassLibrary.ManagerInterface;
using News_ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace News_ClassLibrary.ManagerClasses
{
    public class ContactManager 
    {
        private IContactRePository contactRePository;
        public ContactManager(IContactRePository repo)
        {
            contactRePository = repo;
        }

       
        public bool AddNewContact(int PersonID, string Firstname, string Email, string Message)
        {
            if(this.contactRePository.AddNewContact(PersonID, Firstname, Email, Message))
            {
                return true;
            }

            return false;
        }

        public List<Contact> GetContacts()
        {
            return this.contactRePository.GetContacts();
        }

        public Contact GetContact(int ID)
        {
            return this.contactRePository.GetContact(ID);
        }
    }
}
