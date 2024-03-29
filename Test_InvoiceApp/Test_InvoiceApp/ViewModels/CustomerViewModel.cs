﻿using System.Collections.Generic;
using System.Linq;
using Test_InvoiceApp.Core;
using Test_InvoiceApp.Helper;

namespace Test_InvoiceApp.ViewModels;

public class CustomerViewModel : ViewModel
{
    private List<Customer> _customerList = new();

    public CustomerViewModel()
    {
    }

    public List<Customer> CustomerList
    {
        get => _customerList;
        set
        {
            _customerList = value;
            OnPropertyChanged();
        }
    }

    public void GetCustomer()
    {
        CustomerList = DbContextHelper.DbContext.Customers.Include(c => c.CustomerType).AsNoTracking().ToList();
    }


    public void SearchCustomer(string value)
    {
        CustomerList = DbContextHelper.DbContext.Customers.AsNoTracking()
            .Where(item => item.CustName!.Contains(value) || item.Adress!.Contains(value))
            .ToList();
    }


    public void RemoveCustomer(Customer customer)
    {
        try
        {
            DbContextHelper.DbContext.Customers.Remove(customer);
            DbContextHelper.DbContext.SaveChanges();
            GetCustomer();
        }
        catch
        {
            DbContextHelper.DbContext.Customers.Remove(customer);
            DbContextHelper.DbContext.SaveChanges();
            GetCustomer();
        }

    }
}

