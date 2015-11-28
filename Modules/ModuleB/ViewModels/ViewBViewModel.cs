using Prism.Mvvm;
using System.ComponentModel.Composition;

namespace ModuleB.ViewModels
{
    [Export]
    public class ViewBViewModel : BindableBase
    {
        private string _title = "Module B";
        public string Title 
        {
            get { return this._title; }
            set { this.SetProperty<string>(ref this._title, value); }
        }

        public ViewBViewModel()
        {

        }
    }
}
