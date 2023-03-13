using Test_InvoiceApp.Core;

namespace Test_InvoiceApp.ViewModels;

public class CustomerViewModel : ViewModel
{
    private readonly InvoiceAppContext _dbContext;

    public CustomerViewModel(InvoiceAppContext dbContext)
    {
        _dbContext = dbContext;
    }
}

