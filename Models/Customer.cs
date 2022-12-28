#pragma warning disable CS8632
// pgroutiner auto-generated code

namespace dvdrental.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public short StoreId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Email { get; set; }
    public short AddressId { get; set; }
    public bool Activebool { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? LastUpdate { get; set; }
    public int? Active { get; set; }
}
