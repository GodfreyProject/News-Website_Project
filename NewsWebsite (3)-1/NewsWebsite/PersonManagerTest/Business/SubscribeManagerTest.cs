using Microsoft.VisualStudio.TestTools.UnitTesting;
using News_ClassLibrary.Business.Logic.Model;
using News_ClassLibrary.Business.ManagerClasses;
using PersonManagerTest.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagerTest.Business
{
    [TestClass]
   public class SubscribeManagerTest
    {
        [TestMethod]
        public void SubscribeTest()
        {
            SubScription scription = new SubScription();

            scription.SubID = 1;
            FakeSubscribeRepository fakeSubscribe = new FakeSubscribeRepository(new List<SubScription>() { scription });

            SubscribeManager subscribeManager = new SubscribeManager(fakeSubscribe);

           

            bool results1 = subscribeManager.Subscribe("Jasmine", "David", "Jasmine@gmail.com", "€15", "May", "Payed");
            bool results2 = subscribeManager.Subscribe("Bob", "Joe", "Bob@gmail.com", "€5", "August", "Payed");


            Assert.IsTrue(true, results1.ToString());
            Assert.IsTrue(true, results2.ToString());
        }

        [TestMethod]
        public void DuplicatedSubscibeTest()
        {
            SubScription scription = new SubScription();

            scription.SubID = 2;
            FakeSubscribeRepository fakeSubscribe = new FakeSubscribeRepository(new List<SubScription>() { scription });

            SubscribeManager subscribeManager = new SubscribeManager(fakeSubscribe);

            bool results1 = subscribeManager.Subscribe("Jasmine", "David", "Jasmine@gmail.com", "€15", "May", "Payed");
            bool results2 = subscribeManager.Subscribe("Jasmine", "David", "Jasmine@gmail.com", "€15", "May", "Payed");

            Assert.IsFalse( results1);
            Assert.IsFalse( results2);
        }

        [TestMethod]
        public void UnSubscribeTest()
        {
            SubScription scription = new SubScription();

            scription.SubID = 1;
            FakeSubscribeRepository fakeSubscribe = new FakeSubscribeRepository(new List<SubScription>() { scription });

            SubscribeManager subscribeManager = new SubscribeManager(fakeSubscribe);



            bool results1 = subscribeManager.Subscribe("Jasmine", "David", "Jasmine@gmail.com", "€15", "May", "Payed");
        
            bool results3 = subscribeManager.UnSubscribe(1);

           
            Assert.IsTrue(results3);
        }

        [TestMethod]
        public void SubscribeNoPaymentTest()
        {
            SubScription scription = new SubScription();
            scription.SubID = 1;
            //scription.Payment = string.Empty;
            scription.FirstName = "Jasmine";
            FakeSubscribeRepository fakeSubscribe = new FakeSubscribeRepository(new List<SubScription>() { scription });

            SubscribeManager subscribeManager = new SubscribeManager(fakeSubscribe);


            Assert.IsNull(scription.Payment);
        }

        [TestMethod]
        public void SubscribeNonFirstNameTest()
        {
            SubScription scription = new SubScription();
            scription.SubID = 1;
            scription.Payment = "€15";
            scription.FirstName = String.Empty;
            scription.LastName = "David";
            FakeSubscribeRepository fakeSubscribe = new FakeSubscribeRepository(new List<SubScription>() { scription });

            SubscribeManager subscribeManager = new SubscribeManager(fakeSubscribe);



            bool results1 = subscribeManager.Subscribe("Jasmine", "David", "Jasmine@gmail.com", "€15", "May", "Payed");

            Assert.IsFalse(results1);
        }

        [TestMethod]
        public void GetAllSubscribersTest()
        {
            SubScription scription = new SubScription();

            scription.SubID = 1;
            FakeSubscribeRepository fakeSubscribe = new FakeSubscribeRepository(new List<SubScription>() { scription });

            SubscribeManager subscribeManager = new SubscribeManager(fakeSubscribe);

            List<SubScription> Actualsub =  subscribeManager.GetAllSubsscription();


            bool results1 = subscribeManager.Subscribe("Jasmine", "David", "Jasmine@gmail.com", "€15", "May", "Payed");
          

            List<SubScription> subcribe = subscribeManager.GetAllSubsscription();


            CollectionAssert.AreEquivalent(Actualsub, subcribe);
            
        }

        [TestMethod]
        public void GetSubscribersWithFirstNameTest()
        {
            SubScription scription = new SubScription();

            scription.SubID = 1;
            FakeSubscribeRepository fakeSubscribe = new FakeSubscribeRepository(new List<SubScription>() { scription });

            SubscribeManager subscribeManager = new SubscribeManager(fakeSubscribe);
            SubscribeManager sub = new SubscribeManager(fakeSubscribe);





            bool results1 = subscribeManager.Subscribe("Jasmine", "David", "Jasmine@gmail.com", "€15", "May", "Payed");
            bool results2 = sub.Subscribe("Bob", "Joe", "Bob@gmail.com", "€5", "August", "Payed");

            List<SubScription> subcribe = subscribeManager.GetSubsscription("Jasmine");


            CollectionAssert.AreEquivalent(subscribeManager.GetAllSubsscription(), subcribe);
           
        }
    }

}

