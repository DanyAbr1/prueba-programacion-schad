using System.Windows.Input;

namespace Test_InvoiceApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly InvoiceAppContext _dbContext;

        public MainWindow(InvoiceAppContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        public MainWindow()
        {
                
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_Btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_customers.Visibility = Visibility.Collapsed;
                tt_close.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_customers.Visibility = Visibility.Visible;
                tt_close.Visibility = Visibility.Visible;
            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 0.3;
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void ListBoxItem_OnSelected(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
