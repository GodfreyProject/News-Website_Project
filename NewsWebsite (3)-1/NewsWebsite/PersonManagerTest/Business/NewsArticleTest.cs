using Microsoft.VisualStudio.TestTools.UnitTesting;
using News_ClassLibrary.Logic.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagerTest.Business
{
    [TestClass]
    public class NewsArticleTest
    {
        [TestMethod]
        public void ConstructorNewsArticleTest()
        {
            // Arrange
            NewsArticle news = new NewsArticle(1, "Sports", " speak.png", "ManChester united are Out", "From UFL Championship", "David Allen", "20/3/2022");

            //Assert

            Assert.AreEqual(1, news.NewsID);

            Assert.AreEqual("Sports", news.NewsType);

            //Assert.AreEqual("speak.png", news.Img);

            Assert.AreEqual("ManChester united are Out", news.Title);
            Assert.AreEqual("From UFL Championship", news.Description);
            Assert.AreEqual("David Allen", news.Author);
            Assert.AreEqual("20/3/2022", news.Date);
        }

        [TestMethod]
        public void ConstructorNewsArticleTest1()
        {
            // Arrange
            NewsArticle news = new NewsArticle(1, "Sports", " speak.png", "ManChester united are Out", "From UFL Championship", "David Allen", "20/3/2022");

            //Assert

            Assert.AreEqual(1, news.NewsID);

            Assert.AreEqual("Sports", news.NewsType);

            //Assert.AreEqual("speak.png", news.Img);

            Assert.AreEqual("ManChester united are Out", news.Title);
            Assert.AreEqual("From UFL Championship", news.Description);
            Assert.AreEqual("David Allen", news.Author);
            Assert.AreEqual("20/3/2022", news.Date);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyNewsTypeNameConstructorTest()
        {
            NewsArticle news = new NewsArticle(1, String.Empty, " speak.png", "ManChester united are Out", "From UFL Championship", "David Allen", "20/3/2022");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyNewsTypeNamePropertyTest()
        {
            NewsArticle news = new NewsArticle(1, "Sports", "speak.png", "ManChester united are Out", "From UFL Championship", "David Allen", "20/3/2022");

            news.NewsType = String.Empty;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyTitleNameConstructorTest()
        {
            NewsArticle news = new NewsArticle(1, String.Empty, " speak.png", "ManChester united are Out", "From UFL Championship", "David Allen", "20/3/2022");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyTitleNamePropertyTest()
        {
            NewsArticle news = new NewsArticle(1, "Sports", "speak.png", String.Empty, "From UFL Championship", "David Allen", "20/3/2022");

            news.NewsType = String.Empty;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyDescriptionConstructorTest()
        {
            NewsArticle news = new NewsArticle(1,"'Sports", " speak.png", "ManChester united are Out", String.Empty, "David Allen", "20/3/2022");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyDescriptionPropertyTest()
        {
            NewsArticle news = new NewsArticle(1, "Sports", "speak.png", "ManChester united are Out", "From UFL Championship", "David Allen", "20/3/2022");

            news.NewsType = String.Empty;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyAuthorNameConstructorTest()
        {
            NewsArticle news = new NewsArticle(1, "Sports", " speak.png", "ManChester united are Out", "From UFL Championship", String.Empty, "20/3/2022");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyAuthorNamePropertyTest()
        {
            NewsArticle news = new NewsArticle(1, "Sports", "speak.png", "ManChester united are Out", "From UFL Championship", "David Allen", "20/3/2022");

            news.NewsType = String.Empty;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyDateConstructorTest()
        {
            NewsArticle news = new NewsArticle(1, "Sports", " speak.png", "ManChester united are Out", "From UFL Championship", "David Allen",String.Empty);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyDatePropertyTest()
        {
            NewsArticle news = new NewsArticle(1, "Sports", "speak.png", "ManChester united are Out", "From UFL Championship", "David Allen", "20/3/2022");

            news.NewsType = String.Empty;
        }
    }

}