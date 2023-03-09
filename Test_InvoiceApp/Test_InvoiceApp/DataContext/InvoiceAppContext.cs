namespace Test_InvoiceApp.DataContext;

public class InvoiceAppContext : DbContext
{
    public InvoiceAppContext(DbContextOptions<InvoiceAppContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.BuildCustomerTable();
    }
}

