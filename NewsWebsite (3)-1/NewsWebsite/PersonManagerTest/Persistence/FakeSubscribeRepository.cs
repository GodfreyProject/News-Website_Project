using News_ClassLibrary.Business.Logic.Model;
using News_ClassLibrary.Business.ManagerInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonManagerTest.Persistence
{
    
   public class FakeSubscribeRepository:ISubscribeRepository
    {
        public List<SubScription> Scriptions = new List<SubScription>();

        public FakeSubscribeRepository(List<SubScription> subScriptions)
        {
            this.Scriptions = subScriptions;
        }

        public List<SubScription> GetAllSubsscription()
        {
            return this.Scriptions;
        }

        public SubScription GetSubScribe(int ID)
        {
          foreach(SubScription sub in this.Scriptions)
            {
                if(sub.SubID == ID)
                {
                    return sub;
                }
            }

            return null;

        }

        

        public List<SubScription> GetSubScription(string FirstName)
        {
            return this.Scriptions;
        }

        public bool Subscribe(string Firstname, string Lastname, string Email, string Payment, string Month, string Status)
        {
            SubScription sub = new SubScription();
            sub = new SubScription(0,Firstname, Lastname, Email, Payment, Month, Status);
            if(this.GetSubScribe(sub.SubID) != null)
            {
                this.Scriptions.Add(sub);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UnSubscribe(int ID)
        {
            foreach(SubScription sub in this.Scriptions)
            {
                if(sub.SubID == ID)
                {
                    this.Scriptions.Remove(sub);
                    return true;
                }
            }

            return false;
        }
    }
}
