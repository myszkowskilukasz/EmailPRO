using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using WcfTestProject.Interfaces;
using WcfTestProject.Model;

namespace WcfTestProject.Interface_Implementations
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class AdminService : IAdminService
    {
        private readonly EmailPro _context;
        public AdminService(EmailPro context)
        {
            _context = context;
        }
        public void DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }

        public bool IsUserActive(int id)
        {
            return _context.Users.Find(id).IsActive;
        }

        public void UpdateUser(User user)
        {
            _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
