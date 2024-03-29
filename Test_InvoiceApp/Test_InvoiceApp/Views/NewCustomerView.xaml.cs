﻿using Test_InvoiceApp.ViewModels;

namespace Test_InvoiceApp.Views
{
    /// <summary>
    /// Interaction logic for NewCustomerView.xaml
    /// </summary>
    public partial class NewCustomerView
    {
        public NewCustomerView()
        {
            InitializeComponent();
        }


        private void Create_OnClick(object sender, RoutedEventArgs e)
        {
            NewCustomerViewModel vm = (NewCustomerViewModel)DataContext;
            if (vm.ValidationNewCustomer())
            {
                vm.CreateCustomer();
                Close();
            }
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NewCustomerView_OnLoaded(object sender, RoutedEventArgs e)
        {
            NewCustomerViewModel vm = (NewCustomerViewModel)DataContext;

            vm.GetCustomerType();
        }
    }
}
