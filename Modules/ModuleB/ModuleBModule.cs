using Infrastructure;
using ModuleB.Views;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace ModuleB
{
    [ModuleExport(typeof(ModuleBModule))]
    public class ModuleBModule : IModule
    {
        private readonly IRegionManager _regionManager;

        [ImportingConstructor]
        public ModuleBModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.RightRegion, typeof(ViewB));
        }
    }
}
