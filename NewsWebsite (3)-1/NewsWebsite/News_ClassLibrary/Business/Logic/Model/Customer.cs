using News_ClassLibrary.Business.Logic.Classes;
using SynthesisClassLibrary.Interface;


namespace SynthesisClassLibrary
{
    public class Customer : Person
    {


        public Customer()
        { }


        public Customer(int id, string Firstname, string Lastname, string Username, string Email, string Password, string zipcode, string role) //IProduct iproduct, IEmployeeReservation iresevation, IDamageReport idamageReport) 
            : base(id, Firstname, Lastname, Username, Email, Password, zipcode, role)
        {

        }

        public Customer(string Firstname, string Lastname, string Username, string Email, string Password, string zipcode, string role)
             : base(Firstname, Lastname, Username, Email, Password, zipcode, role)
        {



        }


        public bool ISCustomers()
        {
            return this.Roles != null && this.Roles.Contains(Role.Customer);
        }

    }
}
