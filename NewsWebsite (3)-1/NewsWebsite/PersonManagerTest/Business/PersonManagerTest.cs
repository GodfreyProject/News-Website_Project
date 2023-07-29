using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Persistence;
using PersonManagerTest.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.ManagerClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagerTest.Business
{
    [TestClass]
    public class PersonManagerTest
    {
        [TestMethod]
        public void GetPersonSuccessFulTest()
        {
            Person personJames = new Person();
            personJames.ID = 1;
            personJames.Username = "Daniel";
            personJames.Password = "Busy45";

            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);

            Person personLogin = personManager.GetPerson("Daniel", "Busy45");

            Assert.AreEqual(1, personLogin.ID);
            Assert.AreEqual("Daniel", personLogin.Username);
            Assert.AreEqual("Busy45", personLogin.Password);
        }



        [TestMethod]
        public void GetPersonSuccessFulBYIDTest()
        {
            Person personJames = new Person();
            personJames.ID = 2;
            personJames.Username = "Daniel";
            personJames.Password = "Busy45";

            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);

            Person personLogin = personManager.GetPerson(2);

            Assert.AreEqual(2, personLogin.ID);
        }


       
        [TestMethod]
        public void GetPersonSuccessFulByRoleTest()
        {
            Person personJames = new Person();
            personJames.ID = 3;
           // personJames.UserRole = "Customer";


            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);

            Person personLogin = personManager.GetUserRole("Customer");

            Assert.AreEqual(personLogin, personJames.UserRole);
        }

        [TestMethod]
        public void UpdatePersonPasswordTest()
        {
            Person personJames = new Person();
            personJames.ID = 3;
            personJames.Password = "Busy45";


            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);

            bool personLogin = personManager.UpdatePassword(3, "BOLD5");


            Assert.IsTrue(personLogin, personJames.Password);
            Assert.IsTrue(personLogin, personJames.ID.ToString());


        }

        [TestMethod]
        public void UpdatePersonTest()
        {
            Person personJames = new Person();
            personJames.ID = 4;
            personJames.FirstName = "Jerry";
            personJames.LastName = "Jonah";
            personJames.Username = "Brave";
            personJames.Email = "Jerry@gmail.com";
            personJames.Password = "Busy45";
            personJames.Zipcode = "7765GB";
            personJames.UserRole = "Customer";


            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);

            bool UpdatePerson = personManager.UpdatePerson(4, "Jerry", "Jonah", "BOLD5", "Jerry@gmail.com", "Create5", "7778DC");

            personManager.GetPerson(4);

            Assert.IsTrue(UpdatePerson);



        }



        [TestMethod]
        public void UpdatePersonsTest()
        {
            Person personJames = new Person();
            personJames.ID = 5;
            personJames.FirstName = "Jerry";
            personJames.LastName = "Jonah";
            personJames.Username = "Brave";
            personJames.Email = "Jerry@gmail.com";
            personJames.Password = "Busy45";
            personJames.Zipcode = "7765GB";



            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);

            bool UpdatePerson = personManager.UpdatePersons(5, "Jerry", "Jonah", "BOLD5", "Jerry@gmail.com", "7765GB");


            Assert.IsTrue(UpdatePerson);
        }

        [TestMethod]
        public void GetPersonAdminRoleTest()
        {
            Person personJames = new Person();
            //personJames.ID = 3;
            personJames.Password = "BOLD5";
            personJames.UserRole = "Admin";


            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);

          
            Assert.AreEqual("Admin", personJames.UserRole);
          

        }

       
        

        [TestMethod]
        //[ExpectedException(typeof(InvalidOperationException))]
        public void GetNonPersonByUsernmeTest()
        {
            Person personJames = new Person();
            personJames.Username = "Derrick";
            personJames.Username = "Day65";
            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);
            PersonManager pm = new PersonManager(positoryTest);


            personManager.AddPerson("MediaBazaar", "Zero Derricks", "Derrick", "z.derricks@mediabazaar.com", "PassworD", "4567DB", " Customer");
            pm.AddCustomer("Jenny", "Smith", "Day65", "Jenny.derricks@mediabazaar.com", "Pas123", "4567AB", " Admin");


            //Assert.AreEqual(personJames, pm.GetPersonBYUsername("Derrick"));
            Assert.AreEqual(null, personManager.GetPersonBYUsername("Day5"));

        }

        [TestMethod]
       
        public void AddDuplicatePersonUsernameTest()
        {
            Person personJames = new Person();
             
            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);
            PersonManager pm = new PersonManager(positoryTest);


            //personManager.AddPerson("MediaBazaar", "Zero Derricks", "Derrick", "z.derricks@mediabazaar.com", "PassworD", "4567DB", " Customer");
          bool AleadyExistUsername1 =   pm.AddPerson("Jenny", "Smith", "Day65", "Jenny.derricks@mediabazaar.com", "Pas123", "4567AB", " Customer");
            

            Assert.IsTrue(AleadyExistUsername1);
          
            //Assert.AreNotEqual("Day65", personJames.Username);
          
        }


        

        [TestMethod]
        public void GetALLPersonsTest()
        {
            Person personJames = new Person();
            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);
            //PersonManager pm = new PersonManager(positoryTest);

            personManager.AddPerson("MediaBazaar", "Zero Derricks", "Derrick", "z.derricks@mediabazaar.com", "PassworD", "4567DB", " Customer");
            personManager.AddCustomer("Jenny", "Smith", "Day65", "Jenny.derricks@mediabazaar.com", "Pas123", "4567AB", " Admin");


            List<Person> people = personManager.GetAllPeople();

           
            ////CollectionAssert.AreEquivalent(pm.GetAllPeople(), people);
            CollectionAssert.AreEquivalent(personManager.GetAllPeople(), people);
           
        }

        [TestMethod]
        public void GetConstrcutorPerManagerTest()
        {
            Person personJames = new Person();
           
            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);
            List<Person> people = new List<Person>();

            Assert.AreEqual( personManager, personManager);
        }

        [TestMethod]
        public void AddPersonTest()
        {
            Person personJames = new Person();

            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);
           // int Addcust = personManager.AddCustomer( "Jerry", "Jonah", "BOLD5", "Jerry@gmail.com", "Create5", "7778DC", "Customer");
          
            bool resultc = personManager.AddPerson("Jerry", "Jonah", "BOLD5", "Jerry@gmail.com", "Create5", "7778DC", "Customer");
            bool resulta = personManager.AddPerson("Mercy", "David", "Happy7", "Mercy@gmail.com", "Create5", "7778DC", "Customer");


            Assert.IsTrue(resulta);
            Assert.IsTrue(resultc);
        }
      

        [TestMethod]
        public void AddPersonInvalidEmail()
        {
            Person personJames = new Person();
            personJames.ID = 1;
            personJames.Email = "dan@";

            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);

            Assert.IsNotNull("dan@", personJames.Email);

           // Assert.IsNull(result);
        }


        [TestMethod]
        public void GetNonPersonIDTest()
        {
            Person personJames = new Person();
         
            personJames.Email = "dan@gmail.com.com";
           
            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);
           // personManager.GetPerson(-11);
            Assert.AreNotEqual(-1,personJames.ID);
        }

     
        [TestMethod]
        public void GetNonPersonLastNameTest()
        {
            Person personJames = new Person();
          
            personJames.Email = "dan@gmail.com.nl";
            personJames.FirstName = "Smith";
          

            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);
         
            Assert.IsNull( personJames.LastName);
          
        }

        [TestMethod]
        public void GetNonPersonZipcodeTest()
        {
            Person personJames = new Person();
            personJames.ID = 1;
            personJames.Email = "dan@gmail.com.nl";
            personJames.FirstName = "Jenny";
            personJames.LastName = "Smith";
           // personJames.Zipcode = "Mediabaar";

            PersonRePositoryTest positoryTest = new PersonRePositoryTest(new List<Person>() { personJames });

            PersonManager personManager = new PersonManager(positoryTest);



            Assert.IsNull( personJames.Zipcode);
        }
    }





}

