using OutlookTest.Business;
using OutlookTest.Core;
using OutlookTest.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OutlookTest.Modules.Mail.ViewModels
{
    public class MessageReadOnlyViewModel : MessageViewModelBase, IDialogAware
    {
        public event Action<IDialogResult> RequestClose;

        public string Title => "";
        public MessageReadOnlyViewModel(IMailService mailService, IRegionDialogService regionDialogService) : base(mailService,regionDialogService)
        {

        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            var messageId = parameters.GetValue<int>(MailParameters.MessageId);
            if (messageId != 0)
                Message = MailService.GetMessage(messageId);
        }

        protected override void ExecuteDeleteMessage()
        {
            base.ExecuteDeleteMessage();

            var p = new DialogParameters();
            p.Add(MailParameters.MessageMode, MessageModes.Delete);
            p.Add(MailParameters.MessageId, Message.Id);

            var result = new DialogResult(ButtonResult.OK, p);

            RequestClose(result);
        }
    }
}
