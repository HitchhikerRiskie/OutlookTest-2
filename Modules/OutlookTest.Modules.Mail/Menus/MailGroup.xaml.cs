using Infragistics.Controls.Menus;
using Infragistics.Windows.OutlookBar;
using OutlookTest.Business;
using OutlookTest.Core;
using OutlookTest.Modules.Mail.ViewModels;
using System;
using System.Linq;
using System.Windows;

namespace OutlookTest.Modules.Mail.Menus
{
    /// <summary>
    /// MailGroup.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MailGroup : OutlookBarGroup, IOutlookBarGroup
    {
        public MailGroup()
        {
            InitializeComponent();

            _dataTree.Loaded += DataTree_Loaded;
        }
        private void DataTree_Loaded(object sender, RoutedEventArgs e)
        {
            var parentNode = _dataTree.Nodes[0];
            var nodeToSelect = parentNode.Nodes[0];
            nodeToSelect.IsSelected = true;
        }
        public string DefaultNavigationPath
        {
            get 
            {
                var item = _dataTree.SelectionSettings.SelectedNodes[0] as XamDataTreeNode;
                if (item != null)
                    return ((NavigationItem)item.Data).NavigationPath;

                return $"MailList?{FolderParameters.FolderKey}={FolderParameters.Inbox}";
            }
        }
    }
}
