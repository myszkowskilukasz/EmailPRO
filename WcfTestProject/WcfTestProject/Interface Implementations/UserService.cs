using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using WcfTestProject.Interfaces;
using WcfTestProject.Model;

namespace WcfTestProject.Interface_Implementations
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class UserService : IUserService
    {
        private readonly EmailPro _context;
        public UserService(EmailPro context)
        {
            _context = context;
        }

        public void DeleteMessage(string from, DateTime sentOn)
        {
            var message = _context.Messages.First(m => m.From == from 
                && DbFunctions.DiffDays(m.SentOn, sentOn) == 0 && DbFunctions.DiffHours(m.SentOn, sentOn) == 0 
                && DbFunctions.DiffMinutes(m.SentOn, sentOn) == 0 && DbFunctions.DiffSeconds(m.SentOn, sentOn) == 0);
            _context.Messages.Remove(message);
            _context.SaveChanges();
        }

        public void DeleteMessageById(int id)
        {
            var message = _context.Messages.First(m => m.Id == id);
            _context.Messages.Remove(message);
            _context.SaveChanges();
        }

        public IEnumerable<Message> GetReceivedMessages(string username)
        {
            var messages = _context.Messages.ToList().FindAll(m => m.To == username);
            return messages;
        }

        public IEnumerable<Message> GetSentMessages(string username)
        {
            var messages = _context.Messages.ToList().FindAll(m => m.From == username);
            return messages;
        }

        public bool IsMessageRead(int id)
        {
            return _context.Messages.First(m => m.Id == id).IsRead;
        }

        public bool IsUserActive(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username).IsActive;
        }

        public void ReadMessage(string from, DateTime sentOn)
        {
            _context.Messages.First(m => m.From == from
                && DbFunctions.DiffDays(m.SentOn, sentOn) == 0 && DbFunctions.DiffHours(m.SentOn, sentOn) == 0
                && DbFunctions.DiffMinutes(m.SentOn, sentOn) == 0 && DbFunctions.DiffSeconds(m.SentOn, sentOn) == 0)
                .IsRead = true;
            _context.SaveChanges();
        }

        public void ReadMessageById(int id)
        {
            _context.Messages.First(m => m.Id == id).IsRead = true;
            _context.SaveChanges();
        }

        public void SendMessage(string to, string from, string content, DateTime sentOn)
        {
            Message message = new Message(to, from, content, sentOn, false);
            _context.Messages.Add(message);
            _context.SaveChanges();
        }
    }
}
