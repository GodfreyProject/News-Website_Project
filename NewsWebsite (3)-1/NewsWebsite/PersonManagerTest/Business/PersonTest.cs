using ClassLibrary.Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.ManagerClasses;
//using SynthesisClassLibrary.TestClasses;
using System;
using Xunit.Sdk;

namespace PersonManagerTest
{
    [TestClass]
  
    public class PersonTest
    {
        PersonManager personManager = new PersonManager(new PersonRePository());
        [TestMethod]
        public void AddPersonTest()
        {
            //Assert 

            Person p1 = new Customer("Yellow", "Daniel", "Yelow", "yellow@gmail.com", "Dan45", "4576AD", "Customer");
            Person p2 = new Admin( "Daniel", "James", "Make3", "James@gmail.com", "Dan45", "4576AD", "Admin");
            
            
          
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyUsernameNameProertyTest()
        {
            Person customer = new Person("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

            customer.Username = String.Empty;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyPasswordProertyTest()
        {
            Person customer = new Person("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

            customer.Password = String.Empty;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyZipcodeProertyTest()
        {
            Person customer = new Person("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

            customer.Zipcode = String.Empty;
        }




    }
}
