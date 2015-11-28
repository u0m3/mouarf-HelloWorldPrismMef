using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace ModuleC.Views
{
    /// <summary>
    /// Interaction logic for ViewC.xaml
    /// </summary>
    [Export(typeof(ViewC))]
    public partial class ViewC : UserControl
    {
        public ViewC()
        {
            InitializeComponent();
        }
    }
}
