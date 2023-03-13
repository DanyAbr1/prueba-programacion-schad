using Test_InvoiceApp.Core;
using Test_InvoiceApp.Services;

namespace Test_InvoiceApp.ViewModels;

public class MainViewModel : ViewModel
{

    private INavigationService _navigation;

    public INavigationService Navigation
    {
        get => _navigation;
        set
        {
            _navigation = value;
            OnPropertyChanged();
        }
    }

    public RelayCommand NavigateToHome { get; set; }
    public RelayCommand NavigateToCustomer { get; set; }

    public MainViewModel(INavigationService navigationService)
    {
        Navigation = navigationService;
        NavigateToHome = new RelayCommand(obj => { Navigation.NavigateTo<HomeViewModel>(); }, o => true);
        NavigateToCustomer = new RelayCommand(obj => { Navigation.NavigateTo<CustomerViewModel>(); }, o => true);
    }
}
