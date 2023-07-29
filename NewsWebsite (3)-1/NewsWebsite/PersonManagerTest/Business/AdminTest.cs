using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynthesisClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagerTest.Business
{
    [TestClass]
    public class AdminTest
    {
        [TestMethod]
        public void ConstructorAdminTest()
        {
            // Assert
            Admin a = new Admin("Danny", "Jacobs", "Danny", "Danny@gmail.com", "Grow25", "6754AD", "Admin");


            // Assert

            Assert.AreEqual("Danny", a.FirstName);
            Assert.AreEqual("Jacobs", a.LastName);
            Assert.AreEqual("Danny", a.Username);
            Assert.AreEqual("Danny@gmail.com", a.Email);
            Assert.AreEqual("Grow25", a.Password);
            Assert.AreEqual("6754AD", a.Zipcode);
            Assert.AreEqual("Admin",a.UserRole);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyFirstNameConstructorTest()
        {
            Admin admin = new Admin(String.Empty, "Jacobs", "Danny", "Danny@gmail.com", "Grow25", "6754AD", "Admin");

        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyFirstNameProertyTest()
        {
            Admin admin = new Admin("Dan", "Jacobs", "Danny", "Danny@gmail.com", "Grow25", "6754AD", "Admin");

           admin.FirstName = String.Empty;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyLastNameConstructorTest()
        {
            Admin admin = new Admin(String.Empty, "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Admin");

        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyLastNameProertyTest()
        {
            Admin admin = new Admin("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

            admin.FirstName = String.Empty;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyUsernameNameConstructorTest()
        {
            Admin admin = new Admin(String.Empty, "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Admin");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyEmailConstructorTest()
        {
            Admin admin = new Admin("Sonia", "David", "Great", String.Empty, "Jay75", "4566RD", "Admin");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyEmailPropertyTest()
        {
            Admin admin = new Admin("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Admin");

            admin.Email = String.Empty;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyUsernameNameProertyTest()
        {
            Customer customer = new Customer("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Admin");

            customer.FirstName = String.Empty;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyZipcodeConstructorTest()
        {
            Admin admin = new Admin (String.Empty, "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Admin");

        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyZipcodeNameProertyTest()
        {
            Admin admin = new Admin("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Admin");

            admin.FirstName = String.Empty;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyPasswordConstructorTest()
        {
            Admin admin = new Admin(String.Empty, "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyPasswordNameProertyTest()
        {
            Admin admin = new Admin("Sonia", "David", "Great", "sonia@gmail.com", "Jay75", "4566RD", "Customer");

            admin.FirstName = String.Empty;
        }
    }
}
