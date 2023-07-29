using ClassLibrary.Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using PersonManagerTest.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagerTest.Business
{
    [TestClass]
    public class ContactManagerTest
    {
        [TestMethod]
        public void AddContactTest()
        {
            Contact contactDaniel = new Contact();
            FakeContactRepository fakeContact = new FakeContactRepository(new List<Contact>() { contactDaniel });
            ContactManager c = new ContactManager(fakeContact);

            List<Contact> autual = c.GetContacts();
          
            bool resultct1 = c.AddNewContact(1, "Daniel", "Daniel@gmail.com", "Your Website is very Educative");
            bool resultct2 = c.AddNewContact(2, "Jasmine", "Jasmine@gmail.com", "Your Website is very Educative and interesting");

            List<Contact> contacts = c.GetContacts();

            CollectionAssert.AreEqual(autual, contacts);
        }

        [TestMethod]
        public void AddContactDuplicateTest()
        {
            Contact contactDaniel = new Contact();
            FakeContactRepository fakeContact = new FakeContactRepository(new List<Contact>() { contactDaniel });
            ContactManager c = new ContactManager(fakeContact);
          

            bool resultct1 = c.AddNewContact(1, "Daniel", "Daniel@gmail.com", "Your Website is very Educative");
            bool resultct2 = c.AddNewContact(1, "Daniel", "Daniel@gmail.com", "Your Website is very Educative");
            //bool resultct2 = c.AddNewContact(2, "Jasmine", "Jasmine@gmail.com", "Your Website is very Educative and interesting");

            Assert.IsFalse(resultct1);
            Assert.IsFalse(resultct2);
        }

        [TestMethod]
        public void AddContactNoContactIDTest()
        {
            Contact contactDaniel = new Contact();
            FakeContactRepository fakeContact = new FakeContactRepository(new List<Contact>() { contactDaniel });
            ContactManager c = new ContactManager(fakeContact);
          

            bool resultct1 = c.AddNewContact(-1, "Daniel", "Daniel@gmail.com", "Your Website is very Educative");
            // bool resultct2 = c.AddNewContact(2, "Jasmine", "Jasmine@gmail.com", "Your Website is very Educative and interesting");

            Assert.IsFalse(resultct1);
        }
       

        [TestMethod]
        public void AddContactNonContactEmailTest()
        {
            Contact contactDaniel = new Contact();
            FakeContactRepository fakeContact = new FakeContactRepository(new List<Contact>() { contactDaniel });
            ContactManager c = new ContactManager(fakeContact);
          

            bool resultct1 = c.AddNewContact(1, "Daniel", "0044", "Your Website is very Educative");
           
            Assert.IsFalse(resultct1);
        }
        [TestMethod]
        public void AddContactNoNContactSubjectTest()
        {
            Contact contactDaniel = new Contact();
            FakeContactRepository fakeContact = new FakeContactRepository(new List<Contact>() { contactDaniel });
            ContactManager c = new ContactManager(fakeContact);
          

            bool resultct1 = c.AddNewContact(1, "Daniel", "Daniel@gmail.com", "123445");
            // bool resultct2 = c.AddNewContact(2, "Jasmine", "Jasmine@gmail.com", "Your Website is very Educative and interesting");

            Assert.IsFalse(resultct1);
        }
        [TestMethod]
        public void AddContactContactInvaEmailTest()
        {
            Contact contactDaniel = new Contact();
            FakeContactRepository fakeContact = new FakeContactRepository(new List<Contact>() { contactDaniel });
            ContactManager c = new ContactManager(fakeContact);
          


            bool resultct1 = c.AddNewContact(1, "Daniel", "Danie", "Your Website is very Educative");
            // bool resultct2 = c.AddNewContact(2, "Jasmine", "Jasmine@gmail.com", "Your Website is very Educative and interesting");

            Assert.IsFalse(resultct1);
        }

        [TestMethod]
        public void GetContactTest()
        {

            Contact contactDaniel = new Contact();
            FakeContactRepository fakeContact = new FakeContactRepository(new List<Contact>() { contactDaniel });
            ContactManager c = new ContactManager(fakeContact);
            Contact ct1 = new Contact(1, 2, "Daniel", "Daniel@gmail.com", "Your Website is very Educative");

            contactDaniel.ContactID = 2;
             c.AddNewContact(1, "Jonah", "Daniel@gmail.com", "Your Website is very Educative");

             c.AddNewContact(2, "Daniel", "Daniel@gmail.com", "Your Website is very Educative");

            Contact FoundCustomerContact = c.GetContact(2);

            Assert.AreEqual(FoundCustomerContact, contactDaniel);

        }

        [TestMethod]
        public void GetContactNonExistingTest()
        {

            Contact contactDaniel = new Contact();
            FakeContactRepository fakeContact = new FakeContactRepository(new List<Contact>() { contactDaniel });
            ContactManager c = new ContactManager(fakeContact);
            
          
            c.AddNewContact(-2, "Jonah", "Daniel@gmail.com", "Your Website is very Educative");

         

            Contact FoundCustomerContact = c.GetContact(-2);

            Assert.IsNull(FoundCustomerContact );
          
        }


        [TestMethod]
        public void GetAllContactsTest()
        {

            Contact contactDaniel = new Contact();
            FakeContactRepository fakeContact = new FakeContactRepository(new List<Contact>() { contactDaniel });

            
            ContactManager c = new ContactManager(fakeContact);
            List<Contact> auctualContacts = c.GetContacts();
            Contact ct1 = new Contact(1, 2, "Daniel", "Daniel@gmail.com", "Your Website is very Educative");

            contactDaniel.ContactID = 2;
            c.AddNewContact(1, "Jonah", "Daniel@gmail.com", "Your Website is very Educative");

            c.AddNewContact(2, "Daniel", "Daniel@gmail.com", "Your Website is very Educative");

            List<Contact> contacts = c.GetContacts();

            CollectionAssert.AreEquivalent(auctualContacts, contacts);

        }


    }
}
