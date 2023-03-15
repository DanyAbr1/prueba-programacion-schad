using Test_InvoiceApp.ViewModels;

namespace Test_InvoiceApp.Views;

/// <summary>
/// Interaction logic for UpdateCustomerView.xaml
/// </summary>
public partial class UpdateCustomerView : Window
{
    public UpdateCustomerView()
    {
        InitializeComponent();
    }

    public Customer CustomerUpdate { get; set; }

    private void Update_OnClick(object sender, RoutedEventArgs e)
    {
        UpdateCustomerViewModel vm = (UpdateCustomerViewModel)DataContext;

        CustomerUpdate.CustName = TxtCustName.Text;
        CustomerUpdate.Adress = TxtAddress.Text;
        vm.UpdateCustomer(CustomerUpdate);
        Close();
    }

    private void Cancel_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}
