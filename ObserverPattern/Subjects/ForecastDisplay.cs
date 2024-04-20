using ObserverPattern.Observers;

namespace ObserverPattern.Subjects;
internal class ForecastDisplay : IObserver, IDisplayElement
{
    private readonly IWeatherData _subject;
    private float Temperature { get; set; }
    private float Humidity { get; set; }
    private float Pressure { get; set; }

    public ForecastDisplay(IWeatherData subject)
    {
        _subject = subject;
        _subject.Register(this);
    }

    public void Display()
    {
        Console.WriteLine($"ForecastDisplay displaying temperature as : {Temperature}, humidity as : {Humidity}, pressure as : {Pressure}.");
    }

    public void Update()
    {
        Temperature = _subject.GetTemperature();
        Humidity = _subject.GetHumidity();
        Pressure = _subject.GetPressure();

        Display();
    }
}
