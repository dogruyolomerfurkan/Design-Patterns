using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Notifications;

string config = GetNotificationConfig(); // "EMAIL" veya "SMS" dönecek şekilde konfigürasyon okuması.
NotificationFactory factory;

if (config == "EMAIL")
{
    // Konfigürasyona göre SMTP ayarları okunur.
    factory = new EmailNotificationFactory("smtp.example.com", 25);
}
else if (config == "SMS")
{
    // API anahtarları ve diğer değerler okunur.
    factory = new SMSNotificationFactory("apiKey123", "apiSecret456");
}
else
{
    throw new ArgumentException("Geçersiz bildirim türü.");
}

// İstemci, yalnızca fabrika metodunu çağırır ve geri dönen nesneyi kullanır.
INotification notification = factory.CreateNotification();
notification.Notify("Bildirim mesajı gönderiliyor.");

static string GetNotificationConfig()
{
    // Bu değer gerçek bir konfigürasyon dosyasından, veritabanından vs. okunabilir.
    return "EMAIL";
}