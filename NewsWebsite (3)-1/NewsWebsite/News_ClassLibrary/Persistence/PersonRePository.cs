using MySql.Data.MySqlClient;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.ManagerInterface;
using PersonManagerTest.Business;
using SynthesisClassLibrary;
using SynthesisClassLibrary.dbClasses;
using SynthesisClassLibrary.ManagerClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace News_ClassLibrary.Persistence
{
   public class PersonRePository:IPersonRePository
    {
        private string GET_PERSON_USERNAME_PASSORD = "SELECT `PersonID`,`FirstName`,`LastName`,`UserName`,`Email`,`Password`,`Zipcode`, `Role` FROM `sperson` WHERE UserName = @Username and Password = @Password;";
        private string GET_PERSON_USERNAME = "SELECT `PersonID`,`FirstName`,`LastName`, `UserName`,`Email`, `Password`, `Zipcode`, `Role` FROM `sperson` WHERE UserName = @Username;";
        private string ADD_CUSTOMER = "INSERT into sperson (`FirstName`,`LastName`,`UserName`, `Email`,`Password`,`Zipcode`, `Role`) VALUES ( @FirstName , @LastName ,  @UserName, @Email ,  @Password , @zip, @role);";
        private string ADD_PERSON = "INSERT into sperson (`FirstName`,`LastName`,`UserName`, `Email`,`Password`,`Zipcode`, `Role`) VALUES ( @FirstName , @LastName , @UserName, @Email , @Password ,@zip, @role);";
        private string GET_CUSTOMER_ID_BY_NAME = "select PersonID from sperson where FirstName = @FirstName AND LastName = @LastName ;";
        private string UPDATE_PASSWORD = " Update sperson  SET `Password` = @Password where `PersonID` = @ID;";
        private string GET_PERSON_ID = "SELECT `PersonID`,`FirstName`,`LastName`, `UserName`, `Email`, `Password`, `Zipcode`, Role FROM `sperson` WHERE `PersonID` = @PerosnID;";
        private string UPDATE_PERSON = " Update sperson  SET `FirstName` = @FirstName, `LastName` = @LastName, `UserName` = @Username, `Email` = @Email, `Password` = @Password, `Zipcode` = @Address  where `PersonID` = @ID;"; //`Password` = @Password 
        private string UPDATE = " Update sperson  SET `FirstName` = @FirstName, `LastName` = @LastName, `UserName` = @Username, `Email` = @Email,  `Zipcode` = @Address  where `PersonID` = @ID;"; //`Password` = @Password /*`Password` = @Password,*/
        //@Password
        private string GET_ALL_PEOPLE = "SELECT * FROM sperson";

        // REMOVE PERSON
        private static string REMOVE_PERSON = "DELETE FROM sperson WHERE PersonID=@id";

        // Get UserRole 

        private string GET_PERSON_ROLE = "SELECT * FROM sperson WHERE Role=@role";

        //private List<Person> people;

      
        public PersonRePository()
        {
            //people = new List<Person>();
            //GetAllPeople();
        }
        //Read


      
        public Person GetPersonBYUsername(string UserName)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            string sql = GET_PERSON_USERNAME;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Username", UserName);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Person person;

                while (reader.Read())
                {
                    if (reader[7].ToString() == "Admin")
                    {
                        person = new Admin(
                            Convert.ToInt32(reader[0]),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            reader[4].ToString(),
                            reader[5].ToString(),
                            reader[6].ToString(),
                            reader[7].ToString());


                        return person;
                    }
                    else if (reader[7].ToString() == "Customer")
                    {
                        person = new Customer(
                            Convert.ToInt32(reader[0]),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            reader[4].ToString(),
                            reader[5].ToString(),
                            reader[6].ToString(),
                            reader[7].ToString());

                        return person;
                    }
                }
            }
            //catch (MySqlException a)
            //{ Debug.WriteLine(a.Message); }
            catch (InvalidOperationException)
            { throw new InvalidOperationException("A person with that Username Already Exist"); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return null;
        }

        public List<Person> GetAllPeople()
        {
            MySqlConnection conn = dbConnection.GetConnection();
            string sql = GET_ALL_PEOPLE;
            List<Person> people = new List<Person>();
            Person person;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ID = reader.GetInt32("PersonID");
                    string Firstname = reader.GetString("FirstName");
                    string Lastname = reader.GetString("LastName");
                    string username = reader.GetString("UserName");
                    string email = reader.GetString("Email");
                    string password = reader.GetString("Password");
                    string Zipcode = reader.GetString("Zipcode");
                    string personType = reader.GetString("Role");

                    if (personType == "Admin")
                    {
                        person = new Admin(ID, Firstname, Lastname, username, email, password, Zipcode, personType);
                        people.Add(person);
                    }
                    else
                    {
                        if (personType == "Customer")
                        {
                            person = new Customer(ID, Firstname, Lastname, username, email, password, Zipcode, personType);
                            people.Add(person);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new LoginException();
            }
            finally
            {
                conn.Close();
            }

            return people;
        }
        // WAD WEBSITE ASP.NET RAZOR
        public Person GetPerson(string UserName, string Password)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            string sql = GET_PERSON_USERNAME_PASSORD;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Username", UserName);
                cmd.Parameters.AddWithValue("@Password", dbConnection.hashPassword(Password));

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Person person;

                while (reader.Read())
                {
                    if (reader[7].ToString() == "Admin")
                    {
                        person = new Admin(
                            Convert.ToInt32(reader[0]),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            reader[4].ToString(),
                            reader[5].ToString(),
                            reader[6].ToString(),
                            reader[7].ToString());


                        return person;
                    }
                    else if (reader[7].ToString() == "Customer")
                    {
                        person = new Customer(
                            Convert.ToInt32(reader[0]),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            reader[4].ToString(),
                            reader[5].ToString(),
                            reader[6].ToString(),
                            reader[7].ToString());

                        return person;
                    }
                }
            }
           
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return null;
        }
        public Person GetPerson(int ID)
        {
            MySqlConnection conn = dbConnection.GetConnection();

            string sql = GET_PERSON_ID;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@PerosnID", ID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Person person = new Customer();

                    person.ID = Convert.ToInt32(reader[0]);
                    person.FirstName = reader[1].ToString();
                    person.LastName = reader[2].ToString();
                    person.Username = reader[3].ToString();
                    person.Email = reader[4].ToString();
                    person.Password = reader[5].ToString();
                    person.Zipcode = reader[6].ToString();
                    person.UserRole = reader[7].ToString();
                    //return person;

                    person = new Admin();

                    person.ID = Convert.ToInt32(reader[0]);
                    person.FirstName = reader[1].ToString();
                    person.LastName = reader[2].ToString();
                    person.Username = reader[3].ToString();
                    person.Email = reader[4].ToString();
                    person.Password = reader[5].ToString();
                    person.Zipcode = reader[6].ToString();
                    person.UserRole = reader[7].ToString();

                    return person;


                }
            }
            
            catch (LoginException)
            { throw new LoginException(); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return null;
        }

        //Create

        // Use For the News website web Application WAD
        public int AddCustomer(string FirstName, string LastName, string UserName, string Email, string Password, string Zipcode, String Role)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            string sql = ADD_CUSTOMER;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);

                cmd.Parameters.AddWithValue("@Username", UserName);
                // cmd.Parameters.AddWithValue("@Address", Adress);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", dbConnection.hashPassword(Password));
                cmd.Parameters.AddWithValue("@zip", Zipcode);
                cmd.Parameters.AddWithValue("@role", Role);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();


                
            }
            //catch (MySqlException a)
            //{ Debug.WriteLine(a.Message); }
            catch (Exception)
            { throw new InvalidOperationException(); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            string sql2 = GET_CUSTOMER_ID_BY_NAME;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql2, conn);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);


                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return Convert.ToInt32(reader[0]);


                }
            }
           
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return 0;
        }

        //Update
        public bool UpdatePassword(int ID, string Password)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            string sql = UPDATE_PASSWORD;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Password", dbConnection.hashPassword(Password));

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

                if (numCreatedRows == 1)
                {
                    return true;
                }
                return false;
            }
          
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return false;
        }
        public bool UpdatePerson(int ID, string FirstName, string LastName, string UserName, string Email, String Password, string Zipcode)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            string sql = UPDATE_PERSON;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(ID));
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Username", UserName);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", dbConnection.hashPassword( Password));
                cmd.Parameters.AddWithValue("@Address", Zipcode);
              
             

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();
                if (numCreatedRows >= 1)
                {
                    //Login Login = new Login(new EmailManager());

                    //Login.emailManager.UpdateAcountInfo(FirstName, LastName, UserName, Email, Zipcode, ID);

                    return true;
                }
                return false;
            }
          
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return false;
        }
        public bool UpdatePersons(int ID, string FirstName, string LastName, string UserName, string Email,  string Zipcode)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            string sql = UPDATE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(ID));
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Username", UserName);
                cmd.Parameters.AddWithValue("@Email", Email);
                //cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Address", Zipcode);



                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();
                if (numCreatedRows >= 1)
                {
                    

                    return true;
                }
                return false;
            }
          
            catch (Exception a)
            { Debug.WriteLine(a.Message); }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return false;
        }
        // this is use for desktop application
        public Person GetUserRole(String UserType)
        {
            MySqlConnection conn = dbConnection.GetConnection();
            Person person = null;
            String SQl = GET_PERSON_ROLE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQl, conn);

                cmd.Parameters.AddWithValue("@role", UserType);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {

                    int PersonID = reader.GetInt32("PersonID");
                    String FirstName = reader.GetString("FirstName");
                    String LastName = reader.GetString("LastName");
                    String UserName = reader.GetString("UserName");
                    String Email = reader.GetString("Email");
                    String Password = reader.GetString("Password");
                    String Zipcode = reader.GetString("Zipcode");
                    UserType = reader.GetString("Role");


                    if (UserType == "Admin")
                    {
                        person = new Admin(FirstName, LastName, UserName, Email, Password, Zipcode, UserType);

                        return person;
                    }
                    else
                    {
                        if (UserType == "Customer")
                        {
                            person = new Customer(FirstName, LastName, UserName, Email, Password, Zipcode, UserType);

                            return person;
                        }
                    }
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
        // OOD DESKTOP APPLICATION
        public bool AddPerson(string FirstName, string LastName, string UserName, string Email, string Password, string Zipcode, string Role)
        {
            bool ISSuccessfull = false;

            MySqlConnection conn = dbConnection.GetConnection();
            String SQL = ADD_PERSON;
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Email", Email);

                cmd.Parameters.AddWithValue("@Password", dbConnection.hashPassword(Password));
                cmd.Parameters.AddWithValue("@zip", Zipcode);
                cmd.Parameters.AddWithValue("@role", Role);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                //Login Login = new Login(new EmailManager());

                //Login.emailManager.NewAcountInfo(FirstName, LastName, UserName, Email, Password, Zipcode, Role);

                if (reader is null)
                {
                    ISSuccessfull = false;
                }
                if (reader.RecordsAffected > 0)
                {
                  
                    ISSuccessfull = true;
                }
            }
          
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return ISSuccessfull;
        }
        public Person GetPersonAdminRole(String Role, String Password)
        {
            Person person = new Admin();

            String SQL = "SELECT * FROM sperson WHERE Role=@role AND Password=@pass";

            MySqlConnection conn = dbConnection.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@role", Role);
                cmd.Parameters.AddWithValue("@pass",dbConnection.hashPassword( Password));

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if(reader is null)
                {
                    return null;
                }

                while (reader.Read())
                {

                    int PersonID = reader.GetInt32("PersonID");
                    String FirstName = reader.GetString("FirstName");
                    String LastName = reader.GetString("LastName");
                    String UserName = reader.GetString("UserName");
                    String Email = reader.GetString("Email");
                     Password = reader.GetString("Password");
                    String Zipcode = reader.GetString("Zipcode");
                    Role = reader.GetString("Role");

                    person = new Admin(FirstName, LastName, UserName, Email, Password, Zipcode, Role);

                    return person;

                }
            }
           
            catch (Exception exp)
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

       
        public bool DeletePerson(int ID)
        {
            bool Success = false;

            MySqlConnection conn = dbConnection.GetConnection();

            try
            {
                String SQL = REMOVE_PERSON;

                MySqlCommand cmd = new MySqlCommand(SQL, conn);

                cmd.Parameters.AddWithValue("@id", ID);

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

        public bool PersonExist(int ID)
        {
            Person person = new Admin();

            bool Sucess = false;

            String SQL = "SELECT * FROM sperson ID=@id";

            MySqlConnection conn = dbConnection.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@id", ID);
               
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader is null)
                {
                    return false;
                }

                while (reader.Read())
                {

                    int PersonID = reader.GetInt32("PersonID");
                    String FirstName = reader.GetString("FirstName");
                    String LastName = reader.GetString("LastName");
                    String UserName = reader.GetString("UserName");
                    String Email = reader.GetString("Email");
                   String Password = reader.GetString("Password");
                    String Zipcode = reader.GetString("Zipcode");
                   String Role = reader.GetString("Role");

                    person = new Admin(FirstName, LastName, UserName, Email, Password, Zipcode, Role);

                    //return person;

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

            return Sucess;
        }

    }
}

