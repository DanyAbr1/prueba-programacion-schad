using Test_InvoiceApp.Core;
using Test_InvoiceApp.Helper;
using Test_InvoiceApp.Services;
using Test_InvoiceApp.ViewModels;

namespace Test_InvoiceApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public IServiceProvider ServiceProvider;

        public App()
        {
          

            IServiceCollection services = new ServiceCollection();

            services.AddDbContext<InvoiceAppContext>();
            services.AddSingleton(provider => new MainWindow
            {
                DataContext = provider.GetRequiredService<MainViewModel>()
            });

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<CustomerTypeViewModel>();
            services.AddSingleton<CustomerViewModel>();
            services.AddSingleton<NewCustomerViewModel>();
            services.AddSingleton<UpdateCustomerViewModel>();

            services.AddSingleton<INavigationService, NavigationService>();

            services.AddSingleton<Func<Type, ViewModel>>(provider => viewModelType => (ViewModel)provider.GetRequiredService(viewModelType));

            ServiceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            MainWindow mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            DbContextHelper.DbContext =  ServiceProvider.GetRequiredService<InvoiceAppContext>();
            mainWindow.Show();
            base.OnStartup(e);
        }
    }
}
