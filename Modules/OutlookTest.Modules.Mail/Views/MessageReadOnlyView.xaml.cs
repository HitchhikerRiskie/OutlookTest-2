using OutlookTest.Core;
using OutlookTest.Modules.Mail.Menus;
using System.Windows.Controls;

namespace OutlookTest.Modules.Mail.Views
{
    /// <summary>
    /// Interaction logic for MessageReadOnlyView
    /// </summary>
    [DependentView(RegionNames.RibbonRegion, typeof(MessageReadOnlyTab))]
    public partial class MessageReadOnlyView : UserControl, ISupportDataContext
    {
        public MessageReadOnlyView()
        {
            InitializeComponent();
        }
    }
}
