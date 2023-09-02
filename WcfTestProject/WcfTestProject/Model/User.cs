using System;
using System.Runtime.Serialization;

namespace WcfTestProject
{
    [DataContract]
    public class User : DbObject
    {
        public string Password { get; set; }
        public string Token { get; set; }
        [DataMember] public string Username { get; set; } // unique
        [DataMember] public bool IsActive { get; set; }
        //[DataMember]
        //public List<Message> Messages { get; set; } = new List<Message>();
        public User(string username, string password, bool isActive)
        {
            Password = password;
            Username = username;
            IsActive = isActive;
            Token = Guid.NewGuid().ToString();
        }
        public User()
        {

        }
    }
}