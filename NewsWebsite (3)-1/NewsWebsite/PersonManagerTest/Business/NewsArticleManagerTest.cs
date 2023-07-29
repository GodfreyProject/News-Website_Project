using Microsoft.VisualStudio.TestTools.UnitTesting;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using PersonManagerTest.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagerTest.Business
{
    [TestClass]
    public class NewsArticleManagerTest
    {
        [TestMethod]


        public void GetAticleTest()
        {
            NewsArticle newsContent = new NewsArticle();

            newsContent.NewsID = 1;
            FakeArticleRepository fakeArticleRepo = new FakeArticleRepository(new List<NewsArticle>() { newsContent });
            NewsArticleManager manager = new NewsArticleManager(fakeArticleRepo);

            NewsArticle n1 = new NewsArticle(1, "Regional", "Byte", "Zelesky has won European", "'Warns European not to Buy Russia Oil", "David", "2022-04-15");
            NewsArticle n2 = new NewsArticle(2, "Regional", "Byte", "Zelesky has won European", "'Warns European not to Buy Russia Oil", "David", "2022-04-15");

            manager.AddArticle(n1);
            manager.AddArticle(n2);

            NewsArticle FoundContent = manager.GetArticle(1);

            Assert.AreEqual(1, FoundContent.NewsID);
        }

        [TestMethod]
        public void GetAticleNewsTypeTest()
        {
            NewsArticle newsContent = new NewsArticle();

            newsContent.NewsType = "BUSINESS";
            FakeArticleRepository fakeArticleRepo = new FakeArticleRepository(new List<NewsArticle>() { newsContent });
            NewsArticleManager manager = new NewsArticleManager(fakeArticleRepo);

            NewsArticle n1 = new NewsArticle(1, "BUSINESS", "Byte", "Zelesky has won European", "'Warns European not to Buy Russia Oil", "David", "2022-04-15");
           
            manager.AddArticle(n1);
           
            NewsArticle FoundContent = manager.GetArticle("BUSINESS");

            Assert.IsNotNull(FoundContent);
        }


        [TestMethod]
        public void GetNonNewsArticleExistingTest()
        {
            NewsArticle newsContent = new NewsArticle();
            FakeArticleRepository fakeArticleRepo = new FakeArticleRepository(new List<NewsArticle>() { newsContent });
            NewsArticleManager manager = new NewsArticleManager(fakeArticleRepo);

            NewsArticle n2 = new NewsArticle(-2, "Regional", "Byte", "Zelesky has won European", "'Warns European not to Buy Russia Oil", "David", "2022-04-15");

            manager.AddArticle(n2);

            Assert.IsNull( manager.GetArticle(2346575));
           
        }


        [TestMethod]
        public void GetAllAriclesTest()
        {
            NewsArticle newsContent = new NewsArticle();


            FakeArticleRepository fakeArticleRepo = new FakeArticleRepository(new List<NewsArticle>() { newsContent });
            NewsArticleManager manager = new NewsArticleManager(fakeArticleRepo);

            NewsArticle n1 = new NewsArticle(1, "Regional", "Byte", "Zelesky has won European", "'Warns European not to Buy Russia Oil", "David", "2022-04-15");
            NewsArticle n2 = new NewsArticle(2, "Regional", "Byte", "Zelesky has won European", "'Warns European not to Buy Russia Oil", "David", "2022-04-15");

            manager.AddArticle(n1);
            manager.AddArticle(n2);

            List<NewsArticle> FoundContents = manager.GetAllNewsArticles();

            CollectionAssert.AreEquivalent(new List<NewsArticle>() { newsContent }, FoundContents);

        }

        [TestMethod]
        public void AddNewsArticleInvalidNewsTypeTest()
        {
            NewsArticle newsContent = new NewsArticle();

            newsContent.NewsID = 1;
            newsContent.Title = "Russian haa lost the battle";
            newsContent.NewsType = "1234";
            FakeArticleRepository fakeArticleRepo = new FakeArticleRepository(new List<NewsArticle>() { newsContent });
            NewsArticleManager manager = new NewsArticleManager(fakeArticleRepo);


            manager.GetNewsType("1234");

            Assert.AreNotEqual(newsContent, manager);


        }
       
       
       
        
        [TestMethod]
        public void AddNewsArticleTest()
        {
            NewsArticle newsContent = new NewsArticle();

            newsContent.NewsID = 1;
           
            newsContent.Title = "Russian haa lost the battle";
            newsContent.Author = "Daniel";
            FakeArticleRepository fakeArticleRepo = new FakeArticleRepository(new List<NewsArticle>() { newsContent });
            NewsArticleManager manager = new NewsArticleManager(fakeArticleRepo);
            NewsArticle n1 = new NewsArticle(1, "Regional", "Byte", "Zelesky has won European", "'Warns European not to Buy Russia Oil", "David", "2022-04-15");
            NewsArticle n2 = new NewsArticle(2, "Sport", "Byte", "Liverpool has Qualified", "'by defeating PSG", "Daniel", "2022-06-15");


          

            bool resultn1 = manager.AddArticle(n1);
            bool resultn2 = manager.AddArticle(n2);

            Assert.IsTrue( resultn1);
            //Assert.IsTrue( resultn2);


        }


        [TestMethod]
        public void AddNewArticleTest()
        {
            NewsArticle newsContent = new NewsArticle();
        
            FakeArticleRepository fakeArticleRepo = new FakeArticleRepository(new List<NewsArticle>() { newsContent });
            NewsArticleManager manager = new NewsArticleManager(fakeArticleRepo);

            bool Result1 = manager.AddArticle(new NewsArticle("Sport", (byte[])newsContent.Photo, "Liverpool has Qualified", "'by defeating PSG", "Daniel", "2022-06-15"));
            bool Result2 = manager.AddArticle(new NewsArticle("Regional", (byte[])newsContent.Photo, "Liverpool has Qualified", "'by defeating PSG", "Daniel", "2022-06-15"));

            Assert.IsTrue(Result2);
            Assert.IsTrue(Result1);
        }

        [TestMethod]
       // public bool AddNewsContent(string NewsType, byte[] Photo, string Title, string Description, string Author, string Date)
        public void AddNewsContentTest()
        {
            NewsArticle newsContent = new NewsArticle();
          
            FakeArticleRepository fakeArticleRepo = new FakeArticleRepository(new List<NewsArticle>() { newsContent });
            NewsArticleManager manager = new NewsArticleManager(fakeArticleRepo);

            bool Result1 = manager.AddArticle(new NewsArticle("Sport", (byte[])newsContent.Photo, "Liverpool has Qualified", "'by defeating PSG", "Daniel", "2022-06-15"));
            bool Result2 = manager.AddArticle(new NewsArticle("Business", (byte[])newsContent.Photo, "Liverpool has Qualified", "'by defeating PSG", "Daniel", "2022-06-15"));

            Assert.IsTrue( Result1);
            Assert.IsTrue( Result2);
        }

        [TestMethod]
        public void UpdateAriclesTest()
        {
            NewsArticle newsContent = new NewsArticle();


            FakeArticleRepository fakeArticleRepo = new FakeArticleRepository(new List<NewsArticle>() { newsContent });
            NewsArticleManager manager = new NewsArticleManager(fakeArticleRepo);

            NewsArticle n1 = new NewsArticle(1, "Regional", "Byte", "Zelesky has won European", "'Warns European not to Buy Russia Oil", "David", "2022-04-15");
            NewsArticle n2 = new NewsArticle(2, "Regional", "Byte", "Zelesky has won European", "'Warns European not to Buy Russia Oil", "David", "2022-04-15");

            manager.GetArticle(2);
           bool result =  manager.UpdateArticle(n2);

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void DeleteNewsArticleTest()
        {
            NewsArticle newsContent = new NewsArticle();


            FakeArticleRepository fakeArticleRepo = new FakeArticleRepository(new List<NewsArticle>() { newsContent });
            NewsArticleManager manager = new NewsArticleManager(fakeArticleRepo);
            //newsContent.NewsID = 3;
            NewsArticle n1 = new NewsArticle(1, "Regional", "Byte", "Zelesky has won European", "'Warns European not to Buy Russia Oil", "David", "2022-04-15");
          
            NewsArticle n3 = new NewsArticle(3, "Sport", "Byte", "Zelesky has won European", "'Warns European not to Buy Russia Oil", "David", "2022-06-15");

           bool result1 = manager.AddArticle(n1);
          
            bool result3 = manager.RemoveContent(1);

           


        }
    }
}