using MicroERP.Core;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace MicroERP.Modules.NavigationMenu
{
    public class NavigationMenuModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public NavigationMenuModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.NavigationMenuRegion, typeof(Views.NavigationMenu));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}