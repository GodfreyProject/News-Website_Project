using ClassLibrary.Class;
using MySql.Data.MySqlClient;
using News_ClassLibrary.ManagerInterface;
using SynthesisClassLibrary.dbClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace News_ClassLibrary.Persistence
{
   public class ContactRePository : IContactRePository
    {

        private static string GET_ALL_CONTACT = "SELECT * FROM contact;";
        private static string ADD_CONTACT = "INSERT INTO contact (PersonID, FirstName, Email, Message) VALUES (@pid, @first, @email, @msg);";

    
        public bool AddNewContact(int PersonID, string Firstname, string Email, string Message)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            bool Sucess = false;

            String Sql = ADD_CONTACT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(Sql, conn);

                cmd.Parameters.AddWithValue("@pid", PersonID);
                cmd.Parameters.AddWithValue("@first", Firstname);

                cmd.Parameters.AddWithValue("@email", Email);

                cmd.Parameters.AddWithValue("@msg", Message);


                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader is null)
                {
                    Sucess = false;
                }

                if (reader.RecordsAffected > 0)
                {
                  

                    Sucess = true;
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

            return Sucess;
        }

        public Contact GetContact(int ID)
        {
            Contact contact = new Contact();

            MySqlConnection conn = dbConnection.GetConnection();
            String SQl = "SELECT * FROM contact WHERE ContactID=@id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQl, conn);

                cmd.Parameters.AddWithValue("@id", ID);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ID = reader.GetInt32("ContactID");
                    int PersonID = reader.GetInt32("PersonID");
                    string Firstname = reader.GetString("FirstName");
                    string Email = reader.GetString("Email");
                    string Message = reader.GetString("Message");

                    contact = new Contact(PersonID, Firstname, Email, Message);

                    return contact;

                }
            }
            catch (MySqlException exp)
            {
                Debug.WriteLine(exp.Message);
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }

            return null;
        }

        public List<Contact> GetContacts()
        {
            string sql = GET_ALL_CONTACT;
            MySqlConnection conn = dbConnection.GetConnection();
            List<Contact> contacts = new List<Contact>();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = reader.GetInt32("ContactID");
                    int PersonID = reader.GetInt32("PersonID");
                    string Firstname = reader.GetString("FirstName");
                    string Email = reader.GetString("Email");
                    string Message = reader.GetString("Message");

                    Contact contact = new Contact(ContactID, PersonID, Firstname, Email, Message);
                    contacts.Add(contact);
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

            return contacts;
        }
    }
}
