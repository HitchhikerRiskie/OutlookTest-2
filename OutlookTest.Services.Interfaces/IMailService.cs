using OutlookTest.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookTest.Services.Interfaces
{
    public interface IMailService
    {
        IList<MailMessage> GetInboxItems();
        IList<MailMessage> GetSentItems();
        IList<MailMessage> GetDeletedItems();

        MailMessage GetMessage(int id);
        void DeleteMessage(int id);
        void SendMessage(MailMessage message);
    }
}
