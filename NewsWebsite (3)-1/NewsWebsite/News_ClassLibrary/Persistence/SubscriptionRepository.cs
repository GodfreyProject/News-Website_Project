using MySql.Data.MySqlClient;
using News_ClassLibrary.Business.Logic.Model;
using News_ClassLibrary.Business.ManagerInterface;
using SynthesisClassLibrary.dbClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace News_ClassLibrary.Persistence
{
   public class SubscriptionRepository:ISubscribeRepository
    {
        private static String ADD_SUBSCRIBE = "INSERT INTO subscribes(FirstName, LastName, Email, Payment, Month, Status)VALUES(@first, @last, @email, @pay, @mn, @st)";

        private static String GET_ALL_SUBSCRIBES = "SELECT * FROM subscribes";

        private static String GET_SUBSCRPTION_BYID = "SELECT * FROM subscribes WHERE FirstName=@first";
        private static String UN_SUBSCRPTION = "DELETE FROM subscribes WHERE SubID=@id";

        public List<SubScription> GetAllSubsscription()
        {
            List<SubScription> subScriptions = new List<SubScription>();
            MySqlConnection conn = dbConnection.GetConnection();
            try
            {
                String Sql = GET_ALL_SUBSCRIBES;

                MySqlCommand cmd = new MySqlCommand(Sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int SUBID = reader.GetInt32("SubID");
                    String Firstname = reader.GetString("FirstName");
                    String Lastname = reader.GetString("LastName");
                    String Email = reader.GetString("Email");
                    String Payment = reader.GetString("Payment");

                    String Month = reader.GetString("Month");
                    String Status = reader.GetString("Status");


                    SubScription sub = new SubScription(SUBID, Firstname, Lastname, Email, Payment, Month, Status);

                    subScriptions.Add(sub);
                }
            }
            catch (Exception)
            {
                throw new InvalidOperationException();
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }

            return subScriptions;
        }

        public List<SubScription> GetSubScription(String Firstname)
        {
            List<SubScription> subscribes = new List<SubScription>();
            MySqlConnection conn = dbConnection.GetConnection();
            try
            {
                String Sql = GET_SUBSCRPTION_BYID;

                MySqlCommand cmd = new MySqlCommand(Sql, conn);

                cmd.Parameters.AddWithValue("@first", Firstname);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int SUBID = reader.GetInt32("SubID");
                     Firstname = reader.GetString("FirstName");
                    String Lastname = reader.GetString("LastName");
                    String Email = reader.GetString("Email");
                    String Payment = reader.GetString("Payment");

                    String Month = reader.GetString("Month");
                    String Status = reader.GetString("Status");


                     SubScription Sub = new SubScription(SUBID, Firstname, Lastname, Email, Payment, Month, Status);

                    subscribes.Add(Sub);
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

            return subscribes;

    }

    public bool Subscribe(string Firstname, string Lastname, string Email, string Payment, string Month, string Status)
        {
            bool Success = false;
            MySqlConnection conn = dbConnection.GetConnection();

            String Sql = ADD_SUBSCRIBE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(Sql, conn);

                cmd.Parameters.AddWithValue("@first", Firstname);
                cmd.Parameters.AddWithValue("@last", Lastname);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@pay", Payment);
                cmd.Parameters.AddWithValue("@mn", Month);
                cmd.Parameters.AddWithValue("@st", Status);

                conn.Open();

                int AffectedRow = cmd.ExecuteNonQuery();

                if(AffectedRow < 0)
                {
                    Success = false;
                }

                if(AffectedRow > 0)
                {
                    Success = true;
                }
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Information Already Exist");
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }

            return Success;
        }

        public bool UnSubscribe(int ID)
        {
            bool Success = false;
            MySqlConnection conn = dbConnection.GetConnection();

            String Sql = UN_SUBSCRPTION;
            try
            {
                MySqlCommand cmd = new MySqlCommand(Sql, conn);

            
                cmd.Parameters.AddWithValue("@id", ID);

                conn.Open();

                int AffectedRow = cmd.ExecuteNonQuery();

                if (AffectedRow < 0)
                {
                    Success = false;
                }

                if (AffectedRow > 0)
                {
                    Success = true;
                }
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Information Already Exist");
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
        public SubScription GetSubScribe(int ID)
        {
            SubScription subscribe = new SubScription();
            MySqlConnection conn = dbConnection.GetConnection();
            try
            {
                String Sql = "SELECT * FROM subscribes WHERE SubID=@id";

                MySqlCommand cmd = new MySqlCommand(Sql, conn);

                cmd.Parameters.AddWithValue("@id", ID);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                     ID = reader.GetInt32("SubID");
                   string Firstname = reader.GetString("FirstName");
                    String Lastname = reader.GetString("LastName");
                    String Email = reader.GetString("Email");
                    String Payment = reader.GetString("Payment");

                    String Month = reader.GetString("Month");
                    String Status = reader.GetString("Status");


                    SubScription Sub = new SubScription(ID, Firstname, Lastname, Email, Payment, Month, Status);

                    return subscribe;
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

            return null;

        }
    }
}

