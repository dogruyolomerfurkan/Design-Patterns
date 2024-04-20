using ObserverPattern.Observers;

namespace ObserverPattern.Subjects;
public interface ISubject
{
    void Register(IObserver observer);
    void UnRegister(IObserver observer);
    void Notify();
}
