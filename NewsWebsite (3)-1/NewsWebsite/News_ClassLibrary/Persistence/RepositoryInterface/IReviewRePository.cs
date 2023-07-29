using News_ClassLibrary.Logic.Classes;
using SynthesisClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace News_ClassLibrary.ManagerInterface
{
   public interface IReviewRePository
    {
        public List<Review> GetAllReviews();

        public  List<Review> GetReview(String Username);

        public Review Review(String Username);

        public Review GetWebReview(int ID);


        // Add Comment

        public bool AddReview(Customer customer, NewsArticle newsArticle, string Message, string Date);

        // Web Application ASP.NET CORE
        public bool AddNewReview(int EmployeeID, String Username, int NewsId, String NewsType, string Message, string Date);
        // Update

        public bool UpdateReview(Customer customer, NewsArticle newsArticle, string Message, string Date, int ID);//, String Username);

        public bool UpdateNewReview(String NewsType, string Message, string Date, int ComID);
        // Delete

        public bool RemoveReview(int ID);

        public bool RemoveNewReview(int ID);


        }
}
