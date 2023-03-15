using Test_InvoiceApp.Core;

namespace Test_InvoiceApp.Services;

internal class NavigationService : ObservableObject, INavigationService
{
    private readonly Func<Type, ViewModel> _viewModelFactory;
    private ViewModel _currentView;

    public ViewModel CurrentView
    {
        get => _currentView;
        set
        {
            _currentView = value;
            OnPropertyChanged();
        }
    }

    public NavigationService(Func<Type, ViewModel> viewModelFactory)
    {
        _viewModelFactory = viewModelFactory;
    }
    public void NavigateTo<T>() where T : ViewModel
    { 
        CurrentView = _viewModelFactory.Invoke(typeof(T));
    }
}