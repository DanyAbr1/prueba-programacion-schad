using System.Windows.Controls;
using System.Windows.Input;
using Test_InvoiceApp.ViewModels;

namespace Test_InvoiceApp.Views;

/// <summary>
/// Interaction logic for HomeView.xaml
/// </summary>
public partial class CustomerTypeView : UserControl
{
    public CustomerTypeView()
    {
        InitializeComponent();
    }

    private void Border_MouseDown(object sender, MouseButtonEventArgs e)
    {
        NewCustomerTypeView view = new NewCustomerTypeView();
        view.ShowDialog();
        CustomerTypeViewModel vm = (CustomerTypeViewModel)DataContext;
        vm.GetCustomerTypes();
    }

    private void CustomerTypesView_OnLoaded(object sender, RoutedEventArgs e)
    {
        CustomerTypeViewModel vm = (CustomerTypeViewModel)DataContext;
        vm.GetCustomerTypes();
    }

    private void Delete_OnClick(object sender, RoutedEventArgs e)
    {
        object? item = ((sender as Button)?.Tag as ListViewItem)?.DataContext;
        CustomerType? customer = (item as CustomerType);

        if (customer != null)
        {
            CustomerTypeViewModel vm = (CustomerTypeViewModel)DataContext;
            vm.RemoveCustomer(customer);
        }

    }

    private void Search_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        CustomerTypeViewModel vm = (CustomerTypeViewModel)DataContext;
        if (!string.IsNullOrEmpty(SearchTxt.Text))
        {
            vm.SearchCustomer(SearchTxt.Text);
        }
        else
        {
            vm.GetCustomerTypes();
        }
    }

    private void Edit_OnClick(object sender, RoutedEventArgs e)
    {
        object? item = ((sender as Button)?.Tag as ListViewItem)?.DataContext;
        CustomerType? customerType = (item as CustomerType);

        if (customerType != null)
        {
            UpdateCustomerTypesView view = new();
            view.TxtDescription.Text = customerType.Description;
            view.CustomerTypeUpdate = customerType;
            view.ShowDialog();
            CustomerTypeViewModel vm = (CustomerTypeViewModel)DataContext;
            vm.GetCustomerTypes();
        }
    }
}