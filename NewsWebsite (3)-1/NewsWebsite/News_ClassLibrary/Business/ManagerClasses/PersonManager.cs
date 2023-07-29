
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerInterface;
using News_ClassLibrary.Persistence;
using PersonManagerTest.Business;
using SynthesisClassLibrary.dbClasses;
//using SynthesisClassLibrary.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SynthesisClassLibrary.ManagerClasses
{
    public class PersonManager : IPersonRePository 
    {
       
       private IPersonRePository rePository;
        public PersonManager(IPersonRePository pository)
        {
         
            rePository = pository;
           
        }

        //Read
        public Person GetPersonBYUsername(string UserName)
        {
            return rePository.GetPersonBYUsername(UserName);
        }
        public Person GetPerson(string UserName, string Password)
        {
            return rePository.GetPerson(UserName, Password);
        }
        public Person GetPerson(int ID)
        { 
            return rePository.GetPerson(ID); 
        }
        public Person GetPersonAdminRole(String Role, String Password)
        {
            return rePository.GetPersonAdminRole(Role, Password);
        }
        //Create
        public int AddCustomer(string FirstName, string LastName, string UserName, string Email,  string Password, String Ziocode, String Role)
        {
            return rePository.AddCustomer(FirstName, LastName,   UserName, Email, Password, Ziocode, Role);
        }

      

        //Update
        public bool UpdatePassword(int ID,string Password)
        {
            return rePository.UpdatePassword(ID, Password);
        }
        public bool UpdatePerson(int ID, string FirstName, string LastName, string UserName, string Email, String Password, String Ziocode)
        {
            return rePository.UpdatePerson(ID, FirstName, LastName, UserName, Email, Password,  Ziocode);
        }

        public bool UpdatePersons(int ID, string FirstName, string LastName, string UserName, string Email,  String Ziocode)
        {
            return rePository.UpdatePersons(ID, FirstName, LastName, UserName, Email,  Ziocode);
        }



        //public Person GetPersonRole(string UserType)
        //    return personManager.GetUserRole(UserType);
        //}

        public List<Person>GetPeople()
        {
            return this.rePository.GetAllPeople();
        }

        public Person GetUserRole(string UserType)
        {
            return this.rePository.GetUserRole(UserType);
        }

        public bool AddPerson(string FirstName, string LastName, string UserName, string Email, string Password, string Zipcode, string Role)
        {
           
            if(this.rePository.AddPerson(FirstName, LastName, UserName, Email, Password, Zipcode, Role))
            {
                return true;
            }
            else
            {
                return false;
            }
           
            
        }
        

        public List<Person> GetAllPeople()
        {
            return this.rePository.GetAllPeople();
        //{
        }

        public bool DeletePerson(int ID)
        {
            if (rePository.DeletePerson(ID))
            {
                return true;
            }

            return false;
        }

        private bool IsPersonValid(Person p)
        {
            return Validator.TryValidateObject(p, new ValidationContext(p), new List<ValidationResult>(), true);
        }

        public bool PersonExist(int ID)
        {
            return true;
        }
    }
}
