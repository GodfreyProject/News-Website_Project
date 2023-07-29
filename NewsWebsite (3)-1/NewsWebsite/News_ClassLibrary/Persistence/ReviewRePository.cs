using MySql.Data.MySqlClient;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerInterface;
using SynthesisClassLibrary;
using SynthesisClassLibrary.dbClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace News_ClassLibrary.Persistence
{
   public class ReviewRePository:IReviewRePository
    {
        private static String ADD_REVIEW = "INSERT INTO comments (PersonID, UserName, NewsID, NewsType, Message, Date)VALUES(@pid, @User, @nid, @type, @msg, @dt)";
        private static String GET_ALL_REVIEWS = "SELECT * FROM comments";

        // GET REVIEW 
        private static String GET_REVIEW = "SELECT * FROM comments WHERE UserName=@User";//"SELECT * c.ComID, s.PersonID, s.FirstName, i.NewsID, i.NewsType, c.Message, c.Date FROM comments c INNER JOIN sperson s ON c.PersonID=s.PersonID, INNER JOIN  img i ON c.NewsID=i.Id WHERE c.PersonID=@pid"; //"SELECT * from comments WHERE ComID=@comid ";
        private static String GET_WEBREVIEW = "SELECT * FROM comments WHERE ComID=@id";//"SELECT * c.ComID, s.PersonID, s.FirstName, i.NewsID, i.NewsType, c.Message, c.Date FROM comments c INNER JOIN sperson s ON c.PersonID=s.PersonID, INNER JOIN  img i ON c.NewsID=i.Id WHERE c.PersonID=@pid"; //"SELECT * from comments WHERE ComID=@comid ";

        private static string GET_CUSTOMER = "SELECT * FROM sperson WHERE UserName = @User";

        // UPDATE

        private static String UPDATE_REVIEW = "UPDATE comments SET NewsType=@type, Message=@msg, Date=@dt WHERE ComID=@id";

        private static String UPDATE_NEWREVIEW = "UPDATE comments SET  NewsType=@type, Message=@msg, Date=@dt WHERE ComID=@cid";

        // DELETE

        private static String DELETE_REVIEW = "DELETE FROM comments WHERE ComID=@cmid";
        private static String Remove_REVIEW = "DELETE FROM comments WHERE ComID=@cid";

      
        public bool AddReview(Customer customer, NewsArticle newsArticle, string Message, string Date)
        {
            bool Success = false;

            MySqlConnection conn = dbConnection.GetConnection();

            try
            {
                String SQl = ADD_REVIEW;

                MySqlCommand cmd = new MySqlCommand(SQl, conn);

                cmd.Parameters.AddWithValue("@pid", customer.ID);
                cmd.Parameters.AddWithValue("@User", customer.Username);
                cmd.Parameters.AddWithValue("@nid", newsArticle.NewsID);
                cmd.Parameters.AddWithValue("@type", newsArticle.NewsType);
                cmd.Parameters.AddWithValue("@msg", Message);
                cmd.Parameters.AddWithValue("@dt", Date);

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
        public bool AddNewReview(int EmployeeID,String Username, int NewsId, String NewsType, string Message, string Date)
        {
            bool Success = false;

            MySqlConnection conn = dbConnection.GetConnection();

            try
            {
                String SQl = ADD_REVIEW;

                MySqlCommand cmd = new MySqlCommand(SQl, conn);

                cmd.Parameters.AddWithValue("@pid", EmployeeID);
                cmd.Parameters.AddWithValue("@User", Username);
                cmd.Parameters.AddWithValue("@nid", NewsId);
                cmd.Parameters.AddWithValue("@type", NewsType);
                cmd.Parameters.AddWithValue("@msg", Message);
                cmd.Parameters.AddWithValue("@dt", Date);

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

        public bool UpdateNewReview( String NewsType, string Message, string Date, int ComID)//String Username, int NewsId, String NewsType, string Message, string Date, int ComID)
        {
            bool Success = false;

            MySqlConnection conn = dbConnection.GetConnection();

            try
            {
                String SQl = UPDATE_NEWREVIEW;

                MySqlCommand cmd = new MySqlCommand(SQl, conn);
               // cmd.Parameters.AddWithValue("@pid", PersonID);

               // cmd.Parameters.AddWithValue("@pid", EmployeeID);
               // cmd.Parameters.AddWithValue("@User", Username);
               // cmd.Parameters.AddWithValue("@nid",NewsID);
                cmd.Parameters.AddWithValue("@type", NewsType);
                cmd.Parameters.AddWithValue("@msg", Message);
                cmd.Parameters.AddWithValue("@dt", Date);
                cmd.Parameters.AddWithValue("@cid", ComID);

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

        public List<Review> GetAllReviews()
        {
            MySqlConnection conn = dbConnection.GetConnection();
            Customer customer = new Customer();

            NewsArticle article = new NewsArticle();

            List<Review> reviews = new List<Review>();

            try
            {
                String Sql = GET_ALL_REVIEWS;

                MySqlCommand cmd = new MySqlCommand(Sql, conn);
                //cmd.Parameters.AddWithValue("@pid", customer.ID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())

                {
                    int ID = reader.GetInt32("ComID");
                    int PersonID = reader.GetInt32("PersonID");
                    string Username = reader.GetString("UserName");
                    int NewsID = reader.GetInt32("NewsID");
                    string NewsType = reader.GetString("NewsType");
                    String Message = reader.GetString("Message");
                    String Date = reader.GetString("Date");



                   
                        reviews.Add(new Review(ID,PersonID, Username, NewsID, NewsType, Message, Date));
                
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
            return reviews;
        }


        public List<Review> GetReview(String Username)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            DataTable dt = new DataTable();
            Review review = new Review();
            List<Review> reviews = new List<Review>();
            Customer customer = new Customer();
            NewsArticle article = new NewsArticle();
            //int ID = review.ReviewID;
            // List<Review> reviews = new List<Review>();


            try
            {
                String Sql = GET_REVIEW;

                MySqlCommand cmd = new MySqlCommand(Sql, conn);
                cmd.Parameters.AddWithValue("@User", Username);
                //cmd.Parameters.AddWithValue("@msg", Subject);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                //adapter.Fill(dt);

                while (reader.Read())

                {
                    
                     int ID = reader.GetInt32("ComID");
                    int PersonID = reader.GetInt32("PersonID");
                     Username = reader.GetString("UserName");
                    int NewsID = reader.GetInt32("NewsID");
                    string NewsType = reader.GetString("NewsType");
                    String Message = reader.GetString("Message");
                    String Date = reader.GetString("Date");

                    //if (customer.ID == PersonID)
                    //{
                        review = new Review(ID, PersonID, Username, NewsID, NewsType, Message, Date);

                    reviews.Add(review);
                    //}
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
            return reviews;
        }

        public Review GetWebReview(int ID)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            DataTable dt = new DataTable();
            Review review = new Review();
            List<Review> reviews = new List<Review>();
            Customer customer = new Customer();
            NewsArticle article = new NewsArticle();
            //int ID = review.ReviewID;
            // List<Review> reviews = new List<Review>();


            try
            {
                String Sql = GET_WEBREVIEW;

                MySqlCommand cmd = new MySqlCommand(Sql, conn);
                cmd.Parameters.AddWithValue("@id", ID);
                //cmd.Parameters.AddWithValue("@msg", Subject);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                //adapter.Fill(dt);

                while (reader.Read())

                {
                    // ID = Convert.ToInt32(dt.Rows[0]["ComID"]);
                    // int PersonID = Convert.ToInt32(dt.Rows[0]["PersonID"]);
                    //String Username = dt.Rows[0]["UserName"].ToString();
                    //int NewsID = Convert.ToInt32(dt.Rows[0]["NewsID"]);
                    //string NewsType = dt.Rows[0]["NewsType"].ToString();
                    //string Message = dt.Rows[0]["Message"].ToString();
                    //String Date = dt.Rows[0]["Date"].ToString();

                    ID = reader.GetInt32("ComID");
                    int PersonID = reader.GetInt32("PersonID");
                    string Username = reader.GetString("UserName");
                    int NewsID = reader.GetInt32("NewsID");
                    string NewsType = reader.GetString("NewsType");
                    String Message = reader.GetString("Message");
                    String Date = reader.GetString("Date");

                    //if (customer.ID == PersonID)
                    //{
                    review = new Review(ID, PersonID, Username, NewsID, NewsType, Message, Date);

                    return review;
                    //reviews.Add(review);
                    //}
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
            return null;
        }
        public Review Reviews(String Username)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            DataTable dt = new DataTable();
            Review review = new Review();
            Customer customer = new Customer();
            NewsArticle article = new NewsArticle();

            List<Review> reviews = new List<Review>();

            String Sql = "SELECT * FROM comments WHERE UserName=@user";
            try
            {
               
                MySqlCommand cmd = new MySqlCommand(Sql, conn);
                cmd.Parameters.AddWithValue("@user", Username);
                //cmd.Parameters.AddWithValue("@msg", Subject);

                conn.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)

                {
                    int ID = Convert.ToInt32(dt.Rows[0]["ComID"]);
                    int PersonID = Convert.ToInt32(dt.Rows[0]["PersonID"]);
                     Username = dt.Rows[0]["UserName"].ToString();
                    int NewsID = Convert.ToInt32(dt.Rows[0]["NewsID"]);
                    string NewsType = dt.Rows[0]["NewsType"].ToString();
                    string Message = dt.Rows[0]["Message"].ToString();
                    String Date = dt.Rows[0]["Date"].ToString();



                    //if (customer.Username == "UserName")
                    //{
                    review = new Review(ID, PersonID, Username, NewsID, NewsType, Message, Date);

                    return review;
                    //}
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
            return null;
        }



        private NewsArticle GetNewsContent(int ID)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            String SQL = "SELECT  * FROM news WHERE Id=@id";
            NewsArticle article;
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@id", ID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ID = Convert.ToInt32(reader["Id"]);
                    String NewsType = reader["NewsType"].ToString();
                    byte[] Photo = (byte[])reader["Image"];
                    String Title = reader["Title"].ToString();
                    String Description = reader["Description"].ToString();
                    String Author = reader["Author"].ToString();
                    String Date = reader["Date"].ToString();

                    article = new NewsArticle(ID, NewsType, Photo, Title, Description, Author, Date);

                    return article;
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

            return null;
        }

        //public Review GetReview(Customer customer)
        //{
        //    throw new NotImplementedException();
        //}

        public bool RemoveReview(int ID)
        {
            bool Success = false;

            MySqlConnection conn = dbConnection.GetConnection();

            String Sql = DELETE_REVIEW;
            try
            {
                MySqlCommand cmd = new MySqlCommand(Sql, conn);

                cmd.Parameters.AddWithValue("@cmid", ID);

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

        public bool UpdateReview(Customer customer, NewsArticle newsArticle, string Message, string Date, int ID)//, String Username)
        {
            bool IsSuccessFull = false;

            MySqlConnection conn = dbConnection.GetConnection();
            String SQL = UPDATE_REVIEW;
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                cmd.Parameters.AddWithValue("@type", newsArticle.NewsType);
                cmd.Parameters.AddWithValue("@msg", Message);
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
        public bool RemoveNewReview(int ID)
        {
            bool Success = false;

            MySqlConnection conn = dbConnection.GetConnection();

            String Sql = Remove_REVIEW;
            try
            {
                MySqlCommand cmd = new MySqlCommand(Sql, conn);

                cmd.Parameters.AddWithValue("@cid", ID);

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

        private Customer GetCustomer(string UserName)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            string sql = GET_CUSTOMER;

            Customer customer;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@User", UserName);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String FirstName = reader.GetString("FirstName");
                    string Lastname = reader.GetString("LastName");
                    UserName = reader.GetString("UserName");
                    string email = reader.GetString("Email");
                    string Password = reader.GetString("Password");
                    string Zipcode = reader.GetString("Zipcode");
                    string UserRole = reader.GetString("Role");

                    if (UserRole == "Customer")
                    {
                        customer = new Customer(FirstName, Lastname, UserName, email, Password, Zipcode, UserRole);
                        return customer;
                    }
                }
            }
            catch (Exception exp)
            {
                Debug.WriteLine(exp.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public Review Review(string Username)
        {
            throw new NotImplementedException();
        }

        public bool DeleteReview(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
