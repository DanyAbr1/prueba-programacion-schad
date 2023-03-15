using Test_InvoiceApp.Core;
using Test_InvoiceApp.Helper;

namespace Test_InvoiceApp.ViewModels;

public class UpdateCustomerViewModel : ViewModel
{
    public UpdateCustomerViewModel()
    {

    }

    public void UpdateCustomer(Customer customer)
    {
        if (customer != null)
        {
            DbContextHelper.DbContext.Customers.Update(customer);
            DbContextHelper.DbContext.SaveChangesAsync();
            DbContextHelper.DbContext.Entry(customer).State = EntityState.Detached;
        }

    }

}

