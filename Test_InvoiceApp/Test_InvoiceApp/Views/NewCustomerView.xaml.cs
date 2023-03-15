using Test_InvoiceApp.ViewModels;

namespace Test_InvoiceApp.Views
{
    /// <summary>
    /// Interaction logic for NewCustomerView.xaml
    /// </summary>
    public partial class NewCustomerView : Window
    {
        public NewCustomerView()
        {
            InitializeComponent();
        }

        
        private void Create_OnClick(object sender, RoutedEventArgs e)
        {
            NewCustomerViewModel vm = (NewCustomerViewModel)DataContext;
            vm.CreateCustomer();
            Close();
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
