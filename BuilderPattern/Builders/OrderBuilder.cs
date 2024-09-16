using BuilderPattern.Assets;

namespace BuilderPattern.Builders;
public sealed class OrderBuilder
{
    private OrderBuilder() { }

    private int _number;
    private DateTime _createDate;
    private readonly AddressBuilder _address = AddressBuilder.Empty();

    public static OrderBuilder Empty() => new();

    public OrderBuilder WithNumber(int number)
    {
        _number = number;
        return this;
    }

    public OrderBuilder WithDate(DateTime createDate)
    {
        _createDate = createDate;
        return this;
    }

    public OrderBuilder WithAddress(Action<AddressBuilder> action)
    {
        action(_address);
        return this;
    }

    public Order Build() => new()
    {
        CreateDate = _createDate,
        Number = _number,
        Address = _address.Build()
    };
}
