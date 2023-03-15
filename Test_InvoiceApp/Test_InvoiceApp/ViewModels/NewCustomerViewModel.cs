using System.Collections.Generic;
using System.Linq;
using Test_InvoiceApp.Core;
using Test_InvoiceApp.Helper;
using Test_InvoiceApp.Models;

namespace Test_InvoiceApp.ViewModels;

public class NewCustomerViewModel : ViewModel
{
    private string _custName;
    private string _address;
    private List<CustomerType> _listCustomerTypes = new();
    private CustomerType _customerTypeSelected;

    public NewCustomerViewModel()
    {

    }

    public string CustName
    {
        get => _custName;
        set
        {
            _custName = value;
            OnPropertyChanged();
        }
    }

    public string Address
    {
        get => _address;
        set
        {
            _address = value;
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

    public CustomerType CustomerTypeSelected
    {
        get => _customerTypeSelected;
        set
        {
            _customerTypeSelected =value;
            OnPropertyChanged();
        }
    }

    public void GetCustomerType()
    {
        ListCustomerTypes = DbContextHelper.DbContext.CustomerTypes.ToList();
    }

    public void CreateCustomer()
    {

        try
        {
            var customer = new Customer
            {
                CustName = CustName,
                Adress = Address,
                Status = true,
                CustomerTypeId = CustomerTypeSelected.Id
            };

            DbContextHelper.DbContext.Customers.Add(customer);
            DbContextHelper.DbContext.SaveChanges();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

    }

}

