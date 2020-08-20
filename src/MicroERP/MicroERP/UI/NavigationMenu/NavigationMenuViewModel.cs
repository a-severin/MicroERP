using System.Windows.Input;
using MicroERP.Routing;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace MicroERP.UI.NavigationMenu
{
    public class NavigationMenuViewModel : BindableBase
    {
        public NavigationMenuViewModel(IRegionManager regionManager)
        {
            OpenHomeScreenCommand = new DelegateCommand(() => regionManager.RequestNavigate(RegionNames.ContentRegion, ScreenNames.HomeScreen));
            OpenProjectsScreenCommand = new DelegateCommand(() => regionManager.RequestNavigate(RegionNames.ContentRegion, ScreenNames.ProjectsScreen));
            OpenResourcesScreenCommand = new DelegateCommand(() => regionManager.RequestNavigate(RegionNames.ContentRegion, ScreenNames.ResourcesScreen));
            OpenCustomersScreenCommand = new DelegateCommand(() => regionManager.RequestNavigate(RegionNames.ContentRegion, ScreenNames.CustomersScreen));
        }

        public DelegateCommand OpenHomeScreenCommand { get; }

        public DelegateCommand OpenProjectsScreenCommand { get; }

        public DelegateCommand OpenResourcesScreenCommand { get; }

        public DelegateCommand OpenCustomersScreenCommand { get; }
    }
}