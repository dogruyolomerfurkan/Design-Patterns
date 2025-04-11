using FactoryMethodPattern.Clients;
using FactoryMethodPattern.Notifications;

namespace FactoryMethodPattern.Factories;
public class SMSNotificationFactory : NotificationFactory
{
    private readonly string _apiKey;
    private readonly string _apiSecret;

    public SMSNotificationFactory(string apiKey, string apiSecret)
    {
        _apiKey = apiKey;
        _apiSecret = apiSecret;
    }

    public override INotification CreateNotification()
    {
        // SMS geçidi için gerekli tüm başlatma işlemleri burada halledilir.
        SmsGateway gateway = new SmsGateway(_apiKey, _apiSecret);
        return new SMSNotification(gateway);
    }
}
