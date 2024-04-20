namespace ObserverPattern.Observers;
public class WeatherData : IWeatherData
{
    public List<IObserver> Observers { get; set; } = [];

    private float Temperature { get; set; }
    private float Humidity { get; set; }
    private float Pressure { get; set; }


    public void Register(IObserver observer)
    {
        Console.WriteLine($"{observer.GetType().Name} is registered.");
        Observers.Add(observer);
    }

    public void UnRegister(IObserver observer)
    {
        Console.WriteLine($"{observer.GetType().Name} is unregistered.");
        Observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in Observers)
        {
            observer.Update();
        }
    }

    public void MeasurementsChanged()
    {
        Console.WriteLine("Measurements has changed, observers notifying.");
        Notify();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;

        MeasurementsChanged();
    }

    public float GetTemperature() => Temperature;
    public float GetHumidity() => Humidity;
    public float GetPressure() => Pressure;
}
