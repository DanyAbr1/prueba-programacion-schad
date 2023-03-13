using Test_InvoiceApp.Core;

namespace Test_InvoiceApp.Services;

public interface INavigationService
{
    ViewModel CurrentView { get; }
    void NavigateTo<T>() where T : ViewModel;
}