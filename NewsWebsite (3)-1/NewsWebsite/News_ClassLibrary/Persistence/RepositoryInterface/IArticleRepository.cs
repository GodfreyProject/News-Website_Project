using News_ClassLibrary.Logic.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace News_ClassLibrary.ManagerInterface
{
   public interface IArticleRepository
    {
        // Get Article;
        public List<NewsArticle> GetAllNewsArticles();


        public NewsArticle GetArticle(int ID);

        public NewsArticle GetNewsArticle(int ID);
        public List<NewsArticle> GetArticles(int ID);
        public NewsArticle GetArticle(String Title);
        public NewsArticle GetNewsType(String Title);

        // WAD NEWS WEBSITE
        public bool AddArticle(NewsArticle newsArticle);

        public bool UpdateArticle(NewsArticle newsArticle);
        // OOD DESKTOP
        public List<NewsArticle> GetAllNewsContents();
        public bool AddNewsContent(String NewsType, byte[] Photo, String Title, String Description, String Author, String Date);
        public bool UpdateNewsContent(String NewsType, byte[] Photo, String Title, String Description, String Author, String Date, int Id);

        public bool DeleteContent(int Id);


        // Update ON WAD ASP.NET CORE RAZOR
        public bool UpdateContent(String NewsType, String Image, String Title, String Description, String Author, String Date, int ID);

        // Delete

        public bool RemoveContent(int ID);

        // Search

        public NewsArticle SearchContent(String Search);

        public NewsArticle SearchNewsArticle(string Search);
    }
}
