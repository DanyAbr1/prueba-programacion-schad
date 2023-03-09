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
    }
}
