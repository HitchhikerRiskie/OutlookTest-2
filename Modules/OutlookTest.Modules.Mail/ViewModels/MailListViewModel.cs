﻿using Prism.Commands;
using Prism.Regions;
using Prism.Services.Dialogs;
using OutlookTest.Business;
using OutlookTest.Core;
using OutlookTest.Services.Interfaces;
using System.Collections.ObjectModel;
using System.Linq;

namespace OutlookTest.Modules.Mail.ViewModels
{
    public class MailListViewModel : ViewModelBase
    {
        private ObservableCollection<MailMessage> _messages = new ObservableCollection<MailMessage>();
        private readonly IMailService _mailService;
        private readonly IRegionDialogService _regionDialogService;
        private string _currentFolder = FolderParameters.Inbox;

        public ObservableCollection<MailMessage> Messages
        {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }

        private MailMessage _selectedMessage;
        public MailMessage SelectedMessage
        {
            get { return _selectedMessage; }
            set { SetProperty(ref _selectedMessage, value); }
        }

        private DelegateCommand _newMessageCommand;
        public DelegateCommand NewMessageCommand =>
            _newMessageCommand ?? (_newMessageCommand = new DelegateCommand(ExecuteNewMessageCommand));

        void ExecuteNewMessageCommand()
        {
            var parameters = new DialogParameters();
            parameters.Add("id", 0);

            _regionDialogService.Show("MessageView", parameters, (result) =>
            {
                // if on sent folder, add to message collection
                if (_currentFolder == FolderParameters.Sent)
                    Messages.Add(result.Parameters.GetValue<MailMessage>("messageSent"));
            });
        }

        private DelegateCommand _deleteMessageCommand;
        public DelegateCommand DeleteMessageCommand =>
            _deleteMessageCommand ?? (_deleteMessageCommand = new DelegateCommand(ExecuteDeleteMessage));

        void ExecuteDeleteMessage()
        {
            if (SelectedMessage == null)
                return ;

            _mailService.DeleteMessage(SelectedMessage.Id);

            Messages.Remove(SelectedMessage);
        }

        private DelegateCommand<string> _messageCommand;

        public DelegateCommand<string> MessageCommand =>
            _messageCommand ?? (_messageCommand = new DelegateCommand<string>(ExecuteMessageCommand));

        public string Title => "Testing";

        void ExecuteMessageCommand(string parameter)
        {
            if (SelectedMessage == null)
                return;

            var parameters = new DialogParameters();
            parameters.Add("id", SelectedMessage.Id);

            _regionDialogService.Show("MessageView", parameters, (result) => 
            {
            });
        }

        public MailListViewModel(IMailService mailService, IRegionDialogService regionDialogService)
        {
            _mailService = mailService;
            _regionDialogService = regionDialogService;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            _currentFolder = navigationContext.Parameters.GetValue<string>(FolderParameters.FolderKey);

            LoadMessage(_currentFolder);

            SelectedMessage = Messages.FirstOrDefault();
        }

        void LoadMessage(string folder)
        {
            switch (folder)
            {
                case FolderParameters.Inbox:
                    {
                        Messages = new ObservableCollection<MailMessage>(_mailService.GetInboxItems());
                        break;
                    }
                case FolderParameters.Sent:
                    {
                        Messages = new ObservableCollection<MailMessage>(_mailService.GetSentItems());
                        break;
                    }
                case FolderParameters.Deleted:
                    {
                        Messages = new ObservableCollection<MailMessage>(_mailService.GetDeletedItems());
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
