﻿namespace BuilderPattern.Assets;
public sealed record Address
{
    public string? Street {  get; init; }
    public string? City {  get; init; }
    public string? Zip {  get; init; }
    public string? State {  get; init; }
    public string? Country {  get; init; }
}
