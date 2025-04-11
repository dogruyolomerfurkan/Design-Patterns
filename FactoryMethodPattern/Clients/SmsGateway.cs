namespace FactoryMethodPattern.Clients;
public class SmsGateway(string apiKey, string apiSecret)
{
    public string ApiKey { get; } = apiKey;
    public string ApiSecret { get; } = apiSecret;
    public string ApiEndpoint { get; } = "https://api.smsprovider.com/send";
}
