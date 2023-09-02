using System.ServiceModel;

namespace WcfTestProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGeneralService
    {
        [OperationContract]
        string Login(string username, string password);

        [OperationContract]
        void Logout(string username);
        [OperationContract]
        bool Register(string username, string password);
        [OperationContract]
        bool IsThereAUser(string username);
    }
}
