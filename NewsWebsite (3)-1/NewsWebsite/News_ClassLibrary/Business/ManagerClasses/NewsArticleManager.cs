//using News_ClassLibrary.AdminInterface;

//using News_ClassLibrary.DBClasses;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerInterface;
using News_ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace News_ClassLibrary.ManagerClasses
{
    public class NewsArticleManager
    {
       //NewsArticleRePository DBNews;

        public IArticleRepository articleRepository;
        public NewsArticleManager(IArticleRepository repository)
        {
            articleRepository = repository;
            //this.DBNews = new NewsArticleRePository();
        }
        public bool AddArticle(NewsArticle newsArticle)
        {
            return this.articleRepository.AddArticle(newsArticle);
        }

        public bool UpdateArticle(NewsArticle newsArticle)
        {
            if (this.articleRepository.UpdateArticle(newsArticle))
            {
                return true;
            }

            return false;
        }

        public bool AddNewsContent(string NewsType, byte[] Photo, string Title, string Description, string Author, string Date)
        {
            if(articleRepository.AddNewsContent(NewsType, Photo, Title, Description, Author, Date))
            {
                return true;
            }

            return false;
        }

        public bool DeleteContent(int Id)
        {
            if (articleRepository.RemoveContent(Id))
            {
                return true;
            }
            return false;
        }

        public List<NewsArticle> GetAllNewsArticles()
        {
            return this.articleRepository.GetAllNewsArticles();
        }

        public List<NewsArticle> GetAllNewsContents()
        {
            return this.articleRepository.GetAllNewsContents();
        }

        public NewsArticle GetArticle(int ID)
        {
            return this.articleRepository.GetArticle(ID);
        }

        public NewsArticle GetArticle(string Title)
        {
            return this.articleRepository.GetArticle(Title);
        }
        public NewsArticle GetNewsType(string NewsType)
        {
            return this.articleRepository.GetNewsType(NewsType);
        }
        public NewsArticle GetNewsArticle(int ID)
        {
            return articleRepository.GetNewsArticle(ID);
        }

        public bool RemoveContent(int ID)
        {
            if (this.articleRepository.RemoveContent(ID))
            {
                return true;
            }

            return false;
        }

        public NewsArticle SearchContent(string Serach)
        {
            return this.articleRepository.SearchContent(Serach);
        }

        public NewsArticle SearchNewsArticle(string Search)
        {
            return articleRepository.SearchNewsArticle(Search);
        }

        public bool UpdateContent(string NewsType, string Image, string Title, string Description, string Author, string Date, int ID)
        {
            if(this.articleRepository.UpdateContent(NewsType, Image, Title, Description, Author, Date, ID))
            {
                return true;
            }

            return false;
        }

        public bool UpdateNewsContent(string NewsType, byte[] Photo, string Title, string Description, string Author, string Date, int Id)
        {
            if(this.articleRepository.UpdateNewsContent(NewsType, Photo, Title, Description, Author, Date, Id))
            {
                return true;
            }

            return false;
        }
    }
}
