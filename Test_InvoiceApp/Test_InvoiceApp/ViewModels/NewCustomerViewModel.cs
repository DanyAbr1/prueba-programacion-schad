using Microsoft.EntityFrameworkCore.ChangeTracking;
using Test_InvoiceApp.Core;
using Test_InvoiceApp.Helper;

namespace Test_InvoiceApp.ViewModels;

public class NewCustomerViewModel : ViewModel
{
    private string _custName;
    private string _address;

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

    public void CreateCustomer()
    {

        try
        {
            var customer = new Customer
            {
                CustName = CustName,
                Adress = Address,
                Status = true,
                CustomerTypeId = 1
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

