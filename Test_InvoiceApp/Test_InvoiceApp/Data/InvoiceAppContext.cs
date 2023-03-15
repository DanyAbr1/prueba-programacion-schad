using Microsoft.EntityFrameworkCore;
using Test_InvoiceApp.Helper;

namespace Test_InvoiceApp.Data;

public class InvoiceAppContext : DbContext
{
    public IConfiguration Configuration { get; private set; }

    public InvoiceAppContext(DbContextOptions<InvoiceAppContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.BuildCustomerTable();



        //(options => options.UseSqlServer(
        //    
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);


        Configuration = builder.Build();

        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlConnection"));

    }
}

