using FactoryMethodPattern.Notifications;

namespace FactoryMethodPattern.Factories;
public abstract class NotificationFactory
{
    public abstract INotification CreateNotification();

    public void Send(string message)
    {
        INotification notification = CreateNotification();
        notification.Notify(message);
    }
}
