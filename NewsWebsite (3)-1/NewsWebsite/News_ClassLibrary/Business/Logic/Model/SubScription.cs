using System;
using System.Collections.Generic;
using System.Text;

namespace News_ClassLibrary.Business.Logic.Model
{
  public class SubScription
    {
        public int SubID { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Email { get; set; }

        public String Payment { get; set; }

        public String Month { get; set; }

        public String Status { get; set; }


        public SubScription()
        {

        }

        public SubScription(int id, string first, string last, String email, string pay, string month, string status)
        {
            this.SubID = id;
            this.FirstName = first;
            this.LastName = last;
            this.Email = email;
            this.Payment = pay;
            this.Month = month;
            this.Status = status;
        }

        public override string ToString()
        {
            return $"SubID: {SubID}: FirstName {FirstName}: LastName: {LastName}: Email: {Email}: Payment: {Payment}: Month: {Month}: Payed: {Status}";
        }
    }
}
