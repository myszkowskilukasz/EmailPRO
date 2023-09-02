using System.Collections.Generic;
using System.ServiceModel;
using WcfTestProject;

namespace WcfTestProject
{
    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        IEnumerable<User> GetAllUsers();
        [OperationContract]
        User GetUserById(int id);
        [OperationContract]
        User GetUserByUsername(string username);
        [OperationContract]
        void UpdateUser(User user);
        [OperationContract]
        void DeleteUser(int id);
        [OperationContract]
        bool IsUserActive(int id);

    }
}
