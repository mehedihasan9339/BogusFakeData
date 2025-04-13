namespace BogusApiDemo.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string Address { get; set; } = "";
    public string City { get; set; } = "";
    public string ZipCode { get; set; } = "";
    public string Country { get; set; } = "";
    public DateTime DateOfBirth { get; set; }
    public string Company { get; set; } = "";
    public string JobTitle { get; set; } = "";
    public string Website { get; set; } = "";
    public string CreditCardNumber { get; set; } = "";
    public decimal Salary { get; set; }
    public string AvatarUrl { get; set; } = "";
}
