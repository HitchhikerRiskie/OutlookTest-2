using OutlookTest.Core;
using OutlookTest.Modules.Mail.Menus;
using OutlookTest.Modules.Mail.ViewModels;
using OutlookTest.Modules.Mail.Views;
using OutlookTest.Services;
using OutlookTest.Services.Interfaces;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace OutlookTest.Modules.Mail
{
    public class MailModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MailModule(IRegionManager regionManager) {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(MailGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<MailGroup, MailGroupViewModel>();

            containerRegistry.RegisterForNavigation<MailList, MailListViewModel>();

            containerRegistry.RegisterForNavigation<MessageView, MessageViewModel>();

            containerRegistry.RegisterSingleton<IMailService, MailService>();

            //containerRegistry.RegisterDialog<MessageView, MessageViewModel>();
        }
    }
}