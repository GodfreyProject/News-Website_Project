using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Class
{
    public class Contact
    {
        //FIELDS
        private int id;
        private int personid;
        private string name;
        private string email;
        private string date;
        private string message;

        // Properties

        public int ContactID
        {
            get { return this.id; }

            set { this.id = value; }
        }
        public string FirstName
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Subject
        {
            get { return message; }
            set { message = value; }
        }

        public int PersonID
        {
            get { return this.personid; }
            set { this.personid = value; }

        }

        public String Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        //CONSTRUCTOR
        public Contact( int personId, string name, string email,  string message)
        {
            Subject = message;
            FirstName = name;
            Email = email;
            this.PersonID = personId;
           
        }

        public Contact(int ID,int personId, string name, string email, string message)
        {
            this.ContactID = ID;
            Subject = message;
            FirstName = name;
            Email = email;
            this.PersonID = personId;

        }
        //METHOD

        public Contact()
        {

        }
        public override string ToString()
        {
            return name + ": " + message;
        }
    }
}
