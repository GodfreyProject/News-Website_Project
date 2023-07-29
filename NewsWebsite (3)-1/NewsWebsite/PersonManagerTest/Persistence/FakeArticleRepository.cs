using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerInterface;
using News_ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagerTest.Persistence
{
    public class FakeArticleRepository : IArticleRepository
    {
        private List<NewsArticle> articles;

        public FakeArticleRepository(List<NewsArticle> newsArticles)
        {
            this.articles = newsArticles;
        }
        public bool AddArticle(NewsArticle newsArticle)
        {
            if(this.GetArticle(newsArticle.NewsID) != null)
            {
                this.articles.Add(newsArticle);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddNewsContent(string NewsType, byte[] Photo, string Title, string Description, string Author, string Date)
        {
            //NewsArticleRePository rePository = new NewsArticleRePository();

            //NewsArticle newsArticle = new NewsArticle(NewsType, Photo, Title, Description, Author, Date);

            this.articles.Add(new NewsArticle(0,NewsType, Photo, Title, Description, Author, Date));

            return true;
        }

        public bool DeleteContent(int Id)
        {
           foreach(NewsArticle news in this.articles)
            {
                if(news.NewsID == Id)
                {
                    this.articles.Remove(news);

                    return true;
                }
               
            }

            return false;
        }

        public List<NewsArticle> GetAllNewsArticles()
        {
            return this.articles;
        }

        public List<NewsArticle> GetAllNewsContents()
        {
            return this.articles;
        }

        public NewsArticle GetArticle(int ID)
        {
           foreach(NewsArticle news in articles)
            {
                if(news.NewsID == ID)
                {
                    return news;
                }
            }

            return null;
        }

        public NewsArticle GetArticle(string NewsType)
        {
            foreach (NewsArticle news in articles)
            {
                if (news.NewsType == NewsType)
                {
                    return news;
                }
            }

            return null;
        }

        public List<NewsArticle> GetArticles(int ID)
        {
            throw new NotImplementedException();
        }

        public NewsArticle GetNewsArticle(int ID)
        {
            foreach (NewsArticle news in articles)
            {
                if (news.NewsID == ID)
                {
                    return news;
                }
            }

            return null;
        }

        public NewsArticle GetNewsType(string Title)
        {
            foreach (NewsArticle news in articles)
            {
                if (news.Title == Title)
                {
                    return news;
                }
            }

            return null;
        }

        public bool RemoveContent(int ID)
        {
            foreach (NewsArticle news in this.articles)
            {
                if (news.NewsID == ID)
                {
                    this.articles.Remove(news);

                    return true;
                }

            }

            return false;
        }

        public NewsArticle SearchContent(string Search)
        {
            throw new NotImplementedException();
        }

        public NewsArticle SearchNewsArticle(string Search)
        {
            throw new NotImplementedException();
        }

        public bool UpdateArticle(NewsArticle newsArticle)
        {
            int ID = newsArticle.NewsID;
            foreach(NewsArticle article in this.articles)
            {
                if(article.NewsID == ID)
                {
                    article.NewsType = newsArticle.NewsType;
                    article.Img = newsArticle.Img;
                    article.Title = newsArticle.Title;
                    article.Description = newsArticle.Description;
                    article.Author = newsArticle.Author;
                    article.Date = newsArticle.Date;

                    return true;
                }

               
            }

            return false;
        }

        public bool UpdateContent(string NewsType, string Image, string Title, string Description, string Author, string Date, int ID)
        {
            foreach(NewsArticle news in articles)
            {
                if(news.NewsID == ID)
                {
                    news.NewsType = NewsType;
                    news.Img = Image;
                    news.Title = Title;
                    news.Description = Description;
                    news.Author = Author;
                    news.Date = Date;

                    return true;
                }
            }

            return false;
        }

        public bool UpdateNewsContent(string NewsType, byte[] Photo, string Title, string Description, string Author, string Date, int Id)
        {
            foreach (NewsArticle news in articles)
            {
                if (news.NewsID == Id)
                {
                    news.NewsType = NewsType;
                    news.Photo = Photo;
                    news.Title = Title;
                    news.Description = Description;
                    news.Author = Author;
                    news.Date = Date;

                    return true;
                }
            }
            return false;
        }
    }
}
            