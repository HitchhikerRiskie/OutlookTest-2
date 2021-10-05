using OutlookTest.Core;
using OutlookTest.Modules.Contacts.Menus;
using OutlookTest.Modules.Contacts.ViewModels;
using OutlookTest.Modules.Contacts.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace OutlookTest.Modules.Contacts
{
    public class ContactsModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ContactsModule(IRegionManager regionManager) {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(ContactsGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}