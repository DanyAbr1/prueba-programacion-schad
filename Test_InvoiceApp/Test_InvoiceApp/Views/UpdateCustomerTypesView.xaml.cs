using Test_InvoiceApp.ViewModels;

namespace Test_InvoiceApp.Views;

/// <summary>
/// Interaction logic for UpdateCustomerTypesView.xaml
/// </summary>
public partial class UpdateCustomerTypesView
{
    public UpdateCustomerTypesView()
    {
        InitializeComponent();
    }

    public CustomerType CustomerTypeUpdate { get; set; }

    private void Update_OnClick(object sender, RoutedEventArgs e)
    {
        UpdateCustomerTypesViewModel vm = (UpdateCustomerTypesViewModel)DataContext;

        CustomerTypeUpdate.Description = TxtDescription.Text;
        vm.UpdateCustomer(CustomerTypeUpdate);
        Close();
    }

    private void Cancel_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}
