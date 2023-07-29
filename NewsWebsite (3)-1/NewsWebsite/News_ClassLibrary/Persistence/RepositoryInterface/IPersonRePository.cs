using News_ClassLibrary.Business.Logic.Classes;
using SynthesisClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace News_ClassLibrary.ManagerInterface
{
   public interface IPersonRePository
    {

        public List<Person> GetAllPeople();
        //read
        //public Person GetPerson(string UserName);

        public Person GetPersonBYUsername(string UserName);
        public Person GetPerson(string UserName, string Password);
        public Person GetPerson(int ID);

        public Person GetUserRole(String UserType);

        public bool PersonExist(int ID);
        // Admin create Account

        public Person GetPersonAdminRole(String Role, String Password);
        //create
        public int AddCustomer(string FirstName, string LastName, string UserName, string Email, string Password, string Zipcode, string Role);
        public bool AddPerson(string FirstName, string LastName, string UserName, string Email, string Password, string Zipcode, string Role);
        //Update
        public bool UpdatePassword(int ID, string Password);

        public bool UpdatePerson(int ID, string FirstName, string LastName, string UserName, string Email,string Password, string Zipcode);
        public bool UpdatePersons(int ID, string FirstName, string LastName, string UserName, string Email, string Zipcode);

        // Delete

        public bool DeletePerson(int ID);
    }
}
