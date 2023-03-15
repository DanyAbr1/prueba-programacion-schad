using System.Windows.Controls;
using System.Windows.Input;
using Test_InvoiceApp.ViewModels;

namespace Test_InvoiceApp.Views
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView
    {
        public CustomerView()
        {
            InitializeComponent();

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NewCustomerView view = new NewCustomerView();
            view.ShowDialog();
            CustomerViewModel vm = (CustomerViewModel)DataContext;
            vm.GetCustomer();
        }

        private void CustomerView_OnLoaded(object sender, RoutedEventArgs e)
        {
            CustomerViewModel vm = (CustomerViewModel)DataContext;
            vm.GetCustomer();
        }

        private void Delete_OnClick(object sender, RoutedEventArgs e)
        {
            object? item = ((sender as Button)?.Tag as ListViewItem)?.DataContext;
            Customer? customer = (item as Customer);

            if (customer != null)
            {
                CustomerViewModel vm = (CustomerViewModel)DataContext;
                vm.RemoveCustomer(customer);
            }

        }
    }
}
