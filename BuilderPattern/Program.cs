using BuilderPattern.Builders;

var order = OrderBuilder.Empty()
    .WithNumber(10)
    .WithDate(DateTime.UtcNow)
    .WithAddress(builder => builder
        .Country("Turkiye")
        .City("Istanbul")
        .Zip("34000"))
    .Build();

Console.WriteLine(order);
