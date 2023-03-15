using System.Windows.Input;
using System.Windows.Navigation;
using Test_InvoiceApp.ViewModels;

namespace Test_InvoiceApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseApp_OnSelected(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CustomerType_OnSelected(object sender, RoutedEventArgs e)
        {
            MainViewModel vm = (MainViewModel)DataContext;
            vm.NavigateToCustomerType.Execute(this);

        }

        private void Customer_OnSelected(object sender, RoutedEventArgs e)
        {
            MainViewModel vm = (MainViewModel)DataContext;
            vm.NavigateToCustomer.Execute(this);
        }
    }
}
