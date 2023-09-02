using System;
using System.Collections.Generic;
using System.ServiceModel;
using WcfTestProject;

namespace WcfTestProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        // TODO: Add your service operations here
        [OperationContract]
        IEnumerable<Message> GetSentMessages(string username);
        [OperationContract]
        IEnumerable<Message> GetReceivedMessages(string username);
        [OperationContract]
        void DeleteMessage(string from, DateTime sentOn);
        [OperationContract]
        void SendMessage(string to, string from, string content, DateTime sentOn);
        [OperationContract]
        bool IsUserActive(string username);
        [OperationContract]
        void ReadMessage(string from, DateTime sentOn);
        [OperationContract]
        void DeleteMessageById(int id);
        [OperationContract]
        void ReadMessageById(int id);
        [OperationContract]
        bool IsMessageRead(int id);
    }

}
