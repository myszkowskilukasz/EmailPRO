using System.Data.Entity;

namespace WcfTestProject.Model
{
    public class EmailPro : DbContext
    {
        public EmailPro()
            : base("name=EmailPro")
        {
            var ensureDllIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
    }
}