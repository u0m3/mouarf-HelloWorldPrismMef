using Infrastructure;
using ModuleC.Views;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace ModuleC
{
    [ModuleExport(typeof(ModuleCModule))]
    public class ModuleCModule : IModule
    {
        private readonly IRegionManager _regionManager;

        [ImportingConstructor]
        public ModuleCModule(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
        }

        public void Initialize()
        {
            this._regionManager.RegisterViewWithRegion(RegionNames.LeftRegion, typeof(ViewC));
        }
    }
}
