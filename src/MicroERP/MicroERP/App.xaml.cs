using Prism.Ioc;
using System.Windows;
using MicroERP.Routing;
using MicroERP.UI.CustomersScreen;
using MicroERP.UI.HomeScreen;
using Prism.Modularity;
using MicroERP.UI.Main;
using MicroERP.UI.NavigationMenu;
using MicroERP.UI.ProjectsScreen;
using MicroERP.UI.ResourcesScreen;
using Prism.Mvvm;
using Prism.Regions;

namespace MicroERP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            var regionManager = Container.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.NavigationMenuRegion, typeof(NavigationMenu));
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<MainWindow, MainViewModel>();
            ViewModelLocationProvider.Register<NavigationMenu, NavigationMenuViewModel>();
            ViewModelLocationProvider.Register<ProjectsScreen, ProjectsScreenViewModel>();
            ViewModelLocationProvider.Register<ResourcesScreen, ResourcesScreenViewModel>();
            ViewModelLocationProvider.Register<CustomersScreen, CustomersScreenViewModel>();


            containerRegistry.RegisterForNavigation<HomeScreen>(ScreenNames.HomeScreen);
            containerRegistry.RegisterForNavigation<ProjectsScreen>(ScreenNames.ProjectsScreen);
            containerRegistry.RegisterForNavigation<ResourcesScreen>(ScreenNames.ResourcesScreen);
            containerRegistry.RegisterForNavigation<CustomersScreen>(ScreenNames.CustomersScreen);
        }
    }
}