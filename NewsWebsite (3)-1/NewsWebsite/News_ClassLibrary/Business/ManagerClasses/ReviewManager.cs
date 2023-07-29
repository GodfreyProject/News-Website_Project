
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerInterface;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace News_ClassLibrary.ManagerClasses
{
    public class ReviewManager
    {
        private IReviewRePository reviewRePository;

        public ReviewManager(IReviewRePository RePository)
        {
            reviewRePository = RePository;
        }

      
        public bool AddReview(Customer customer, NewsArticle newsArticle, string Message, string Date)
        {
            if(this.reviewRePository.AddReview(customer, newsArticle, Message, Date))
            {
                return true;
            }

            return false;
        }
        public bool AddNewReview(int EmployeeID, String Username, int NewsId, String NewsType, string Message, string Date)
        {
            if(this.reviewRePository.AddNewReview(EmployeeID, Username, NewsId, NewsType, Message, Date))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Review> GetAllReviews()
        {
            return this.reviewRePository.GetAllReviews();
        }

        public List<Review> GetReview(String Username)
        {
            return this.reviewRePository.GetReview(Username);
        }

        public Review GetWebReview(int ID)
        {
            return this.reviewRePository.GetWebReview(ID);
        }
        public Review Review(String Username)
        {
            return this.reviewRePository.Review(Username);
        }
        public bool RemoveReview(int ID)
        {
            if (reviewRePository.RemoveReview(ID))
            {
                return true;
            }

            return false;
        }

        public bool RemoveNewReview(int ID)
        {
            if (reviewRePository.RemoveNewReview(ID))
            {
                return true;
            }

            return false;
        }

        public bool UpdateReview(Customer customer, NewsArticle newsArticle, string Message, string Date, int ID)//, string Username)
        {
           if(this.reviewRePository.UpdateReview(customer, newsArticle, Message, Date, ID))
            {
                return true;
            }

            return false;
        }

        public bool UpdateNewReview( String NewsType, string Message, string Date, int ComID)//, String Username, int NewsId, String NewsType, string Message, string Date, int ComID)
        {
            if (this.reviewRePository.UpdateNewReview( NewsType, Message, Date, ComID)) //Username, NewsId, NewsType, Message, Date, ComID))
            {
                return true;
            }

            return false;
        }
    }
}
