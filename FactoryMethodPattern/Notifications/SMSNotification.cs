using FactoryMethodPattern.Clients;

namespace FactoryMethodPattern.Notifications;
public class SMSNotification : INotification
{
    private readonly SmsGateway _smsGateway;

    public SMSNotification(SmsGateway smsGateway)
    {
        _smsGateway = smsGateway;
    }

    public void Notify(string message)
    {
        // SMS geçidi üzerinden mesaj gönderimi yapılır.
        Console.WriteLine($"[SMS] {_smsGateway.ApiEndpoint} üzerinden: {message}");
    }
}
