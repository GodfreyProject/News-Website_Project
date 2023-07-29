using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Business.Logic.Model;
using News_ClassLibrary.Business.ManagerInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace News_ClassLibrary.Business.ManagerClasses
{
    public class SubscribeManager
    {
        public ISubscribeRepository subscribeRepository;


        public SubscribeManager(ISubscribeRepository subscribe)
        {
            this.subscribeRepository = subscribe;
        }

        public bool Subscribe(string Firstname, string Lastname, string Email, string Payment, string Month, string Status)
        {
            if(this.subscribeRepository.Subscribe(Firstname, Lastname, Email, Payment, Month, Status))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<SubScription> GetAllSubsscription()
        {
            return this.subscribeRepository.GetAllSubsscription();
        }

        public List<SubScription> GetSubsscription(String FirstName)
        {
            return this.subscribeRepository.GetSubScription(FirstName);
        }
        public SubScription GetSubScribe(int ID)
        {
            return this.subscribeRepository.GetSubScribe(ID);
        }
        public bool UnSubscribe(int ID)
        {
            if (this.subscribeRepository.UnSubscribe(ID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}