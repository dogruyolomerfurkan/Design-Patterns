using FactoryMethodPattern.Clients;
using FactoryMethodPattern.Notifications;

namespace FactoryMethodPattern.Factories;
public class EmailNotificationFactory : NotificationFactory
{
    // Bu parametreler konfigürasyondan okunur.
    private readonly string _smtpHost;
    private readonly int _smtpPort;

    public EmailNotificationFactory(string smtpHost, int smtpPort)
    {
        _smtpHost = smtpHost;
        _smtpPort = smtpPort;
    }

    public override INotification CreateNotification()
    {
        // SMTP istemcisi başlatılır, ek yapılandırmalar burada yapılabilir.
        SmtpClient client = new SmtpClient(_smtpHost, _smtpPort);
        return new EmailNotification(client);
    }
}
