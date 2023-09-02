using System;
using System.Linq;
using System.Runtime.Serialization;

namespace WcfTestProject.Model
{
    [DataContract]
    public class Message : DbObject
    {
        [DataMember]
        public string To { get; set; }
        [DataMember]
        public string From { get; set; }
        [DataMember]
        public string Content { get; set; }
        [DataMember]
        public DateTime SentOn { get; set; }
        [DataMember]
        public bool IsRead { get; set; }
        public Message(string to, string from, string content, DateTime sentOn, bool isRead)
        {
            To = to;
            From = from; 
            Content = content;
            SentOn = sentOn;
            IsRead = isRead;
        }
        public Message()
        {

        }

        public override string ToString()
        {
            return $"{From}, {SentOn:R}\n" + //.ToString("R")
                $"{Content.Take(20)}...";
        }
    }
}