using FactoryMethodPattern.Clients;

namespace FactoryMethodPattern.Notifications;
public class EmailNotification : INotification
{
    private readonly SmtpClient _smtpClient;

    // SMTP istemcisini dışarıdan alarak başlatma işlemi karmaşıklaşabilir.
    public EmailNotification(SmtpClient smtpClient)
    {
        _smtpClient = smtpClient;
    }

    public void Notify(string message)
    {
        // Örneğin, SMTP istemcisi üzerinden e-posta gönderim işlemi yapılır.
        Console.WriteLine($"[Email] {_smtpClient.Host}:{_smtpClient.Port} üzerinden: {message}");
    }
}
