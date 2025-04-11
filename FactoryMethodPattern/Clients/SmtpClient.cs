namespace FactoryMethodPattern.Clients;
public class SmtpClient(string host, int port)
{
    public string Host { get; } = host;
    public int Port { get; } = port;
}
