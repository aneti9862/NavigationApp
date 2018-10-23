using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Diagnostics;
using TestApp.Views;
using Xamarin.Forms;

namespace TestApp.ViewModels
{
    public class BasePageViewModel : BindableBase, INavigationAware
    {
        public BasePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            Debug.WriteLine("Navigated From BasePage");
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
        }

        private DelegateCommand _navigationCommand;
        public DelegateCommand NavigationCommand => _navigationCommand ?? (_navigationCommand = new DelegateCommand(NavigationMethod));

        private void NavigationMethod()
        {
            _navigationService.NavigateAsync("ViewA");               
        }

        private INavigationService _navigationService;
    }
}
