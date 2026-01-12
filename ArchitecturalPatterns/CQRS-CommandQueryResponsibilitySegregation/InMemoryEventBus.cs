using System.Reflection.Metadata;

public class InMemoryEventBus : IEventBus
{
    private readonly Dictionary<Type, List<Delegate>> handlers;

    public InMemoryEventBus() => handlers = new();

    public void Publish<TEvent>(TEvent @event)
    {
        Type type = typeof(TEvent);

        if (handlers.ContainsKey(type))
        {
            foreach(Delegate d in handlers[type])
            {
                ((Action<TEvent>)d)(@event);
            }
        }
    }

    public void Subscribe<TEvent>(Action<TEvent> handler)
    {
        Type type = typeof(TEvent);

        if (!handlers.ContainsKey(type))
        {
            handlers.Add(type, []);
        }

        handlers[type].Add(handler);
    }
}