using ClassLibrary.Class;
using News_ClassLibrary.ManagerInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagerTest.Persistence
{
    public class FakeContactRepository : IContactRePository
    {
        private List<Contact> contacts;
        public FakeContactRepository(List<Contact> Custcontacts)
        {
           contacts = Custcontacts;
        }
        public bool AddNewContact(int PersonID, string Firstname, string Email, string Message)
        {
            Contact contact = new Contact(PersonID, Firstname, Email, Message);

            if (this.contacts.Contains(contact))
            {
                this.contacts.Add(contact);

                return true;
            }
            else
            {
                return false;
            }


        }

        public Contact GetContact(int ID)
        {
          foreach(Contact contact in this.contacts)
            {
                if(contact.ContactID == ID)
                {
                    return contact;
                }
            }

            return null;
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }
    }
}
