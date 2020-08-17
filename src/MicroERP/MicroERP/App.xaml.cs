using Prism.Ioc;
using MicroERP.Views;
using System.Windows;
using Prism.Modularity;
using MicroERP.Modules.ModuleName;
using MicroERP.Modules.NavigationMenu;
using MicroERP.Services.Interfaces;
using MicroERP.Services;

namespace MicroERP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
            moduleCatalog.AddModule<NavigationMenuModule>();
        }
    }
}
