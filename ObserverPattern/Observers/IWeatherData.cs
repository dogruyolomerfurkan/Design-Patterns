using ObserverPattern.Subjects;

namespace ObserverPattern.Observers;

public interface IWeatherData : ISubject
{
    float GetHumidity();
    float GetPressure();
    float GetTemperature();
}