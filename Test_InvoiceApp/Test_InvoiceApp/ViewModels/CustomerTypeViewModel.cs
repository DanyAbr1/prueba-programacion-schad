using System.Collections.Generic;
using System.Linq;
using Test_InvoiceApp.Core;
using Test_InvoiceApp.Helper;

namespace Test_InvoiceApp.ViewModels;

public class CustomerTypeViewModel : ViewModel
{
    private List<CustomerType> _customerTypesList = new();

    public CustomerTypeViewModel()
    {

    }

    public List<CustomerType> CustomerTypesList
    {
        get => _customerTypesList;
        set
        {
            _customerTypesList = value;
            OnPropertyChanged();
        }
    }


    public void GetCustomerTypes()
    {
        CustomerTypesList = DbContextHelper.DbContext.CustomerTypes.AsNoTracking().ToList();
    }

    public void SearchCustomer(string value)
    {
        CustomerTypesList = DbContextHelper.DbContext.CustomerTypes.AsNoTracking()
            .Where(item => item.Description!.Contains(value))
            .ToList();
    }


    public void RemoveCustomer(CustomerType customerType)
    {
        try
        {
            DbContextHelper.DbContext.CustomerTypes.Remove(customerType);
            DbContextHelper.DbContext.SaveChanges();
            GetCustomerTypes();
        }
        catch
        {
            DbContextHelper.DbContext.CustomerTypes.Remove(customerType);
            DbContextHelper.DbContext.SaveChanges();
            GetCustomerTypes();
        }

    }
}

