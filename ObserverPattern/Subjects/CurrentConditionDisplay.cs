using ObserverPattern.Observers;

namespace ObserverPattern.Subjects;
public class CurrentConditionDisplay : IObserver, IDisplayElement
{
    private readonly IWeatherData _subject;
    private float Temperature { get; set; }

    public CurrentConditionDisplay(IWeatherData subject)
    {
        _subject = subject;
        subject.Register(this);
    }
    public void Display()
    {
        Console.WriteLine($"CurrentConditionDisplay displaying temperature as : {Temperature}");
    }

    public void Update()
    {
        Temperature = _subject.GetTemperature();

        Display();
    }
}
