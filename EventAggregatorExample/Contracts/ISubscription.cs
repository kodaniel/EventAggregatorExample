namespace EventAggregatorExample.Contracts;

public enum ThreadOptions
{
    Publisher,
    UiThread,
    Background
}

public interface ISubscription<T> where T : IMessage
{
    ThreadOptions ThreadOptions { get; }

    void Invoke(T eventData);
}
