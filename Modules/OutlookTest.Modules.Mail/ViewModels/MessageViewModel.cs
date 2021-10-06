using OutlookTest.Business;
using OutlookTest.Core;
using OutlookTest.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace OutlookTest.Modules.Mail.ViewModels
{
    public class MessageViewModel : BindableBase, IDialogAware
    {
        private DelegateCommand _sendMessageCommand;
        private readonly IMailService _mailService;

        private MailMessage _message;
        public MailMessage Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public DelegateCommand SendMessageCommand =>
            _sendMessageCommand ?? (_sendMessageCommand = new DelegateCommand(ExecuteSendMessageName));

        void ExecuteSendMessageName()
        {
            _mailService.SendMessage(Message);

            IDialogParameters parameters = new DialogParameters();
            parameters.Add("messageSent", Message);

            RequestClose?.Invoke(new DialogResult(ButtonResult.Yes, parameters));
        }
        public MessageViewModel(IMailService mailService)
        {
            _mailService = mailService;
        }

        public string Title => "Mail Message";
        
        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
        }
        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = new MailMessage() { From = "changlee1009@naver.com" };
            Message.Id = new Random().Next(10, 6000);

            var messageMode = parameters.GetValue<MessageModes>(MailParameters.MessageMode);
            if (messageMode != MessageModes.New)
            {
                var messageId = parameters.GetValue<int>(MailParameters.MessageId);
                var originalMessage = _mailService.GetMessage(messageId);

                Message.To = GetToEmails(messageMode, originalMessage);
                if(messageMode == MessageModes.Reply || messageMode == MessageModes.ReplyAll)
                    Message.CC = originalMessage.CC;
                Message.Subject = GetMessageSubject(messageMode, originalMessage);



                Message.Body = originalMessage.Body;
            }
        }

        string GetMessageSubject(MessageModes mode, MailMessage originalMessage)
        {
            string prefix = string.Empty;

            switch (mode)
            {
                case MessageModes.Reply:
                case MessageModes.ReplyAll:
                    {
                        prefix = "RE:";
                        break;
                    }
                case MessageModes.Forward:
                    {
                        prefix = "FW:";
                        break;
                    }
            }

            return originalMessage.Subject.ToLower().StartsWith(prefix.ToLower()) ? originalMessage.Subject : $"{prefix} {originalMessage.Subject}";
        }

        ObservableCollection<string> GetToEmails(MessageModes mode, MailMessage message) 
        {
            var toEmails = new ObservableCollection<string>();
            switch (mode)
            {
                case MessageModes.Reply:
                    {
                        toEmails.Add(message.From);
                        break;
                    }
                case MessageModes.ReplyAll:
                    {
                        //TODO : use user email
                        toEmails.AddRange(message.To.Where( x => x != "changlee1009@naver.com"));
                        toEmails.Add(message.From);
                        break;
                    }
                case MessageModes.Forward:
                    {
                        break;
                    }
            }

            return toEmails;
        }
    }
}
