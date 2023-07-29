 using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace SynthesisClassLibrary.dbClasses
{
   public class dbConnection
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn =
                new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi426309;Database=dbi426309;Pwd=dbi426309;SslMode =none;");
            return conn;
        }

        public static string hashPassword(string Password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] Password_bytes = Encoding.ASCII.GetBytes(Password);

            byte[] encrypted_bytes =  sha1.ComputeHash(Password_bytes);

            return Convert.ToBase64String(encrypted_bytes);
           
        }
    }
}
