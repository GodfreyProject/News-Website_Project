
using SynthesisClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace News_ClassLibrary.Logic.Classes
{
    public class Review
    {
        // FIELDS
        private int revid;

        private Customer customer;

        private NewsArticle article;

        private String message;

        private string date;



        // Properties

        public int ReviewID
        {
            get { return this.revid; }
            set { this.revid = value; }
        }

        //public Customer Customer
        //{
        //    get { return this.customer; }
        //    set { this.customer = value; }
        //}

        public int PersonID { get; set; }

        public String Username { get; set; }

        public int NewsID { get; set; }

        public List<NewsArticle> articles = new List<NewsArticle>();
        public string NewsType
        {
            get;
            set;
        }


        //public NewsArticle NewsArticle
        //{
        //    get { return this.article; }

        //    set { this.article = value; }
        //}



        public String Message
        {
            get { return this.message; }

            set { this.message = value; }
        }

        public String Date
        {
            get { return this.date; }

            set { this.date = value; }
        }

        public Review()
        {

        }
        // Customer customer , NewsArticle newsArticle

        public Review(int id, int Peronsid, String user, int newsid, string type, string msg, string date)
        {
            this.ReviewID = id;
            //this.Customer = customer;
            //this.NewsArticle = newsArticle;
            this.PersonID = Peronsid;
            this.Username = user;
            this.NewsID = newsid;
            this.NewsType = type;
            this.Message = msg;
            this.Date = date;
        }
        public Review(int id, Customer customer, NewsArticle newsArticle, string msg, string date)
        {
            this.ReviewID = id;
            //this.Customer = customer;
            //this.NewsArticle = newsArticle;
            //this.PersonID = Peronsid;
            //this.Username = user;
            //this.NewsID = newsid;
            //this.NewsType = type;
            this.Message = msg;
            this.Date = date;
        }
        public Review(int id, Customer customer,  string msg, string date)
        {
            this.ReviewID = id;
            //this.Customer = customer;
            //this.NewsArticle = newsArticle;
            //this.PersonID = Peronsid;
            //this.Username = user;
            //this.NewsID = newsid;
            //this.NewsType = type;
            this.articles = new List<NewsArticle>();
            this.Message = msg;
            this.Date = date;
        }

        public override string ToString()
        {
            return $"COmID:{ReviewID}: PersonID:{PersonID}:Username: {Username}: NewsID:{NewsID}: NewsType:{NewsType}: Messages: {Message}: Date: {Date}";
        }
    }
}
