using System.Linq;
using System.ServiceModel;
using WcfTestProject;

namespace WcfTestProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class GeneralService : IGeneralService
    {
        private readonly EmailPro _context;
        public GeneralService(EmailPro context)
        {
            _context = context;
        }

        public bool IsThereAUser(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username) != null;
        }

        public string Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                if (user.Password == password)
                {
                    user.IsActive = true;
                    _context.SaveChanges();
                    return user.Username;
                }
                return "Password";
            }
            return "Username";
        }

        public void Logout(string username)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            user.IsActive = false;
            _context.SaveChanges();
        }

        public bool Register(string username, string password)
        {
            if (!IsThereAUser(username))
            {
                var user = new User(username, password, false);
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
