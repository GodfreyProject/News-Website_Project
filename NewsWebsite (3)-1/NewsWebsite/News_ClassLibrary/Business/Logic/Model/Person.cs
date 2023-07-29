using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace News_ClassLibrary.Business.Logic.Classes
{
   public  class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        // private string address;
        private string username;
        private string password;
        private string zipcode;
        private string role;
        private Role roles;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [Required]
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Firstname invalid");
                }
                firstName = value;
            }
        }

        public List<Role> Roles { get; set; }

        //public Role Role
        //{
        //    get { return this.roles; }

        //    set { this.roles = value; }
        //}
        [Required]
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Firstname invalid");
                }
                lastName = value;
            }
        }
        [Required]
        public string Email
        {
            get { return email; }
            set {

                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email address cant be Empty");
                }

                this.email = value;
            }
        }
        //[Required]
        //public string Address
        //{
        //    get { return address; }
        //    set { address = value; }
        //}
        [Required]
        public string Username
        {
            get { return this.username; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Username  cant be Empty");
                }

                this.username = value;
            }

        }
        [Required]
        public string Password
        {
            get { return password; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Paaswords Supplied");
                }

                this.password = value;
            }
        }

        public String Zipcode
        {
            get { return this.zipcode; }
            set {

                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Zipcode  cant be Empty");
                }

                this.zipcode = value;
            }
        }

        public String UserRole
        {
            get { return this.role; }

            set { this.role = value; }
        }
        public Person()
        {

        }
        public Person(int id, string Firstname, string Lastname, string Username, string Email, string Password, string zipcode, string role)
        {
            ID = id;
            this.FirstName = Firstname;
            this.LastName = Lastname;
            this.Email = Email;
            // this.Address = Address;
            this.Username = Username;
            this.Password = Password;
            this.Zipcode = zipcode;
            this.UserRole = role;

        }

        public Person(string Firstname, string Lastname, string Username, string Email, string Password, string zipcode, string role)
        {

            this.FirstName = Firstname;
            this.LastName = Lastname;
            this.Email = Email;
            // this.Address = Address;
            this.Username = Username;
            this.Password = Password;
            this.Zipcode = zipcode;
            this.UserRole = role;

        }

        public Person(string Firstname, string Lastname, string Username, string Email, string Password, string zipcode)
         
        {
            this.FirstName = Firstname;
            this.LastName = Lastname;
            this.Email = Email;
            // this.Address = Address;
            this.Username = Username;
            this.Password = Password;
            this.Zipcode = zipcode;
            //this.UserRole = role;


        }


        //public override string ToString()
        //{
        //    return $"ID: {id} Firstname: {FirstName} Lastname: {LastName} Email: {Email} ; Username: {Username} Password: {Password}: Zipcode: {Zipcode}: Userole: {UserRole} ";
        //}
        //public bool ISAdmin()
        //{
        //    return this.Roles != null && this.Roles.Contains(Role.Admin);
        //}
    }
}

