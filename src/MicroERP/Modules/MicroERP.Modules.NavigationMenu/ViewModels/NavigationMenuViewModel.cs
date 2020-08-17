using Prism.Mvvm;

namespace MicroERP.Modules.NavigationMenu.ViewModels
{
    public class NavigationMenuViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public NavigationMenuViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}
