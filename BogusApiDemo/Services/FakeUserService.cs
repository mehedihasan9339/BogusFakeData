using Bogus;
using BogusApiDemo.Models;

namespace BogusApiDemo.Services;

public class FakeUserService
{
    private readonly Faker<User> _userFaker;

    public FakeUserService()
    {
        _userFaker = new Faker<User>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 1)
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(u => u.Address, f => f.Address.StreetAddress())
            .RuleFor(u => u.City, f => f.Address.City())
            .RuleFor(u => u.ZipCode, f => f.Address.ZipCode())
            .RuleFor(u => u.Country, f => f.Address.Country())
            .RuleFor(u => u.DateOfBirth, f => f.Date.Past(40, DateTime.Now.AddYears(-18))) // age 18–58
            .RuleFor(u => u.Company, f => f.Company.CompanyName())
            .RuleFor(u => u.JobTitle, f => f.Name.JobTitle())
            .RuleFor(u => u.Website, f => f.Internet.Url())
            .RuleFor(u => u.CreditCardNumber, f => f.Finance.CreditCardNumber())
            .RuleFor(u => u.Salary, f => f.Finance.Amount(30000, 150000))
            .RuleFor(u => u.AvatarUrl, f => f.Internet.Avatar());
    }

    public IEnumerable<User> GetFakeUsers(int count = 10)
    {
        return _userFaker.Generate(count);
    }
}
