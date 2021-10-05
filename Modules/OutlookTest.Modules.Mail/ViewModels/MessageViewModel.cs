﻿using OutlookTest.Business;
using OutlookTest.Core;
using OutlookTest.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
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
            var messageId = parameters.GetValue<int>("id");
            if (messageId == 0)
                Message = new MailMessage() { From = "changlee1009@naver.com"};
            else 
                Message = _mailService.GetMessage(messageId);
        }
    }
}
