using Test_InvoiceApp.Core;
using Test_InvoiceApp.Helper;
using Test_InvoiceApp.Views;

namespace Test_InvoiceApp.ViewModels;

public class UpdateCustomerTypesViewModel : ViewModel
{
    public UpdateCustomerTypesViewModel()
    {

    }

    public void UpdateCustomer(CustomerType customer)
    {
        try
        {
            DbContextHelper.DbContext.CustomerTypes.Update(customer);
            DbContextHelper.DbContext.SaveChangesAsync();
            DbContextHelper.DbContext.Entry(customer).State = EntityState.Detached;
        }
        catch
        {
            DbContextHelper.DbContext.CustomerTypes.Update(customer);
            DbContextHelper.DbContext.SaveChangesAsync();
            DbContextHelper.DbContext.Entry(customer).State = EntityState.Detached;

        }


    }

}

