using System.Runtime.Serialization;

namespace WcfTestProject
{
    [DataContract]
    [KnownType(typeof(User))]
    [KnownType(typeof(Message))]
    public abstract class DbObject
    {
        [DataMember]
        public int Id { get; set; }
    }
}