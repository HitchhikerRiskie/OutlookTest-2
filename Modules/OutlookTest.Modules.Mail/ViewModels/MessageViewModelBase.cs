using OutlookTest.Business;
using OutlookTest.Core;
using OutlookTest.Services.Interfaces;
using Prism.Commands;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookTest.Modules.Mail.ViewModels
{
    public class MessageViewModelBase : ViewModelBase
    {
        private MailMessage _message;
        protected IRegionDialogService RegionDialogService { get; private set; }


        protected IMailService MailService { get; private set; }

        public MailMessage Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public MessageViewModelBase(IMailService mailService, IRegionDialogService regionDialogService)
        {
            MailService = mailService;
            RegionDialogService = regionDialogService;
        }

        private DelegateCommand _deleteMessageCommand;
        public DelegateCommand DeleteMessageCommand =>
            _deleteMessageCommand ?? (_deleteMessageCommand = new DelegateCommand(ExecuteDeleteMessage));

        private DelegateCommand<string> _messageCommand;
        public DelegateCommand<string> MessageCommand =>
            _messageCommand ?? (_messageCommand = new DelegateCommand<string>(ExecuteMessageCommand));

        protected virtual void ExecuteDeleteMessage()
        {
            if (Message == null)
                return;

            MailService.DeleteMessage(Message.Id);
        }

        void ExecuteMessageCommand(string parameter)
        {
            if (Message == null)
                return;

            var parameters = new DialogParameters();
            var viewName = "MessageView";
            MessageModes replyType = MessageModes.Read;

            switch (parameter)
            {
                case nameof(MessageModes.Read):
                    {
                        viewName = "MessageReadOnlyView";
                        replyType = MessageModes.Read;
                        break;
                    }
                case nameof(MessageModes.Reply):
                    {
                        replyType = MessageModes.Reply;
                        break;
                    }
                case nameof(MessageModes.ReplyAll):
                    {
                        replyType = MessageModes.ReplyAll;
                        break;
                    }
                case nameof(MessageModes.Forward):
                    {
                        replyType = MessageModes.Forward;
                        break;
                    }
            }

            parameters.Add(MailParameters.MessageId, Message.Id);
            parameters.Add(MailParameters.MessageMode, replyType);

            RegionDialogService.Show(viewName, parameters, (result) =>
            {
                HandleMessageCallBack(result);
            });
        }
        protected virtual void HandleMessageCallBack(IDialogResult result) 
        {

        }
    }
}
