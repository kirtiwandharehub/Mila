public class EventBus
{
    private readonly Dictionary<Type, List<Action<Object>>> subscribers;

    public EventBus()
    {
        subscribers = new();
    }

    public void Subscribe<T>(Action<T> handler)
    {
        if (!subscribers.ContainsKey(typeof(T)))
        {
            subscribers.Add(typeof(T), new List<Action<Object>>());
        }

        subscribers[typeof(T)].Add(o => handler((T)o));
    }

    public void Publish<T>(T @event)
    {
        if (subscribers.ContainsKey(typeof(T)))
        {
            foreach(Action<Object> handler in subscribers[typeof(T)])
            {
                handler(@event);
            }
        }
    }
}