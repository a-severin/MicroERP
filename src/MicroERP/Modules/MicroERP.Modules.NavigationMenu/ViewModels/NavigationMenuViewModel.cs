using Prism.Mvvm;

namespace MicroERP.Modules.NavigationMenu.ViewModels
{
    public class NavigationMenuViewModel : BindableBase
    {
        private string _message;

        public NavigationMenuViewModel()
        {
            Message = "View A from your Prism Module";
        }

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
    }
}