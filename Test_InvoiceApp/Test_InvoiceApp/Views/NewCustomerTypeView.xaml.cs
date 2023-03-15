using Test_InvoiceApp.ViewModels;

namespace Test_InvoiceApp.Views
{
    /// <summary>
    /// Interaction logic for NewCustomerView.xaml
    /// </summary>
    public partial class NewCustomerTypeView
    {
        public NewCustomerTypeView()
        {
            InitializeComponent();
        }

        
        private void Create_OnClick(object sender, RoutedEventArgs e)
        {
            NewCustomerTypeViewModel vm = (NewCustomerTypeViewModel)DataContext;
            vm.CreateCustomerType();
            Close();
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
