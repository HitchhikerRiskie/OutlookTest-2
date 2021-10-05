using Infragistics.Windows.OutlookBar;
using OutlookTest.Core;

namespace OutlookTest.Modules.Contacts.Menus
{
    /// <summary>
    /// ContactsGroup.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ContactsGroup : OutlookBarGroup, IOutlookBarGroup
    {
        public ContactsGroup()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath => "ViewA"; //임시
    }
}
