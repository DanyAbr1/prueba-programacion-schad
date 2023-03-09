namespace Test_InvoiceApp.DataContext
{
    public class InvoiceAppContext: DbContext
    {
        public InvoiceAppContext(DbContextOptions<InvoiceAppContext> options) : base(options)
        {

        }
    }
}
