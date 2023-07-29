using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.ManagerInterface;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.ManagerClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonManagerTest.Persistence
{
    public class PersonRePositoryTest : IPersonRePository
    {
        //PersonManager PersonManager;
        private List<Person> persons;
        public PersonRePositoryTest(List<Person> people)
        {
            //PersonManager = new PersonManager();
            persons = people;


        }
        public int AddCustomer(string FirstName, string LastName, string UserName, string Email, string Password, string Zipcode, string Role)
        {
            Person Customer = new Customer(0, FirstName, LastName, UserName, Email, Password, Zipcode, Role);

            if (persons.Count > 1)
            {
                Customer.ID = persons[persons.Count - 1].ID++;
            }
            else
            {
                Customer.ID = 1;
            }
            persons.Add(Customer);

            return Customer.ID;
        }


        public bool DeletePerson(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAllPeople()
        {
            return persons;
        }


        public Person GetPerson(string UserName, string Password)
        {
            foreach (Person p in this.persons)
            {
                if (p.Username == UserName && p.Password == Password)
                {
                    return p;
                }
            }
            return null;
        }

        public Person GetPerson(int ID)
        {
            foreach (Person p in persons)
            {
                if (p.ID == ID)
                {
                    return p;
                }
            }

            return null;
        }

        public Person GetPersonBYUsername(string UserName)
        {
            foreach (Person p in persons)
            {
                if (p.Username == UserName)
                {
                    return p;
                }
            }

            return null;
        }

        public Person GetUserRole(string UserType)
        {
            foreach (Person p in persons)
            {
                if (p.UserRole == UserType)
                {
                    return p;
                }
            }

            return null;
        }

        public bool UpdatePassword(int ID, string Password)
        {
            return true;
        }

        public bool UpdatePerson(int ID, string FirstName, string LastName, string UserName, string Email, string Password, string Zipcode)
        {
            foreach (Person p in persons)
            {
                p.ID = ID;
                p.FirstName = FirstName;
                p.LastName = LastName;
                p.Username = UserName;
                p.Password = Password;

                return true;
            }
            return false;

        }

        public bool UpdatePersons(int ID, string FirstName, string LastName, string UserName, string Email, string Zipcode)
        {
            foreach (Person p in persons)
            {
                p.ID = ID;
                p.FirstName = FirstName;
                p.LastName = LastName;
                p.Username = UserName;
                p.Email = Email;
                return true;
            }

            return false;
        }

        public Person GetPersonAdminRole(string Role, string Password)
        {

            foreach (Person p in persons)
            {
                if (p.UserRole == Role && p.Password == Password)
                {
                    return p;
                }

            }

            return null;
        }

        public bool AddPerson(string FirstName, string LastName, string UserName, string Email, string Password, string Zipcode, string Role)
        {
            PersonRePository rePository = new PersonRePository();
            Person person = new Person();

            persons.Add(new Person(FirstName, LastName, UserName, Email, Password, Zipcode, Role));

            return true;
        }

        private bool IsPersonValid(Person p)
        {
            return Validator.TryValidateObject(p, new ValidationContext(p), new List<ValidationResult>(), true);
        }

        public bool PersonExist(int ID)
        {
            PersonRePository rePository = new PersonRePository();
            if (rePository.PersonExist(ID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public int AddCustomer(string FirstName, string LastName, string UserName, string Email, string Password, string Zipcode, string Role)
      }
}
