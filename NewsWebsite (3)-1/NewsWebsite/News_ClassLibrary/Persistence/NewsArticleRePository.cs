using MySql.Data.MySqlClient;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerInterface;
using SynthesisClassLibrary.dbClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace News_ClassLibrary.Persistence
{
   public class NewsArticleRePository:IArticleRepository
    {
        // WAD ASP.NET CORE RAZOR
        private static String GET_ALL_ARTICLES = "SELECT * FROM news";

        private static String ADD_ARTICLE = "INSERT INTO news (NewsType, Image, Title, Description,  Author, Date)VALUES(@type, @img, @title, @descr, @auth, @dt)";


        private static String UPDATE_NEWS_CONTENT = "UPDATE news SET  NewsType=@type, Image=@img, Title=@title, Description=@descr,  Author=@auth, Date=@dt WHERE ID=@id";

        private static String DELETE_NEWS_ARTICLE = "DELETE FROM news WHERE ID=@id";

        // OOD DESKTOP APPLICATION (TABLE img)

        private static String ADD_NEWS_CONTENT = "INSERT INTO img (NewsType, Image,  Title, Description,  Author, Date)VALUES(@type, @pic, @title, @descr, @auth, @dt)";

        private static String GET_All_NEWS = "SELECT * FROM img";


        private static String UPDATE_CONTENT = "UPDATE img SET  NewsType=@type, Image=@pic,  Title=@title, Description=@descr,  Author=@auth, Date=@dt WHERE Id=@id";

        private static String DELETE_NEWS_CONTENT = "DELETE FROM img WHERE Id=@id";

        private static String GET_CONTENT_BYID = "SELECT * FROM img WHERE Id=@id";
   

        // WAD ASP.NET CORE RAZOR PAGE WEBSITE
        public bool AddArticle(NewsArticle newsArticle)
        {
            bool IsSuccesfull = false;

            MySqlConnection conn = dbConnection.GetConnection();

            try
            {
                String SQL = ADD_ARTICLE;

                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                cmd.Parameters.AddWithValue("@type", newsArticle.NewsType);
                cmd.Parameters.AddWithValue("@img", newsArticle.Img);
                cmd.Parameters.AddWithValue("@title", newsArticle.Title);
                cmd.Parameters.AddWithValue("@descr", newsArticle.Description);

                cmd.Parameters.AddWithValue("@auth", newsArticle.Author);
                cmd.Parameters.AddWithValue("@dt", newsArticle.Date);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader is null)
                {


                    IsSuccesfull = false;
                }
                if (reader.RecordsAffected > 0)
                {
                 

                    IsSuccesfull = true;
                }
            }
            catch (MySqlException EXP)
            {
                Debug.WriteLine(EXP.Message);
            }
            catch (Exception)
            {
                throw new InvalidOperationException($"News Content with {newsArticle.NewsID}: Already Exist");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return IsSuccesfull;
        }

        public bool UpdateArticle(NewsArticle newsArticle)
        {
            bool IsSuccesfull = false;

            MySqlConnection conn = dbConnection.GetConnection();

            try
            {
                String SQL = UPDATE_NEWS_CONTENT;

                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                cmd.Parameters.AddWithValue("@type", newsArticle.NewsType);
                cmd.Parameters.AddWithValue("@img", newsArticle.Img);
                cmd.Parameters.AddWithValue("@title", newsArticle.Title);
                cmd.Parameters.AddWithValue("@descr", newsArticle.Description);

                cmd.Parameters.AddWithValue("@auth", newsArticle.Author);
                cmd.Parameters.AddWithValue("@dt", newsArticle.Date);
                cmd.Parameters.AddWithValue("@id", newsArticle.NewsID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader is null)
                {


                    IsSuccesfull = false;
                }
                if (reader.RecordsAffected > 0)
                {
                   
                    IsSuccesfull = true;
                }
            }
            catch (MySqlException EXP)
            {
                Debug.WriteLine(EXP.Message);
            }
            catch (Exception exp)
            {
                Debug.WriteLine(exp.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return IsSuccesfull;
        }
        public NewsArticle SearchContent(string Serach)
        {
            MySqlConnection conn = dbConnection.GetConnection();

            String SQL = $"SELECT Id, NewsType, Image, Title, Description, Author, Date FROM news WHERE Id LIKE '%{Serach}%' OR NewsType LIKE '%{Serach}%'";

            DataTable dt = new DataTable();

            NewsArticle news = new NewsArticle();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, conn);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    news.NewsID = Convert.ToInt32(dt.Rows[0]["ID"]);
                    news.NewsType = dt.Rows[0]["NewsType"].ToString();
                    news.Photo = (byte[])dt.Rows[0]["Image"];
                    news.Title = dt.Rows[0]["Title"].ToString();
                    news.Description = dt.Rows[0]["Description"].ToString();
                    news.Author = dt.Rows[0]["Author"].ToString();
                    news.Date = dt.Rows[0]["Date"].ToString();
                }
               
            }
         
            catch (Exception exp)
            {
                Debug.WriteLine(exp.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return news;
        }
        public bool UpdateContent(string NewsType, string Image, string Title, string Description, string Author, string Date, int ID)
        {
            bool IsSuccessFull = false;

            MySqlConnection conn = dbConnection.GetConnection();
            String SQL = UPDATE_NEWS_CONTENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                cmd.Parameters.AddWithValue("@type", NewsType);
                cmd.Parameters.AddWithValue("@img", Image);
                cmd.Parameters.AddWithValue("@title", Title);
                cmd.Parameters.AddWithValue("@descr", Description);
                cmd.Parameters.AddWithValue("@auth", Author);
                cmd.Parameters.AddWithValue("@dt", Date);
                cmd.Parameters.AddWithValue("@id", ID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader is null)
                {
                    IsSuccessFull = false;
                }
                if (reader.RecordsAffected > 0)
                {
                   
                    IsSuccessFull = true;
                }
            }
           
            catch (Exception exp)
            {
                Debug.WriteLine(exp.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return IsSuccessFull;
        }

        public bool RemoveContent(int ID)
        {
            bool IsSuccess = false;

            MySqlConnection conn = dbConnection.GetConnection();
            String SQl = DELETE_NEWS_ARTICLE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQl, conn);

                cmd.Parameters.AddWithValue("@id", ID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader is null)
                {
                    IsSuccess = false;
                }
                if (reader.RecordsAffected > 0)
                {
                  

                    IsSuccess = true;
                }
            }
           
            catch (Exception exp)
            {
                Debug.WriteLine(exp.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return IsSuccess;

        }
        public NewsArticle SearchNewsArticle(String Search)
        {
            MySqlConnection conn = dbConnection.GetConnection();

            String SQL = $"SELECT ID, NewsType, Image, Title, Description, Author, Date FROM img WHERE ID LIKE '%{Search}%' OR NewsType LIKE '%{Search}%'";

            DataTable dt = new DataTable();

            NewsArticle news = new NewsArticle();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, conn);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    news.NewsID = Convert.ToInt32(dt.Rows[0]["ID"]);
                    news.NewsType = dt.Rows[0]["NewsType"].ToString();
                    news.Photo = (byte[])dt.Rows[0]["Image"];
                    news.Title = dt.Rows[0]["Title"].ToString();
                    news.Description = dt.Rows[0]["Description"].ToString();
                    news.Author = dt.Rows[0]["Author"].ToString();
                    news.Date = dt.Rows[0]["Date"].ToString();
                }
               
            }
           
            catch (Exception)
            {
                throw new InvalidOperationException();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return news;
        }
        public NewsArticle GetNewsArticle(int ID)
        {
            throw new NotImplementedException();
        }

        // OOD DESKTOP APPLICATION OOD PRINCIPLE
        public List<NewsArticle> GetAllNewsContents()
        {
            MySqlConnection conn = dbConnection.GetConnection();
            String SQL = GET_All_NEWS;
            List<NewsArticle> news = new List<NewsArticle>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    String NewsType = reader["NewsType"].ToString();
                    byte[] Photo = (byte[])reader["Image"];
                    String Title = reader["Title"].ToString();
                    String Description = reader["Description"].ToString();
                    String Author = reader["Author"].ToString();
                    String Date = reader["Date"].ToString();

                    news.Add(new NewsArticle(Id, NewsType, Photo, Title, Description, Author, Date));

                }
            }
          
            catch (Exception exp)
            {
                Debug.WriteLine(exp.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return news;
        }



        // OOD DESKTOP APPLICATION OOD PRINCIPLE
        public bool AddNewsContent(string NewsType, byte[] Photo, string Title, string Description, string Author, string Date)
        {
            bool IsSuccessFull = false;

            MySqlConnection conn = dbConnection.GetConnection();
            String SQL = ADD_NEWS_CONTENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                cmd.Parameters.AddWithValue("@type", NewsType);
                cmd.Parameters.AddWithValue("@pic", Photo);
                cmd.Parameters.AddWithValue("@title", Title);
                cmd.Parameters.AddWithValue("@descr", Description);
                cmd.Parameters.AddWithValue("@auth", Author);
                cmd.Parameters.AddWithValue("@dt", Date);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader is null)
                {
                    IsSuccessFull = false;
                }
                if (reader.RecordsAffected > 0)
                {
                   
                    IsSuccessFull = true;
                }
            }
          
            catch (Exception exp)
            {
                Debug.WriteLine(exp.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return IsSuccessFull;
        }

        public List<NewsArticle> GetAllNewsArticles()
        {
            MySqlConnection conn = dbConnection.GetConnection();

            List<NewsArticle> articles = new List<NewsArticle>();

            try
            {
                String SQL = GET_ALL_ARTICLES;

                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    String NewsType = reader["NewsType"].ToString();
                    String Image = reader["Image"].ToString();
                    String Title = reader["Title"].ToString();
                    String Description = reader["Description"].ToString();
                    String Author = reader["Author"].ToString();
                    String Date = reader["Date"].ToString();



                  articles.Add(new NewsArticle(Id, NewsType, Image, Title, Description, Author, Date));

                  
                }

            }
            catch (MySqlException exp)
            {
                Debug.WriteLine(exp.Message);
            }
            catch (Exception exp)
            {
                Debug.WriteLine(exp.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return articles;
        }

        // GET NEWS ARTICLE BY ID

        public NewsArticle GetArticle(int ID)
        {
            MySqlConnection conn = dbConnection.GetConnection();

            NewsArticle newsArticle = new NewsArticle();

            try
            {


                String SQL = "SELECT * FROM news WHERE ID=@id";

                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@id", ID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                   

                    NewsArticle news = new NewsArticle()
                    {
                        NewsID = reader.GetInt32("ID"),
                        NewsType = reader.GetString("NewsType"),
                        Img = reader.GetString("Image"),
                        Title = reader.GetString("Title"),
                        Description = reader.GetString("Description"),

                        Author = reader.GetString("Author"),
                        Date = reader.GetString("Date"),



                    };
                   
                    return news;
                   

                }
            }
            catch (MySqlException exp)
            {
                Debug.WriteLine(exp.Message);
            }
            catch (Exception)
            {
                throw new ArgumentException(" Content Can not be Empty");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return null;
        }

        // GET NEWS ARTICLE BY TITLE
        public NewsArticle GetArticle(string Title)
        {
            MySqlConnection conn = dbConnection.GetConnection();

            NewsArticle newsArticle = new NewsArticle();
           // List<NewsArticle> news = new List<NewsArticle>();
            try
            {
                String SQL = "SELECT * FROM img WHERE Title=@title";

                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@title", Title);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    String NewsType = reader["NewsType"].ToString();
                    byte[] Photo = (byte[])reader["Image"];
                    Title = reader["Title"].ToString();
                    String Description = reader["Description"].ToString();
                    String Author = reader["Author"].ToString();
                    String Date = reader["Date"].ToString();

                  newsArticle =  new NewsArticle(Id, NewsType, Photo, Title, Description, Author, Date);
                  

                    return newsArticle;

                }
            }
            //catch (MySqlException exp)
            //{
            //    Debug.WriteLine(exp.Message);
            //}
            catch (Exception)
            {
                throw new NewsContentException();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return null;
        }

        public NewsArticle GetNewsType(string NewsType)
        {
            MySqlConnection conn = dbConnection.GetConnection();

            NewsArticle newsArticle = new NewsArticle();
            List<NewsArticle> news = new List<NewsArticle>();
            try
            {
                String SQL = "SELECT * FROM news WHERE NewsType=@type";

                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@type", NewsType);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //int Id = Convert.ToInt32(reader["Id"]);
                     NewsType = reader["NewsType"].ToString();
                    String Photo = reader.GetString("Image");
                   string Title = reader["Title"].ToString();
                    String Description = reader["Description"].ToString();
                    String Author = reader["Author"].ToString();
                    String Date = reader["Date"].ToString();

                    newsArticle = new NewsArticle( NewsType, Photo, Title, Description, Author, Date);


                    return newsArticle;

                }
            }
            catch (MySqlException exp)
            {
                Debug.WriteLine(exp.Message);
            }
            catch (Exception)
            {
                throw new NewsContentException();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return null;
        }






        public bool UpdateNewsContent(String NewsType, byte[] Photo, String Title, String Description, String Author, String Date, int Id)
        {

            bool IsSuccessFull = false;

            MySqlConnection conn = dbConnection.GetConnection();
            String SQL = UPDATE_CONTENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, conn);


                cmd.Parameters.AddWithValue("@type", NewsType);
                cmd.Parameters.AddWithValue("@pic", Photo);
                cmd.Parameters.AddWithValue("@title", Title);
                cmd.Parameters.AddWithValue("@descr", Description);
                cmd.Parameters.AddWithValue("@auth", Author);
                cmd.Parameters.AddWithValue("@dt", Date);
                cmd.Parameters.AddWithValue("@id", Id);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader is null)
                {
                    IsSuccessFull = false;
                }
                if (reader.RecordsAffected > 0)
                {
                   

                    IsSuccessFull = true;
                }
            }
            catch (MySqlException exp)
            {
                Debug.WriteLine(exp.Message);
            }
            catch (Exception exp)
            {
                Debug.WriteLine(exp.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return IsSuccessFull;
        }

        public bool DeleteContent(int Id)
        {
            bool Success = false;

            MySqlConnection conn = dbConnection.GetConnection();
            String delete = DELETE_NEWS_CONTENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(delete, conn);

                cmd.Parameters.AddWithValue("@id", Id);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader is null)
                {
                    Success = false;
                }

                if (reader.RecordsAffected > 0)
                {
                  

                    Success = true;
                }
            }
            catch (MySqlException exp)
            {
                Debug.WriteLine(exp.Message);
            }
            catch (Exception exp)
            {
                Debug.WriteLine(exp.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return Success;
        }

        public List<NewsArticle> GetArticles(int ID)
        {
            MySqlConnection conn = dbConnection.GetConnection();

            List<NewsArticle> articles = new List<NewsArticle>();

            try
            {
                String SQL = "SELECT * FROM news WHERE Id=@id";

                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@id", ID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                     ID = Convert.ToInt32(reader["Id"]);
                    String NewsType = reader["NewsType"].ToString();
                    String Image = reader["Image"].ToString();
                    String Title = reader["Title"].ToString();
                    String Description = reader["Description"].ToString();
                    String Author = reader["Author"].ToString();
                    String Date = reader["Date"].ToString();



                    articles.Add(new NewsArticle(ID, NewsType, Image, Title, Description, Author, Date));


                }

            }
            catch (MySqlException exp)
            {
                Debug.WriteLine(exp.Message);
            }
            catch (Exception exp)
            {
                Debug.WriteLine(exp.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return articles;
        }
    }
}
