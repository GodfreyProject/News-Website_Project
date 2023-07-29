using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynthesisClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagerTest.Business
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void ConstructorCustomerTest()
        {
            // Assert
            Customer customer = new Customer("Sonia", "David", "Great", "sonia@gmail.com", "Jay75" ,"4566RD", "Customer");


            // Assert

            Assert.AreEqual("Sonia", customer.FirstName);
            Assert.AreEqual("David", customer.LastName);
            Assert.AreEqual("Great", customer.Username);
            Assert.AreEqual("sonia@gmail.com", customer.Email);
            Assert.AreEqual("Jay75", customer.Password);
            Assert.AreEqual("4566RD", customer.Zipcode);
            Assert.AreEqual("Customer", customer.UserRole);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyFirstNameConstructorTest()
        {
            Customer customer = new Customer(String.Empty, "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyFirstNameProertyTest()
        {
            Customer customer = new Customer("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

            customer.FirstName = String.Empty;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyLastNameConstructorTest()
        {
            Customer customer = new Customer(String.Empty, "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyLastNameProertyTest()
        {
            Customer customer = new Customer("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

            customer.FirstName = String.Empty;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyUsernameNameConstructorTest()
        {
            Customer customer = new Customer(String.Empty, "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyUsernameNameProertyTest()
        {
            Customer customer = new Customer("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

            customer.FirstName = String.Empty;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyZipcodeConstructorTest()
        {
            Customer customer = new Customer(String.Empty, "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyZipcodeNameProertyTest()
        {
            Customer customer = new Customer("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

            customer.FirstName = String.Empty;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyPasswordConstructorTest()
        {
            Customer customer = new Customer(String.Empty, "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyPasswordNameProertyTest()
        {
            Customer customer = new Customer("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

            customer.FirstName = String.Empty;
        }
    }
}
