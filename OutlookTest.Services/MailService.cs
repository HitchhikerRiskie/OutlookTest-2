using OutlookTest.Business;
using OutlookTest.Services.Interfaces;
using OutlookTest.Services.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookTest.Services
{
    public class MailService : IMailService
    {
        static List<MailMessage> InboxItems = new List<MailMessage>()
        {
            new MailMessage()
            {
                Id = 1,
                From = "changlee10091",
                To = new ObservableCollection<string>(){ "abc@cba.com", "abc@cba.com"},
                Subject = "this is email1",
                Body = Resources.DavidSmit_GraphicDesignerCoverLetter,
                DateSent = DateTime.Now
            },new MailMessage()
            {
                Id = 2,
                From = "changlee10092",
                To = new ObservableCollection<string>(){ "abc@cba.com", "abc@cba.com"},
                Subject = "this is email2",
                Body = Resources.DavidSmit_SampleCoverLetterEmail,
                DateSent = DateTime.Now.AddDays(-1)
            },new MailMessage()
            {
                Id = 3,
                From = "changlee10093",
                To = new ObservableCollection<string>(){ "abc@cba.com", "abc@cba.com"},
                Subject = "this is email3",
                Body = Resources.MargaretJones_RE_GraphicDesignerCoverLetter,
                DateSent = DateTime.Now.AddDays(-2)
            },new MailMessage()
            {
                Id = 4,
                From = "changlee10094",
                To = new ObservableCollection<string>(){ "abc@cba.com", "abc@cba.com"},
                Subject = "this is email4",
                Body = Resources.BarbaraBailey_RE_SampleCoverLetterEmail,
                DateSent = DateTime.Now.AddDays(-5)
            }
        };

        static List<MailMessage> SentItems = new List<MailMessage>();

        static List<MailMessage> DeletedItems = new List<MailMessage>();

        public void DeleteMessage(int id)
        {
            var messages = new List<MailMessage>();

            var message = DeletedItems.FirstOrDefault(m => m.Id == id);
            if (message != null)
            {
                DeletedItems.Remove(message);
                return;
            }

            message = InboxItems.FirstOrDefault(m => m.Id == id);
            if (message != null)
            {
                InboxItems.Remove(message);
            }
            else
            {
                message = SentItems.FirstOrDefault(m => m.Id == id);
                if (message != null)
                    SentItems.Remove(message);
            }

            if (message != null)
                DeletedItems.Add(message);
        }

        public IList<MailMessage> GetDeletedItems()
        {
            return DeletedItems;
        }

        public IList<MailMessage> GetInboxItems()
        {
            return InboxItems;
        }

        public MailMessage GetMessage(int id)
        {
            var messages = new List<MailMessage>();
            messages.AddRange(InboxItems);
            messages.AddRange(SentItems);
            messages.AddRange(DeletedItems);

            return messages.FirstOrDefault(m => m.Id == id);
        }

        public IList<MailMessage> GetSentItems()
        {
            return SentItems;
        }

        public void SendMessage(MailMessage message)
        {
            message.DateSent = DateTime.Now;
            SentItems.Add(message);
        }
    }
}
