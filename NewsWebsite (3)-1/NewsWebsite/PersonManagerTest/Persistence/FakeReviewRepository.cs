using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerInterface;
using SynthesisClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagerTest.Persistence
{
    public class FakeReviewRepository : IReviewRePository
    {
        public List<Review> reviews;

        public FakeReviewRepository(List<Review> AllReviews)
        {
            reviews = AllReviews;
        }
        public bool AddNewReview(int EmployeeID, string Username, int NewsId, string NewsType, string Message, string Date)
        {
            Review review = new Review(0, EmployeeID, Username, NewsId, NewsType, Message, Date);

            if (reviews.Count > 0)
            {
                this.reviews.Add(review);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddReview(Customer customer, NewsArticle newsArticle, string Message, string Date)
        {
            if(reviews.Count > 0)
            {
                Review review = new Review(0,customer, newsArticle, Message, Date);
                this.reviews.Add(review);

                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Review> GetAllReviews()
        {
            return this.reviews;
        }

        public List<Review> GetReview(string Username)
        {

            return this.reviews;
        }

        public Review GetWebReview(int ID)
        {
           foreach(Review review in this.reviews)
            {
                if(review.ReviewID == ID)
                {
                    return review;
                }
            }

            return null;
        }

        public bool RemoveNewReview(int ID)
        {
            foreach(Review r in reviews)
            {
                if(r.ReviewID == ID)
                {
                    this.reviews.Remove(r);

                    return true;
                }
            }

            return false;
        }

        public bool RemoveReview(int ID)
        {
            foreach (Review r in reviews)
            {
                if (r.ReviewID == ID)
                {
                    this.reviews.Remove(r);

                    return true;
                }
            }

            return false;
        }

        public Review Review(string Username)
        {
            foreach (Review r in reviews)
            {
                if (r.Username == Username)
                {
                    return r;
                }
            }

            return null;
        }

        public bool UpdateNewReview(string NewsType, string Message, string Date, int ComID)
        {
            foreach (Review p in reviews)
            {
                if (p.ReviewID == ComID)
                {
                    p.NewsType = NewsType;
                    p.Message = Message;
                    p.Date = Date;
                   
                    return true;
                }
            }
            return false;
        }

        public bool UpdateReview(Customer customer, NewsArticle newsArticle, string Message, string Date, int ID)
        {
            foreach (Review p in reviews)
            {
                if (p.ReviewID == ID)
                {
                    p.NewsType = newsArticle.NewsType;
                    p.Message = Message;
                    p.Date = Date;

                    return true;
                }
            }
            return false;
        }
    }
}
