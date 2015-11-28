using Prism.Mvvm;
using System.ComponentModel.Composition;

namespace ModuleA.ViewModels
{
    [Export]
    public class ViewAViewModel : BindableBase
    {
        private string _title = "Module A";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        } 
    }
}
