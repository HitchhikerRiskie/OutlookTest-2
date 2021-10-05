using OutlookTest.Core;
using OutlookTest.Modules.Contacts.Menus;
using System.Windows.Controls;

namespace OutlookTest.Modules.Contacts.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    [DependentView(RegionNames.RibbonRegion, typeof(HomeTab))]
    public partial class ViewA : UserControl
    {
        public ViewA()
        {
            InitializeComponent();
        }
    }
}
