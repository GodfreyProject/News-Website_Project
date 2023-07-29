//using SynthesisClassLibrary.dbClasses;
//using SynthesisClassLibrary.Interface;
using News_ClassLibrary.Business.Logic.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisClassLibrary
{
    public class Admin : Person
    {
        

        public Admin()
        { }

      

        public Admin(int id, string Firstname, string Lastname, string Username,string Email, string Password, string zipcode, string role) //IProduct iproduct, IEmployeeReservation iresevation, IDamageReport idamageReport) 
            : base(id, Firstname, Lastname,  Username, Email, Password, zipcode, role)
        {
            
        }

        public Admin( string Firstname, string Lastname, string Username, string Email, string Password, string zipcode, string role)
             : base( Firstname, Lastname, Username, Email, Password, zipcode, role)
        {
           
          

        }

        public Admin(string Firstname, string Lastname, string Username, string Email, string Password, string zipcode)
            : base(Firstname, Lastname, Username, Email, Password, zipcode)
        {



        }

        public bool ISAdmin()
        {
            return this.Roles != null && this.Roles.Contains(Role.Admin);
        }
    }
}
