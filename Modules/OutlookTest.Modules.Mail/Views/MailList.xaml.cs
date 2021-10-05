using System.Windows.Controls;
using OutlookTest.Core;
using OutlookTest.Modules.Mail.Menus;

namespace OutlookTest.Modules.Mail.Views
{
    /// <summary>
    /// Interaction logic for MailList
    /// </summary>
    [DependentView(RegionNames.RibbonRegion, typeof(HomeTab))]
    public partial class MailList : UserControl, ISupportDataContext
    {
        public MailList()
        {
            InitializeComponent();
        }
    }
}
