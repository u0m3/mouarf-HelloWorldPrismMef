using Infrastructure;
using ModuleA.Views;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace ModuleA
{
    [ModuleExport(typeof(ModuleAModule))]
    public class ModuleAModule : IModule
    {
        IRegionManager _regionManager;

        [ImportingConstructor]
        public ModuleAModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.CenterRegion, typeof(ViewA));
        }
    }
}
