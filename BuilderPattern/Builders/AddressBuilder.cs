using BuilderPattern.Assets;

namespace BuilderPattern.Builders;
public sealed class AddressBuilder
{
    private string? _street;
    private string? _city;
    private string? _zip;
    private string? _state;
    private string? _country;

    private AddressBuilder() { }
    public static AddressBuilder Empty() => new();

    public AddressBuilder City(string? city)
    {
        _city = city;
        return this;
    }

    public AddressBuilder Zip(string? zip)
    {
        _zip = zip;
        return this;
    }

    public AddressBuilder Street(string? street)
    {
        _street = street;
        return this;
    }

    public AddressBuilder State(string? state)
    {
        _state = state;
        return this;
    }

    public AddressBuilder Country(string? country)
    {
        _country = country;
        return this;
    }

    public Address Build() => new()
    {
        City = _city,
        Country = _country,
        State = _state ?? "N/A",
        Street = _street,
        Zip = _zip,
    };
}
