using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace News_ClassLibrary.Logic.Classes
{
    public class NewsArticle
    {
        // Fields

        private int id;

        private string img;

        private string title;

        private string description;

        private string newstype;

        private string author;

        private string date;

      


        public int NewsID
        {
            get { return this.id; }

            set { this.id = value; }
        }

        public String NewsType
        {
            get { return this.newstype; }

            set {

                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid NewsType Supplied");
                }
                this.newstype = value;
            
            
            }
        }
        [Required]
        public String Img
        {
            get { return this.img; }
            set {

                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Img Supplied");
                }
                this.img = value; 
            
            }
        }

        public byte[] Photo { get; set; }
        public String Title
        {
            get { return this.title; }

            set {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Title Given");
                }

                this.title = value;
            
            }
        }
       // public string Search { get; set; }
        public String Description
        {
            get { return this.description; }

            set {

                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Description Supplied");
                }
                this.description = value; 
            
            }
        }

       


        public String Author
        {
            get { return this.author; }

            set {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Author Supplied");
                }
                this.author = value;
            
            }
        }

        public String Date
        {
            get { return this.date; }

            set {

                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Date of the New Content can be Empty");
                }
                this.date = value;
            
            }
        }

      
        // WAD WEBSITE ASP.NET CORE RAZOR 
        public NewsArticle(int id, string type, string img, string title, string description,  string author, string date)
        {
            this.NewsID = id;
            this.Img = img;
            this.Title = title;
            this.Description = description;
            this.NewsType = type;
            this.Author = author;
            this.Date = date;
           
        }
        // OOD DESKTOP APPLICATION
        public NewsArticle(int id, string type, byte[] pic, string title, string description,  string author, string date)
        {
            this.NewsID = id;
            this.Photo = pic;
            this.Title = title;
            this.Description = description;
            this.NewsType = type;
            this.Author = author;
            this.Date = date;
          
        }

        public NewsArticle( string type, string pic, string title, string description, string author, string date)
        {
            //this.NewsID = id;
            this.img = pic;
            this.Title = title;
            this.Description = description;
            this.NewsType = type;
            this.Author = author;
            this.Date = date;

        }

        public NewsArticle( string type, byte[] pic, string title, string description, string author, string date)
        {
            
            this.Photo = pic;
            this.Title = title;
            this.Description = description;
            this.NewsType = type;
            this.Author = author;
            this.Date = date;

        }

        public NewsArticle()
        {

        }

        public override string ToString()
        {
            return $"NewsID: {this.NewsID}: NewsType:{NewsType}:";
        }
    }

}