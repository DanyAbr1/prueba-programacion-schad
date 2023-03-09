namespace Test_InvoiceApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? CustName { get; set; }
        public string? Adress { get; set; }
        public bool Status { get; set; }
        public int CustomerTypeId { get; set; }
    }
}
