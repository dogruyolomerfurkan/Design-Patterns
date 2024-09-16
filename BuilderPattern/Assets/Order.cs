namespace BuilderPattern.Assets;
public sealed record Order
{
    public int Number { get; init; }
    public DateTime CreateDate { get; init; }
    public Address? Address { get; init; }
}
