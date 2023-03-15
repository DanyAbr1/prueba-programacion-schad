using Test_InvoiceApp.Core;
using Test_InvoiceApp.Helper;

namespace Test_InvoiceApp.ViewModels;

public class NewCustomerTypeViewModel : ViewModel
{
    private string _description;

    public NewCustomerTypeViewModel()
    {

    }

    public string Description
    {
        get => _description;
        set
        {
            _description = value;
            OnPropertyChanged();
        }
    }

    public void CreateCustomerType()
    {

        try
        {
            var customerType = new CustomerType()
            {
                Description = Description
            };

            DbContextHelper.DbContext.CustomerTypes.Add(customerType);
            DbContextHelper.DbContext.SaveChanges();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

    }

}

