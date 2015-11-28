using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace ModuleB.Views
{
    /// <summary>
    /// Interaction logic for ViewB.xaml
    /// </summary>
    [Export(typeof(ViewB))]
    public partial class ViewB : UserControl
    {
        public ViewB()
        {
            InitializeComponent();
        }
    }
}
