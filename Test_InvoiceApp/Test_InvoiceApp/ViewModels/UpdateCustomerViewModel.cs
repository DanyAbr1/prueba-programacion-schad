using System.Collections.Generic;
using System.Linq;
using Test_InvoiceApp.Core;
using Test_InvoiceApp.Helper;

namespace Test_InvoiceApp.ViewModels;

public class UpdateCustomerViewModel : ViewModel
{
    private CustomerType _customerTypeSelected;
    private List<CustomerType> _listCustomerTypes;

    public UpdateCustomerViewModel()
    {

    }

    public CustomerType CustomerTypeSelected
    {
        get => _customerTypeSelected;
        set
        {
            _customerTypeSelected = value;
            OnPropertyChanged();
        }
    }

    public List<CustomerType> ListCustomerTypes
    {
        get => _listCustomerTypes;
        set
        {
            _listCustomerTypes = value;
            OnPropertyChanged();
        }
    }


    public void GetCustomerType()
    {
        ListCustomerTypes = DbContextHelper.DbContext.CustomerTypes.ToList();
    }

    public void UpdateCustomer(Customer customer)
    {

        try
        {
            DbContextHelper.DbContext.Customers.Update(customer);
            DbContextHelper.DbContext.SaveChangesAsync();
        }
        catch
        {
            DbContextHelper.DbContext.Customers.Update(customer);
            DbContextHelper.DbContext.SaveChangesAsync();
        }
    }

}

