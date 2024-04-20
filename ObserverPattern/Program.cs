using ObserverPattern.Observers;
using ObserverPattern.Subjects;

var subject = new WeatherData();

var currentConditionDisplay = new CurrentConditionDisplay(subject);

_ = new ForecastDisplay(subject);

subject.SetMeasurements(35.6f, 20.8f, 11.5f);

subject.UnRegister(currentConditionDisplay);

subject.SetMeasurements(25.6f, 10.8f, 14.5f);
