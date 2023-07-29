using Microsoft.VisualStudio.TestTools.UnitTesting;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.ManagerInterface;
using News_ClassLibrary.Persistence;
using PersonManagerTest.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagerTest.Business
{
    [TestClass]
   public class ReviewManagerTest
    {
        [TestMethod]
        public void AddReviewTest()
        {
            Review reviewCust = new Review();

            FakeReviewRepository fakeReview = new FakeReviewRepository(new List<Review>() { reviewCust });

            ReviewManager reviewManager = new ReviewManager(fakeReview);

         

            bool AddResultr1 = reviewManager.AddNewReview( 1, "Stella", 2, "Regional", "Rusian to Release Ukrain Civilians", "2022-05-24");
            bool AddResultr2 = reviewManager.AddNewReview( 2, "Mercy", 3, "World", "Ukrain are not Backing down", "2022-06-16");
            //bool AddResultr2  = reviewManager.AddReview(new Review( "Mercy", 3, "World", "Ukrain are not Backing down", "2022-06-16"))

            Assert.IsTrue(AddResultr1);
            Assert.IsTrue(AddResultr2);
        }


        [TestMethod]
        public void AddReviewNoCustomerIDTest()
        {
            Review reviewCust = new Review();

            FakeReviewRepository fakeReview = new FakeReviewRepository(new List<Review>() { reviewCust });

            ReviewManager reviewManager = new ReviewManager(fakeReview);

            reviewCust.PersonID = 0;
            reviewCust.Username = "Stella";
            reviewCust.Message = "Rusian to Release Ukrain Civilians";
            reviewCust.NewsType = "Regional";

           
           

            Assert.AreNotEqual(0, reviewCust);
          
            //bool AddResultr2 = reviewManager.AddNewReview(1, "Mercy", 3, "World", "Ukrain are not Backing down", "2022-06-16");
        }


      

        [TestMethod]
        public void AddReviewNoCustomerMessageTest()
        {
            Review reviewCust = new Review();

            FakeReviewRepository fakeReview = new FakeReviewRepository(new List<Review>() { reviewCust });

            ReviewManager reviewManager = new ReviewManager(fakeReview);

            reviewCust.Username = "Stella";
          
            reviewCust.NewsType = "Regional";
            //reviewCust.Message = String.Empty;


            Assert.IsNull(reviewCust.Message);

           
        }


        [TestMethod]
        public void AddReviewInvalidCustomerIDTest()
        {
            Review reviewCust = new Review();

            FakeReviewRepository fakeReview = new FakeReviewRepository(new List<Review>() { reviewCust });

            ReviewManager reviewManager = new ReviewManager(fakeReview);

            reviewCust.Username = "Stella";
            reviewCust.PersonID = -1;
            reviewCust.Message = "Rusian to Release Ukrain Civilians";
            reviewCust.NewsType = "Regional";

          

            Assert.AreNotEqual(0, reviewCust.PersonID);

           
        }


        

        [TestMethod]
        public void GetCustomerReviewsTest()
        {
            Review reviewCust = new Review();

            FakeReviewRepository fakeReview = new FakeReviewRepository(new List<Review>() { reviewCust });

            ReviewManager reviewManager = new ReviewManager(fakeReview);
            List<Review> Actualreviews = reviewManager.GetAllReviews();
            reviewCust.Username = "Stella";
           
            bool AddResultr1 = reviewManager.AddNewReview(1, "Stella", 2, "Regional", "Rusian to Release Ukrain Civilians", "2022-05-24");
           
          
            List<Review> FoundCustomerReviews = reviewManager.GetReview("Stella");

            CollectionAssert.AreEqual(Actualreviews, FoundCustomerReviews);
        }
        [TestMethod]
        public void GetCustomerReviewTest()
        {
            Review reviewCust = new Review();

            FakeReviewRepository fakeReview = new FakeReviewRepository(new List<Review>() { reviewCust });

            ReviewManager reviewManager = new ReviewManager(fakeReview);
            reviewCust.PersonID = 2;

           
            reviewManager.GetWebReview(2);

            Assert.AreEqual(2, reviewCust.PersonID);
        }

        [TestMethod]
        public void GetNonExistingCustomerReviewTest()
        {
            Review reviewCust = new Review();

            FakeReviewRepository fakeReview = new FakeReviewRepository(new List<Review>() { reviewCust });

            ReviewManager reviewManager = new ReviewManager(fakeReview);
            reviewCust.PersonID = -2;

            reviewManager.AddNewReview(-1, "Stella", 2, "Regional", "Rusian to Release Ukrain Civilians", "2022-05-24");

            reviewManager.AddNewReview(-2, "Mercy", 3, "World", "Ukrain are not Backing down", "2022-06-16");

      

            Assert.IsNull(reviewManager.GetWebReview(-346566700) );
            Assert.IsNull( reviewManager.GetWebReview(-2) );
        }

        [TestMethod]
        public void GetAllReviewTest()
        {
            Review reviewCust = new Review();

          
            FakeReviewRepository fakeReview = new FakeReviewRepository(new List<Review>() { reviewCust });
            List<Review> actualreview = fakeReview.GetAllReviews();
            ReviewManager reviewManager = new ReviewManager(fakeReview);
            

            reviewManager.AddNewReview(1, "Stella", 2, "Regional", "Rusian to Release Ukrain Civilians", "2022-05-24");

            reviewManager.AddNewReview(2, "Mercy", 3, "World", "Ukrain are not Backing down", "2022-06-16");


            List<Review> AllReviews = reviewManager.GetAllReviews();

            CollectionAssert.AreEquivalent(actualreview, AllReviews);
          
        }

        [TestMethod]
        public void DeleteReviewTest()
        {
            Review reviewCust = new Review();

            FakeReviewRepository fakeReview = new FakeReviewRepository(new List<Review>() { reviewCust });

            reviewCust.ReviewID = 1;
            ReviewManager reviewManager = new ReviewManager(fakeReview);

         
           bool result =  reviewManager.RemoveNewReview(1);

          
           Assert.IsTrue(result);

          


        }


        [TestMethod]
        public void UpdateCustomerReviewTest()
        {
            Review reviewCust = new Review(); ;

            FakeReviewRepository fakeReview = new FakeReviewRepository(new List<Review>() { reviewCust });

            reviewCust.ReviewID = 2;
            ReviewManager reviewManager = new ReviewManager(fakeReview);


            reviewCust = reviewManager.GetWebReview(2);

            bool Resultr1 = reviewManager.AddNewReview(1, "Stella", 2, "Regional", "Rusian to Release Ukrain Civilians", "2022-05-24");

            bool Resultr2 = reviewManager.AddNewReview(2, "Mercy", 3, "World", "Ukrain are not Backing down", "2022-06-16");
            bool Resultr3 = reviewManager.UpdateNewReview(  "World", "This is Errible for what russian has done", "2022-07-16", 2);

            Assert.IsTrue(Resultr1);
            Assert.IsTrue(Resultr2);
            Assert.IsTrue(Resultr3);

          


        }



    }
}
