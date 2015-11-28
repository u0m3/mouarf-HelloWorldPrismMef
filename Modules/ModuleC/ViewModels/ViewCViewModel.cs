using Prism.Mvvm;
using System.ComponentModel.Composition;

namespace ModuleC.ViewModels
{
    [Export]
    public class ViewCViewModel : BindableBase
    {
        private string _title = "Module C";
        public string Title 
        {
            get { return this._title; }
            set { this.SetProperty<string>(ref this._title, value); }
        }
    }
}
