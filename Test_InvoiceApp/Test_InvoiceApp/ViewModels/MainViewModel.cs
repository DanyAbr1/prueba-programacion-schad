using Test_InvoiceApp.Core;
using Test_InvoiceApp.Helper;
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
    

    public RelayCommand NavigateToCustomerType { get; set; }
    public RelayCommand NavigateToCustomer { get; set; }

    public MainViewModel(INavigationService navigationService)
    {
        Navigation = navigationService;
        NavigateToCustomerType = new RelayCommand(obj => { Navigation.NavigateTo<CustomerTypeViewModel>(); }, o => true);
        NavigateToCustomer = new RelayCommand(obj => { Navigation.NavigateTo<CustomerViewModel>(); }, o => true);
    }
}
