using News_ClassLibrary.Business.Logic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace News_ClassLibrary.Business.ManagerInterface
{
   public interface ISubscribeRepository
    {
        public List<SubScription> GetAllSubsscription();

        public List<SubScription> GetSubScription(String FirstName);
        public SubScription GetSubScribe(int ID);

        // Add

        public bool Subscribe(string Firstname, string Lastname, string Email, string Payment, String Month, String Status);

        public bool UnSubscribe(int ID);
    }
}
